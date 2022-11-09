﻿using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Translation;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Speech_Translation
{
    class Program
    {
        private static SpeechConfig speechConfig;
        private static SpeechTranslationConfig translationConfig;

        static async Task Main(string[] args)
        {
            try
            {
                // Get config settings from AppSettings
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();

                string cogSvcKey = configuration["CognitiveServiceKey"];
                string cogSvcRegion = configuration["CognitiveServiceRegion"];


                // Configure translation
                translationConfig = SpeechTranslationConfig.FromSubscription(cogSvcKey, cogSvcRegion);

                translationConfig.SpeechRecognitionLanguage = "en-US";
                translationConfig.AddTargetLanguage("fr");
                translationConfig.AddTargetLanguage("es");
                translationConfig.AddTargetLanguage("hi");

                Console.WriteLine("Ready to translate from " + translationConfig.SpeechRecognitionLanguage);


                // Configure speech
                speechConfig = SpeechConfig.FromSubscription(cogSvcKey, cogSvcRegion);


                string targetLanguage = "";

                while (targetLanguage != "quit")
                {
                    Console.WriteLine("\nEnter a target language\n fr = French\n es = Spanish\n hi = Hindi\n Enter anything else to stop\n");

                    targetLanguage = Console.ReadLine().ToLower();

                    if (translationConfig.TargetLanguages.Contains(targetLanguage))
                    {
                        await Translate(targetLanguage);
                    }
                    else
                    {
                        targetLanguage = "quit";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async Task Translate(string targetLanguage)
        {
            string translation = "";

            // Translate speech
            string audioFile = "station.wav";

            SoundPlayer wavPlayer = new SoundPlayer(audioFile);
            wavPlayer.Play();

            using AudioConfig audioConfig = AudioConfig.FromWavFileInput(audioFile);
            using TranslationRecognizer translator = new TranslationRecognizer(translationConfig, audioConfig);

            Console.WriteLine("Getting speech from file...");

            TranslationRecognitionResult result = await translator.RecognizeOnceAsync();
            Console.WriteLine($"Translating '{result.Text}'");

            translation = result.Translations[targetLanguage];
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(translation);


            // Synthesize translation
            var voices = new Dictionary<string, string>
            {
                ["fr"] = "fr-FR-Julie",
                ["es"] = "es-ES-Laura",
                ["hi"] = "hi-IN-Kalpana"
            };

            speechConfig.SpeechSynthesisVoiceName = voices[targetLanguage];

            using SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer(speechConfig);

            SpeechSynthesisResult speak = await speechSynthesizer.SpeakTextAsync(translation);

            if (speak.Reason != ResultReason.SynthesizingAudioCompleted)
            {
                Console.WriteLine(speak.Reason);
            }
        }
    }
}