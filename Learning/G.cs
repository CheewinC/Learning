using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Learning
{
    public class G
    {
        public static void Alert(Page p, string txt)
        {
            txt = txt.Replace("'", "\"");
            txt = txt.Replace("\r", "");
            txt = txt.Replace("\n", "");
            ScriptManager.RegisterStartupScript(p, p.GetType(), "DotNetAlert", "alert('" + txt + "');", true);
        }

        public static void AlertAndRedirect(Page p, string txt, string url)
        {
            txt = txt.Replace("'", "\"");
            txt = txt.Replace("\r", "");
            txt = txt.Replace("\n", "");
            ScriptManager.RegisterStartupScript(p, p.GetType(), "DotNetAlert", "alert('" + txt + "'); window.location.href = '" + url + "';", true);
        }
    }
}