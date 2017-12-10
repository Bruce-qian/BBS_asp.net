using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class home_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            btnSet.Enabled = false;
            btnQuit.Enabled = false;
            btnQuit.Visible = false;
            btnSet.Visible = false;
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
        }
        else {
            btnSet.Enabled = true;
            btnQuit.Enabled = true;
            btnSet.Visible = true;
            btnQuit.Visible = true;
            btnLogin.Enabled = false;
            btnLogin.Visible = false;
        }
        HtmlControl headfrm = (HtmlControl)this.FindControl("headfrm");
       // HtmlControl leftfrm = (HtmlControl)this.FindControl("leftfrm");
        HtmlControl rightfrm = (HtmlControl)this.FindControl("rightfrm");
        headfrm.Attributes["src"] = "head.aspx";//初始时在iframe中加载一个页面
       // leftfrm.Attributes["src"] = "left.aspx";//初始时在iframe中加载一个页面
        rightfrm.Attributes["src"] = "default_page.aspx";//初始时在iframe中加载一个页面
    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        Application["class"] = TreeView1.SelectedValue;//传值到title_list
        rightfrm.Attributes["src"] = "title_list.aspx";//在iframe中加载title_list
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        rightfrm.Attributes["src"] = "login.aspx";//在iframe中加载一个页面
    }
}