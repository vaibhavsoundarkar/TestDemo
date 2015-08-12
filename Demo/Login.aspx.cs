using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "admin" && txtPassword.Text == "123")
        {
            Session["UserName"] = "Admin";
            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, txtUserName.Text, DateTime.Now, DateTime.Now.AddMinutes(120), false, @"\");
            string strRedirectionUrl = "~/Admin/Default.aspx";
            FormsAuthentication.RedirectFromLoginPage("Admin", false);
            Response.Redirect(strRedirectionUrl);
        }

    }
}