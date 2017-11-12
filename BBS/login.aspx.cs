using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected SqlConnection conn;//建立数据库的连接对象
    protected SqlDataAdapter da;//建立数据库的查询对象
    protected DataSet ds;//建立DataSet数据表对象以实现断开式连接
    protected SqlCommand comm;//建立数据库的操作对象
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
       conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());//取连接字符串, 同时建立连接
       da = new SqlDataAdapter();//初始化查询对象

       da.SelectCommand = new SqlCommand("select name,id from xs Order by id,name DESC", conn); //进行一个查询id和姓名的数据库操作
         ds = new DataSet(); //初始化DataSet对象
       try
       {
           conn.Open();//打开连接
           da.Fill(ds, "abs");//获取数据，同时存放在一个名为"abs"的表中
           conn.Close();//关闭连接
       }
       catch (SqlException e1)//错误处理
       {
           Response.Write(e1.ToString());
       }
       */
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnLog_Click(object sender, EventArgs e)
    {
        //链接数据库验证身份
        string uname = this.txtName.Text.ToString();               //得到登陆帐号
        string pwd = this.txtPassword.Text.ToString();              //得到登陆密码
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        //初始化该对象的连接字串
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "select * from user_table where name='" + uname + "' and psw='" + pwd + "'";
        SqlDataReader sqlDr = sqlComGet.ExecuteReader();   //创建SqlDataReader对象,执行sql语句
        if (sqlDr.Read())                                  //如果能查到记录则帐号和密码正确，否则错误
        {
            Session["UserID"] = sqlDr["no"];
            Session["UserEmail"] = sqlDr["email"];
            Session["UserName"] = uname;                      //用Session记录帐号

            Session["UserPwd"] = pwd;                //用Session记录密码
            Response.Redirect("home.aspx");//跳转到主页
            Response.Write("<script>alert('登陆成功！')</script>");
        }
        else                                              //帐号或密码错误
        {
            Response.Write("<script>alert('您输入的用户名或密码不正确！')</script>");
            //this.lblResults.Text = "您输入的用户名或密码不正确！";
        }
        sqlCon.Close();
    }

    protected void btnRegist_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
}