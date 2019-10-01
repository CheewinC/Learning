using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = Google.Cloud.Vision.V1.Image;

namespace Learning.Pages
{
    public partial class GoogleOCR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory
            var image = Image.FromFile(@"C:\Users\NecC\Downloads\69597698_2263657030613474_151965357500792832_n.jpg");
            // Performs label detection on the image file
            var response = client.DetectLabels(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
        }
    }
}