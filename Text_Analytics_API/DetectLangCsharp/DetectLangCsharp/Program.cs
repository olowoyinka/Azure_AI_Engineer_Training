using Azure;
using Azure.AI.TextAnalytics;
using System;

namespace DetectLangCsharp
{
    class Program
    {
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("c2d25bd4eeeb4c56b47227901a586462");
        private static readonly Uri endpoint = new Uri("https://yinkacognitive.cognitiveservices.azure.com/");

        static void Main(string[] args)
        {
            var client = new TextAnalyticsClient(endpoint, credentials);

            DetectLanguage(client);

            Console.Write("Press any key to exit.");
            
            Console.ReadKey();
        }

        static void DetectLanguage(TextAnalyticsClient client)
        {
            DetectedLanguage detectedLanguage = client.DetectLanguage("Ce document est rédigé en Français.");

            Console.WriteLine("Language:");
            
            Console.WriteLine($"\t{detectedLanguage.Name},\tISO-6391: {detectedLanguage.Iso6391Name}\n");
        }
    }
}