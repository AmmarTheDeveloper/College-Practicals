public partial class P3a : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str = "Vedshree Sambare";
            if (ViewState["nam"] == null)
            {
                ViewState["nam"] = str;
            }
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        lblStr.Text = ViewState["nam"].ToString();
    }


    protected void btnSend_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default4.aspx?UserId=" + txtUserId.Text + "&UserName=" + txtUserName.Text);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblUserId.Text = Request.QueryString["UserId"];
            lblUserName.Text = Request.QueryString["UserName"];
        }
    }


}