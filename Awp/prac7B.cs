using System;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected bool authenticate(String uname, String pass)
    {
        if (uname == "Yash")
        {
            if (pass == "yash123")
                return true;
        }
        if (uname == "Ved")
        {
            if (pass == "ved123")
                return true;
        }
        if (uname == "Sam")
        {
            if (pass == "sam123")
                return true;
        }
        return false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (authenticate(txtuser.Text, txtpwd.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtuser.Text, chkrem.Checked);
            Session["Username"] = txtuser.Text;
            Response.Redirect("Default2.aspx");
        }
        else
        {
            Response.Write("Invalid user name or password");
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null)
        {
            // Response.Write(Session["Username"].ToString());
            Label1.Text = Session["Username"].ToString();
        }
    }
}