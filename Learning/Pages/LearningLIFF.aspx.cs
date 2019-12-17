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
                string userId = hdnUserIdProfileField.Value;
                string displayName = hdnDisplayNameField.Value;
                string profilePicture = hdnProfilePictureDiv.Value;
                string statusMessage = hdnStatusMessageField.Value;

                var found = db.LineUsers.SingleOrDefault(x => x.LineUserId == userId);
                if (found == null)
                {
                    db.LineUsers.InsertOnSubmit(new LineUser
                    {
                        LineUserId = userId,
                        DisplayName = displayName,
                        ProfilePicture = profilePicture,
                        StatusMessage = statusMessage,
                        MobileNo = txtMobileNo.Text,
                        CreateDate = DateTime.Now
                    });
                }
                else
                {
                    if (found.DisplayName != displayName || found.ProfilePicture != profilePicture 
                        || found.StatusMessage != statusMessage || found.MobileNo != txtMobileNo.Text)
                    {
                        found.DisplayName = displayName;
                        found.ProfilePicture = profilePicture;
                        found.StatusMessage = statusMessage;
                        found.MobileNo = txtMobileNo.Text;
                        found.ModifyDate = DateTime.Now;
                    }
                }
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