using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class essay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //txtConment.Text = "";
        ///数据已经成功传送过来，下面是取数据的方法，下一步将利用传过来的数据查询出帖子的内容，同时将评论绑定到grideview上
        labTitle.Text = (string)Application["post_title"];
        //TextBox2.Text = (string)ViewState["essayId"];
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        SqlDataReader sqlDr = null;
        SqlCommand sqlComGet = null;

        string str = "select Post_content from Send_Post_Count_Table where bbs_id = '" + (string)Application["post_id"] + "'";
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        try
        {
            sqlCon.Open();                               //打开数据库连接
            sqlComGet = new SqlCommand();     //创建SqlCommand对象
            sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
            sqlComGet.CommandText = str;
            sqlDr = sqlComGet.ExecuteReader();
        }
        catch (Exception ex)
        {
            //Response.Write("<script>alert('登陆成功！')</script>");
        }

        while (sqlDr.Read())
        {
            //str += sqlDr[0].ToString() + sqlDr[1].ToString() + "  ";
            labContent.Text = sqlDr[0].ToString();
        }
        sqlDr.Close();
        string str1 = "select comment_content from Comment_Count_Table where post_id = '" + (string)Application["post_id"] + "'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand sqlComGet1 = new SqlCommand();
        SqlConnection sqlCon1 = new SqlConnection();
        sqlComGet1.Connection = sqlCon;
        sqlComGet1.CommandText = str1;
        adapter.SelectCommand = sqlComGet1;
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        sqlCon.Close();
        //未报错，但由于Comment_Count_Table缺少数据没法测试，下一步要把评论写进去
        this.GridView1.DataSource = ds.Tables[0].DefaultView;
        this.GridView1.DataBind();

        
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //评论写入功能实现，没有错误，但是要注意，如果写入的userID在注册表中没有就会报错，或无法写入评论
        int update = 0;
        if (txtConment.Text == "")
        {
            Response.Write("<script>alert('评论不能为空')</script>");
        }
        else {
            //将评论写进数据库中
            SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
            SqlDataReader sqlDr = null;
            SqlCommand sqlComGet = null;
            
            Session["UserID"] = 2;//用于测试的临时数据，用过之后需要注释
            string str = "insert into Comment_Count_Table(user_id, post_id, comment_time, comment_content) values(" + Session["UserID"].ToString() + "," + (string)Application["post_id"] + ",'" + DateTime.Now.ToString() + "','" + txtConment.Text + "')";
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
            try
            {
                sqlCon.Open();                               //打开数据库连接
                sqlComGet = new SqlCommand();     //创建SqlCommand对象
                sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
                sqlComGet.CommandText = str;
                update = sqlComGet.ExecuteNonQuery();//执行sql语句并返回受影响的行数
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.ToString() + "')</script>");
            }
            finally {
                sqlCon.Close();
                if (update != 0)
                {
                    Response.Write("<script>alert('评论成功！')</script>");
                    //Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('评论失败！')</script>");
                }
            }
        }
    }
}