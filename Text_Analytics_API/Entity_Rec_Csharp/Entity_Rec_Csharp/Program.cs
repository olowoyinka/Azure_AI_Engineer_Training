using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Entity_Rec_Csharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string key = "c2d25bd4eeeb4c56b47227901a586462";
            string endpoint = "https://yinkacognitive.cognitiveservices.azure.com/";

            await RecognizeEntities(endpoint, key);
        }

        public static async Task RecognizeEntities(string endpoint, string key)
        {
            var credentials = new ApiKeyServiceClientCredentials(key);

            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            // The documents to be submitted for entity recognition. The ID can be any value.
            var inputDocuments = new MultiLanguageBatchInput(
                new List<MultiLanguageInput>
                {
                    new MultiLanguageInput("1", "Microsoft was founded by Bill Gates and Paul Allen on April 4, 1975, to develop and sell BASIC interpreters for the Altair 8800.", "en"),
                    new MultiLanguageInput("2", "La sede principal de Microsoft se encuentra en la ciudad de Redmond, a 21 kilómetros de Seattle.", "es")
                });

            var entitiesResult = await client.EntitiesBatchAsync(inputDocuments);

            // Printing recognized entities
            Console.WriteLine("===== Named Entity Recognition & Entity Linking =====\n");

            foreach (var document in entitiesResult.Documents)
            {
                Console.WriteLine($"Document ID: {document.Id} ");

                Console.WriteLine("\t Entities:");

                foreach (var entity in document.Entities)
                {
                    Console.WriteLine($"\t\tName: {entity.Name},\tType: {entity.Type ?? "N/A"},\tSub-Type: {entity.SubType ?? "N/A"}");

                    Console.WriteLine($"\t\tWikipediaId: {entity.WikipediaId},\tBingId: {entity.BingId ?? "N/A"},\tWikipediaUrl: {entity.WikipediaUrl ?? "N/A"}");

                    foreach (var match in entity.Matches)
                    {
                        Console.WriteLine($"\t\t\tOffset: {match.Offset},\tLength: {match.Length},\tScore: {match.EntityTypeScore:F3}");
                    }
                }
            }

            Console.WriteLine();
        }
    }

    // <clientClass>
    class ApiKeyServiceClientCredentials : ServiceClientCredentials
    {
        private readonly string apiKey;

        public ApiKeyServiceClientCredentials(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            request.Headers.Add("Ocp-Apim-Subscription-Key", this.apiKey);

            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
    // </clientClass>
}