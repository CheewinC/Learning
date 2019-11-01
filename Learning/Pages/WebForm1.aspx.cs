using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Tree> Trees
        {
            get { return Session["Trees"] as List<Tree>; }
            set { Session["Trees"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string results1 = Snippet.func(@"O V.7\nG ทะเบียนรถ - ต้นหาด้วย x\nX\\\nteqPZiWrvecli5fXLcpWEUQ%...\n2\nฎง 9999\nกรุงเทพมหานคร\nง)\nล\n");
                string results2 = Snippet.func(@"8ณ-9174\nกรุงเทพมหานคร\n(Uส\nthaisecondhand.com\nThaiSecondhand แหล่งซื้อขายของมือสอง ขา\nมือสอง\n");
                string results3 = Snippet.func(@"ณท.3368\nกรุงเทพมหานคร 0\n");

                LearningDataContext db = new LearningDataContext();
                Trees = db.Trees.ToList();
                string result = CreateNote(0);
                ltrTree.Text = @"<ul>" + result + @"<ul>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('success')", true);

                List<Tree> parent = Trees.Where(x => x.ParentId == 0).ToList();
                foreach (Tree item in parent)
                {
                    TreeNode node = new TreeNode(item.Name, item.Id.ToString());
                    tvTree.Nodes.Add(node);
                    AddChildNode(ref node);
                }        
            }
        }
        protected string CreateNote(int parentId)
        {
            string result = "";
            List<Tree> trees = Trees.Where(x => x.ParentId == parentId).ToList();
            foreach (Tree item in trees)
            {
                List<Tree> childs = Trees.Where(x => x.ParentId == item.Id).ToList();
                if (childs.Count == 0)
                {
                    result += @"<li>" + item.Name + @"</li>";
                }
                else
                {
                    result += @"<li><span>" + item.Name + @"</span><ul>";
                    result += CreateNote(item.Id);
                    result += @"</ul></li>";
                }
            }
            return result;
        }

        protected void AddChildNode(ref TreeNode node)
        {
            int id = int.Parse(node.Value);
            List<Tree> childNode = Trees.Where(x => x.ParentId == id).ToList();
            if (childNode.Count > 0)
            {
                foreach (Tree item in childNode)
                {
                    TreeNode chlid = new TreeNode(item.Name, item.Id.ToString());
                    node.ChildNodes.Add(chlid);
                    AddChildNode(ref chlid);
                } 
            }
        }
        protected void tvTree_SelectedNodeChanged(object sender, EventArgs e)
        {
            txtSelectedNode.Text = "You selected: " + tvTree.SelectedNode.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('success')", true);
        }
    }
}