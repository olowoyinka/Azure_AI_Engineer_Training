using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KeyPhrase_Csharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string key = "c2d25bd4eeeb4c56b47227901a586462";
            string endpoint = "https://yinkacognitive.cognitiveservices.azure.com/";

            await ExtractKeyPhrases(endpoint, key);
        }

        public static async Task ExtractKeyPhrases(string endpoint, string key)
        {
            var credentials = new ApiKeyServiceClientCredentials(key);
            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            // Create a strongly-typed list to store the sentences that will be passed to the service
            List<String> phraseList = new List<string>();

            // Add two sentences to the list
            phraseList.Add("Bill Gates and Paul Allen founded Microsoft, in part, to develop a BASIC interpreter for the popular Altair 8800 personal computer.");
            phraseList.Add("La sede principal de Microsoft se encuentra en la ciudad de Redmond, a 21 kilómetros de Seattle.");

            // loop through the list and pass in each sentence to key phrase extraction service
            foreach (string doc in phraseList)
            {
                var response = await client.KeyPhrasesAsync(doc);

                // iterate over the returned key phrases and output them to the console
                foreach (string keyphrase in response.KeyPhrases)
                {
                    Console.WriteLine($"\t{keyphrase}");
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
}
