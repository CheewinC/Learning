using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class LearningLIFF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                LearningDataContext db = new LearningDataContext();

                var found = db.LineUsers.SingleOrDefault(x => x.LineUserId == hdnUserIdProfileField.Value);
                if (found == null)
                {
                    db.LineUsers.InsertOnSubmit(new LineUser
                    {
                        LineUserId = hdnUserIdProfileField.Value,
                        MobileNo = txtMobileNo.Text,
                        CreateDate = DateTime.Now
                    });
                }
                else
                    found.MobileNo = txtMobileNo.Text;
                db.SubmitChanges();
                G.Alert(this, "Success");
                var script = @"liff.init({liffId: ""1614834775-a0mOA8vd""}).then(() => {liff.closeWindow();});";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", script, true);
            }
            catch (Exception ex)
            {
                G.Alert(this, ex.Message);
            }
        }
    }
}