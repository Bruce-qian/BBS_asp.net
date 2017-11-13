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

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //跳转到帖子的内容页
        // txtid.Text = GridView1.Rows(GridView1.SelectedIndex).Cells(1).Text '获取第二列
        TextBox1.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text;
    }
}