using Line.Messaging;
using Line.Messaging.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LineBotApp.Controllers
{
    public class ValuesController : ApiController
    {
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        protected override async Task OnMessageAsync(MessageEvent ev)
        {
            switch (ev.Message.Type)
            {
                case EventMessageType.Text:
                    await HandleTextAsync(ev.ReplyToken, ((TextEventMessage)ev.Message).Text, ev.Source.UserId);
                    break;
            //    case EventMessageType.Image:
            //    case EventMessageType.Audio:
            //    case EventMessageType.Video:
            //    case EventMessageType.File:
            //        // Prepare blob directory name for binary object.
            //        var blobDirectoryName = ev.Source.Type + "_" + ev.Source.Id;
            //        await HandleMediaAsync(ev.ReplyToken, ev.Message.Id, blobDirectoryName, ev.Message.Id);
            //        break;
            //    case EventMessageType.Location:
            //        var location = ((LocationEventMessage)ev.Message);
            //        await HandleLocationAsync(ev.ReplyToken, location);
            //        break;
            //    case EventMessageType.Sticker:
            //        await HandleStickerAsync(ev.ReplyToken);
            //        break;
            }
        }

        private async Task HandleTextAsync(string replyToken, string userMessage, string userId)
        {
            userMessage = userMessage.ToLower().Replace(" ", "");
            ISendMessage replyMessage = null;
            if (userMessage == "buttons")
            {
                replyMessage = new TemplateMessage("Button Template",
                    new ButtonsTemplate(text: "ButtonsTemplate", title: "Click Buttons.",
                    actions: new List<ITemplateAction> {
                        new MessageTemplateAction("Message Label", "sample data"),
                        new PostbackTemplateAction("Postback Label", "sample data", "sample data"),
                    new UriTemplateAction("Uri Label", "https://github.com/kenakamu")
                    }));
            }
        }

    }
}
