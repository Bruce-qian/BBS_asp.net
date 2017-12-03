using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

public partial class home : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlControl frame1 = (HtmlControl)this.FindControl("frame1");
        frame1.Attributes["src"] = "login.aspx";//初始时在iframe中加载一个页面
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        Application["class"] = TreeView1.SelectedValue;
        /*
        if (TreeView1.SelectedValue == "C++") {
            //C++论坛
            frame1.Attributes["src"] = "title_list.aspx";//在iframe中显示一个页面
        }
        if (TreeView1.SelectedValue == "JAVA") {
            //java论坛
            frame1.Attributes["src"] = "title_list.aspx";
        }
        if (TreeView1.SelectedValue == "PHP") {
            //PHP论坛
            frame1.Attributes["src"] = "title_list.aspx";
        }
        */
    }
}