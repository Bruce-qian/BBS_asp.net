using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class head : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ///判断有没有登陆，如果没有则显示默认信息，如果已经登陆从session中读取用户的个人信息
    }
}