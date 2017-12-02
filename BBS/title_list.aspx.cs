using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class title_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //隐藏列读取数据完成，下面是关键代码，使用DataKeyNames和DataKeys完成的，下面要将读取的隐藏数据传送给下一个网页
        GridView1.Columns[0].Visible = false;
        //将帖子id及帖子标题传送到essay.aspx
        GridView1.DataKeyNames = new string[] { "post_id" , "post_title" };
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //跳转到帖子的内容页
        // txtid.Text = GridView1.Rows(GridView1.SelectedIndex).Cells(1).Text '获取第二列
        int i = GridView1.SelectedIndex;
        //TextBox1.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text;

        TextBox1.Text = GridView1.DataKeys[GridView1.SelectedIndex]["post_id"].ToString();
        Application["post_id"] = GridView1.DataKeys[GridView1.SelectedIndex]["post_id"].ToString();
        Application["post_title"] = GridView1.DataKeys[GridView1.SelectedIndex]["post_title"].ToString();
        //ViewState["essayId"] = GridView1.DataKeys[GridView1.SelectedIndex]["bbs_title"].ToString();
        //TextBox1.Text = GridView1.DataKeys[GridView1.SelectedIndex]["bbs_title"].ToString();
        Response.Redirect("essay.aspx");//跳转到内容页
    }
}