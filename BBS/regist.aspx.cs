using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class regist : System.Web.UI.Page
{
    protected SqlConnection conn;//建立数据库的连接对象
    protected SqlDataAdapter da;//建立数据库的查询对象
    protected DataSet ds;//建立DataSet数据表对象以实现断开式连接
    protected SqlCommand comm;//建立数据库的操作对象
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //链接数据库验证身份
        string uname = this.txtName.Text.ToString();               //得到登陆帐号
        string pwd = this.txtPsw.Text.ToString();              //得到登陆密码
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        //初始化该对象的连接字串
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "insert into user_table(no,name,psw) values('7890','" + uname + "','" + pwd + "')";
        int update = sqlComGet.ExecuteNonQuery();//执行sql语句并返回受影响的行数
        if (update != 0)
        {
            Response.Write("<script>alert('注册成功！')</script>");
            Response.Redirect("login.aspx");
        }
        else {
            Response.Write("<script>alert('注册失败！')</script>");
        }
        /*
        if (sqlDr.Read())                                  //如果能查到记录则帐号和密码正确，否则错误
        {
            Session["UserID"] = sqlDr["no"];
            Session["UserEmail"] = sqlDr["email"];
            Session["UserName"] = uname;                      //用Session记录帐号

            Session["UserPwd"] = pwd;                //用Session记录密码
            Response.Redirect("home.aspx");
            Response.Write("<script>alert('登陆成功！')</script>");
        }
        else                                              //帐号或密码错误
        {
            Response.Write("<script>alert('您输入的用户名或密码不正确！')</script>");
            //this.lblResults.Text = "您输入的用户名或密码不正确！";
        }
        */
        sqlCon.Close();
    }
}
