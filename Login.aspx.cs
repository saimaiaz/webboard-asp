using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Firstname"] != null)
            Response.Redirect("profile.aspx");
    }
    
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        UsersDB u = new UsersDB();
        Users user = u.Login( username.Text , password.Text);

        if (user != null)
        {
            Session["Firstname"]=user.Firstname;
            Session["Picture"] = user.Picture;

            Response.Redirect("~");
        }


    }
}
