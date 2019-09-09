using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class LineBot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnSend_Click(object sender, EventArgs e)
        {
            const string chanelAccessToken = "CLuc3B+qzeEyQmcFTsfmeUavnzpNawYxwb/Pc0rGQjcMpmhHvIePz1N9QVYjCywKZ9Rn5vQLKMf2dyr8oQc1HxsM20JpOQbILkaqHBnls3eNAXkFDfIp8on2vL0Ls8/V/yPdoZufm1OKOPCBIn0s7gdB04t89/1O/w1cDnyilFU=";
            HttpClient httpClient = new HttpClient();
            Uri baseUri  = new Uri("https://api.line.me/v2/bot/message/broadcast");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", chanelAccessToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            RequestBoardCast requestBoardCast = new RequestBoardCast
            {
                messages = new List<Textmessage> { new Textmessage { type = "text",text = txtMessage.Text} }
            };
            string jsonString = JsonConvert.SerializeObject(requestBoardCast);
            StringContent content = new StringContent(jsonString);
            var response = await httpClient.PostAsync(baseUri, content);
            var result = await response.Content.ReadAsStringAsync();
        }
        
        public class RequestBoardCast
        {
            public List<Textmessage> messages { get; set; }
            public bool notificationDisabled { get; set; }
        }

        public class Textmessage
        {
            public string type { get; set; }
            public string text { get; set; }
        }
    }
}