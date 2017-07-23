using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNavigation
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Menu üzerine item eklemek
                MenuItem mitm = new MenuItem();
                mitm.Text = "Database Management";
                mitm.Value = "4";
                mitm.NavigateUrl = "~/Database.aspx";
                Menu1.Items.Add(mitm);

                MenuItem citm = new MenuItem();
                citm.Text = "MS-SQL Server";
                citm.Value = "5";
                citm.NavigateUrl = "~/MSSQL.aspx";
                mitm.ChildItems.Add(citm);

                MenuItem citm1 = new MenuItem();
                citm1.Text = "Oracle Server";
                citm1.Value = "6";
                citm1.NavigateUrl = "~/Oracle.aspx";
                Menu1.Items[3].ChildItems.Add(citm1);

                //TreeVşew menğsğne nodes eklemek
                TreeNode tnode = new TreeNode();
                tnode.Text = "Database Management";
                tnode.Value = "4";
                tnode.NavigateUrl = "~/Database.aspx";
                TreeView1.Nodes.Add(tnode);

                TreeNode cnode = new TreeNode();
                cnode.Text = "MS-SQL Server";
                cnode.Value = "5";
                cnode.NavigateUrl = "~/MSSQL.aspx";
                tnode.ChildNodes.Add(cnode);
            }
        }
    }
}