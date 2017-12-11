using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pushessay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void txtessay_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //简陋的帖子发表功能已经完成，下面的工作就是将数据库中的表项进一步完善
        string title = txtTittle.Text;
        string essay = txtessay.Text;
        string data = DateTime.Now.ToString();
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        //初始化该对象的连接字串
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "insert into Send_Post_Count_Table(bbs_id, user_id, post_title, Post_content, Post_publish_time) values(" + DropDownList1.SelectedValue + "," + Session["UserID"].ToString() + ",'" + title + "','" + essay + "','" + data + "')";
        int update = sqlComGet.ExecuteNonQuery();//执行sql语句并返回受影响的行数
        if (update != 0)
        {
            Response.Write("<script>alert('发帖成功！')</script>");
            //Response.Redirect("login.aspx");
        }
        else
        {
            Response.Write("<script>alert('发帖失败！')</script>");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}