using Learning.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class LineNotify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected async void btnSend_Click(object sender, EventArgs e)
        {
            const string token = "gLOudEEz5a1GsLFTcvH5z16DNXDICXc8o63l75Nvsot";
            HttpClient httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            //Dictionary<string, string> values = new Dictionary<string, string>
            //    {
            //        { "message",txtMessage.Text },
            //    };
            //var content = new FormUrlEncodedContent(values);  

            HttpContent content = new FormUrlEncodedContent(new []
            {
                new KeyValuePair<string, string>("message", txtMessage.Text)
            });
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await httpClient.PostAsync("https://notify-api.line.me/api/notify", content);
            var result = await response.Content.ReadAsStringAsync();
            ResponseLineNoti responseLineNoti = JsonConvert.DeserializeObject<ResponseLineNoti>(result);
        }
    }
}