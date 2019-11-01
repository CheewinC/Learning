﻿using Newtonsoft.Json;
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
        const string chanelAccessToken = "zdS4xMEmH0A5YsNHtJ8LYbqQFVb1e1HThquZFVpkL5W8D9cTLlOI+jsq2ZlWCGu8Z9Rn5vQLKMf2dyr8oQc1HxsM20JpOQbILkaqHBnls3f+dHdZHRmNek+E1m7gexZgq7oBODYoFzIbJo5gBwOm/gdB04t89/1O/w1cDnyilFU=";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnSend_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            Uri baseUri  = new Uri("https://api.line.me/v2/bot/message/broadcast");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", chanelAccessToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            RequestBoardCast requestBoardCast = new RequestBoardCast
            {
                messages = new List<Textmessage> { new Textmessage { type = "text",text = txtMessage.Text} }
            };
            string jsonString = JsonConvert.SerializeObject(requestBoardCast);
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(baseUri, content);
            var result = await response.Content.ReadAsStringAsync();
        }
        
        protected async void btnSendTo_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            Uri baseUri = new Uri("https://api.line.me/v2/bot/message/push");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", chanelAccessToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            RequestPushMessage requestBoardCast = new RequestPushMessage
            {   to = txtUserId.Text,
                messages = new List<Textmessage> { new Textmessage { type = "text", text = txtMsg.Text } }
            };
            string jsonString = JsonConvert.SerializeObject(requestBoardCast);
            StringContent content = new StringContent(jsonString,Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(baseUri, content);
            var result = await response.Content.ReadAsStringAsync();
        }

        public class RequestBoardCast
        {
            public List<Textmessage> messages { get; set; }
            public bool notificationDisabled { get; set; }
        }

        public class RequestPushMessage
        {
            public string to { get; set; }
            public List<Textmessage> messages { get; set; }
        }

        public class Textmessage
        {
            public string type { get; set; }
            public string text { get; set; }
        }
    }
}