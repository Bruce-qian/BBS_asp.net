using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Moderator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["UserID"] = "橙子";
        txtUser.Text = (string)Session["UserID"];
        txtModerate.Text = (string)Application["forumId"];
        //txtPassword.Text = "输入密码确认";
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        ///数据库中少了一个版主申请表，功能：储存版主申请，由管理员审核后从中移除
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "select * from User_Register_Table where user_name='" + txtUser.Text + "' and password='" + txtPassword.Text + "'";//初始化该对象的连接字串
        SqlDataReader sqlDr = sqlComGet.ExecuteReader();
        //int i = sqlComGet.ExecuteNonQuery();   //执行sql语句
        if (sqlDr.Read())
        {
            sqlDr.Close();
            int i = 0;
            if (txtModerate.Text == "C++")
            {
                i = 1;
            }
            else if (txtModerate.Text == "JAVA")
            {
                i = 2;
            }
            else if (txtModerate.Text == "C#") {
                i = 3;
            }
            sqlComGet.CommandText = "insert into temp2(username, bbs_id) values('" + txtUser.Text + "'," + i.ToString() + ")";//插入到申请表
            int p = sqlComGet.ExecuteNonQuery();   //执行sql语句
            if (1 == p)
            {
                Response.Write("<script>alert('申请成功，等待管理员审核')</script>");
            }
            else
            {
                Response.Write("<script>alert('申请失败')</script>");
            }
        }
        else {
            Response.Write("<script>alert('用户验证失败，请检查用户名和密码')</script>");
            Response.Write("<script>alert('" + txtPassword.Text.ToString() + "')</script>");
        }
    }

    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {
       
    }
}