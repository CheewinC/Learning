using Line.Messaging;
using Line.Messaging.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LearningLineBotApp.Controllers
{
    public class ValuesController : ApiController
    {
        private static LineMessagingClient lineMessagingClient;
        private string accessToken = Properties.Settings.Default.accessToken;
        private string channelSecret = Properties.Settings.Default.channelSecret;
        public ValuesController()
        {
            lineMessagingClient = new LineMessagingClient(accessToken);
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public async Task<IHttpActionResult> PostAsync(HttpRequestMessage request)
        {
            string jsonContent = request.Content.ReadAsStringAsync().Result;
            DataClasses1DataContext db = new DataClasses1DataContext();
            JSONLog a = new JSONLog() { Message = jsonContent };
            db.JSONLogs.InsertOnSubmit(a);
            db.SubmitChanges();

            var events = await request.GetWebhookEventsAsync(channelSecret);
            //var connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
            //var blobStorage = await BlobStorage.CreateAsync(connectionString, "linebotcontainer");
            //var eventSourceState = await TableStorage<EventSourceState>.CreateAsync(connectionString, "eventsourcestate");

            var app = new LineBotApp(lineMessagingClient);
            await app.RunAsync(events);


            return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
