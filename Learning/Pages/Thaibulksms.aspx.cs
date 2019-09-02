using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class Thaibulksms : System.Web.UI.Page
    {
        private static readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUrl.Text = "http://thaibulksms.com/sms_api_test.php";
                txtUsername.Text = "thaibulksms";
                txtPassword.Text = "thisispassword";
            }
        }

        protected async void btnSend_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> values = new Dictionary<string, string>
                {
                    { "username",txtUsername.Text },
                    { "password",txtPassword.Text },
                    { "msisdn",txtTel.Text },
                    { "message",txtMessage.Text }
                };
            //Task<string> tas = new Task<string>();
            string linkUrl = @"http://thaibulksms.com/sms_api_test.php?username=xxxx&password=thisispassword&msisdn=0965967789&message=test";
            var content = new FormUrlEncodedContent(values);

            //POST
            var response = await client.PostAsync(txtUrl.Text, content);
            var result = response.Content.ReadAsStringAsync();

            //GET
            var responseString = await client.GetStringAsync(linkUrl);
        }
    }
}