using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class SignalRWithGridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LearningDataContext db = new LearningDataContext();
                gvTree.DataSource = db.Trees;
                gvTree.DataBind();
            }
        }
    }
}