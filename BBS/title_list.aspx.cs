using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
        base.Application["post_id"] = GridView1.DataKeys[GridView1.SelectedIndex]["post_id"].ToString();
        base.Application["post_title"] = GridView1.DataKeys[GridView1.SelectedIndex]["post_title"].ToString();
        //ViewState["essayId"] = GridView1.DataKeys[GridView1.SelectedIndex]["bbs_title"].ToString();
        //TextBox1.Text = GridView1.DataKeys[GridView1.SelectedIndex]["bbs_title"].ToString();
        Response.Redirect("essay.aspx");//跳转到内容页
    }

    protected void btnApplication_Click(object sender, EventArgs e)
    {
        //Session["limit"] = (int)0;////测试数据
        //先从版主申请规则表中读取数据，看申请者是否符合版主申请条件：会员，活跃度高（待定规则）
        int limit = 100;
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "select * from ruletable where type = 1";//初始化该对象的连接字串
        SqlDataReader sqlDr = sqlComGet.ExecuteReader();   //创建SqlDataReader对象,执行sql语句
        if (sqlDr.Read())                                 
        {
            limit = (int)sqlDr["limit"];
            if ((int)Session["limit"] <= limit)
            {//规则通过
                //传论坛参数
                //Request.Redirect("Moderator.aspx?forumId = " + "C++");
                Application["forumId"] = "C++";//////////////这里的C++后面要换成从主页传过来的论坛参数
                Response.Redirect("Moderator.aspx");//跳转到申请页
            }
            else {
                Response.Write("<script>alert('申请条件需达到会员及以上')</script>");
            }
        }
        else {
            Response.Write("<script>alert('操作失败')</script>");
        }
        
    }
}