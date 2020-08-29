using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;

namespace GetTopQuestion
{
    public static class GetTopQuestion
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            var client = new MongoClient("mongodb+srv://simeyAdmin:admin@cluster0.jzkv8.gcp.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("questionBank");
            var collection = database.GetCollection<BsonDocument>("questions");
            var documents = collection.Find(new BsonDocument()).ToList(); 

            return new OkObjectResult(documents[1].ToString());
        }
    }
}
