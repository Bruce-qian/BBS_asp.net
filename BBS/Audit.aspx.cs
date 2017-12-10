using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Audit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ///测试未通过，暂时不管
        //GridViewAudit.SelectedIndex = -1;
       // DropDownList1.SelectedIndex = 0;
        string str = "select * from temp2 where bbs_title = '" + DropDownList1.SelectedValue.ToString() + "'";
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand sqlComGet1 = new SqlCommand();
        SqlConnection sqlCon1 = new SqlConnection();
        sqlComGet1.Connection = sqlCon;
        sqlComGet1.CommandText = str;
        adapter.SelectCommand = sqlComGet1;
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        sqlCon.Close();
        this.GridViewAudit.DataSource = ds.Tables[0].DefaultView;
        this.GridViewAudit.DataBind();
    }

    protected void GridViewAudit_SelectedIndexChanged(object sender, EventArgs e)
    {
        //设置版主功能
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
        sqlComGet.Connection = sqlCon;               //用sqlCon初始化SqlCommand对象
        sqlComGet.CommandText = "insert into  BBS_Column_Table(bbs_moderator) values('" + GridViewAudit.SelectedRow.Cells[0]+ "') where bbs_title = '" + DropDownList1.SelectedValue.ToString() + "'";//初始化该对象的连接字串
        int i = sqlComGet.ExecuteNonQuery();   //执行sql语句
        if (1 == i)
        {
            Response.Write("<script>alert('设置成功')</script>");
        }
        else {
            Response.Write("<script>alert('设置失败')</script>");
        }
        sqlCon.Close();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = "select * from temp where bbs_title = '" + DropDownList1.SelectedValue.ToString() + "'";
        SqlConnection sqlCon = new SqlConnection();   //创建数据库连接对象
        sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        sqlCon.Open();                               //打开数据库连接
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand sqlComGet1 = new SqlCommand();
        SqlConnection sqlCon1 = new SqlConnection();
        sqlComGet1.Connection = sqlCon;
        sqlComGet1.CommandText = str;
        adapter.SelectCommand = sqlComGet1;
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        sqlCon.Close();
        this.GridViewAudit.DataSource = ds.Tables[0].DefaultView;
        this.GridViewAudit.DataBind();
    }
}