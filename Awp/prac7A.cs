public partial class Cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Creating HttpCookie instance by name "creator"
        HttpCookie c1 = new HttpCookie("creator");
        // Assigning value to the created cookie
        c1.Value = "Dr. Tushar Sambare";
        // Adding Cookie to the response instance
        Response.Cookies.Add(c1);
        String author = Response.Cookies["creator"].Value;
        Label2.Text = author;

        // Second Cookie
        Response.Cookies["comp"].Expires = DateTime.Now.AddDays(-1);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label3.Text = "";
        // ------------ Adding Cookies -------------------//
        if (apple.Checked)
            Response.Cookies["comp"]["apple"] = "apple";
        if (dell.Checked)
            Response.Cookies["comp"]["dell"] = "dell";
        if (lenovo.Checked)
            Response.Cookies["comp"]["lenovo"] = "lenovo";
        if (acer.Checked)
            Response.Cookies["comp"]["acer"] = "acer";
        if (sony.Checked)
            Response.Cookies["comp"]["sony"] = "sony";
        if (wipro.Checked)
            Response.Cookies["comp"]["wipro"] = "wipro";

        // ------------ Fetching Cookies --------------------//
        if (Request.Cookies["comp"].Values.ToString() != null)
        {
            if (Request.Cookies["comp"]["apple"] != null)
                Label3.Text += Request.Cookies["comp"]["apple"] + " , ";
            if (Request.Cookies["comp"]["dell"] != null)
                Label3.Text += Request.Cookies["comp"]["dell"] + " , ";
            if (Request.Cookies["comp"]["lenovo"] != null)
                Label3.Text += Request.Cookies["comp"]["lenovo"] + " , ";
            if (Request.Cookies["comp"]["acer"] != null)
                Label3.Text += Request.Cookies["comp"]["acer"] + " , ";
            if (Request.Cookies["comp"]["sony"] != null)
                Label3.Text += Request.Cookies["comp"]["sony"] + " , ";
            if (Request.Cookies["comp"]["wipro"] != null)
                Label3.Text += Request.Cookies["comp"]["wipro"] + " , ";
        }
        else
            Label3.Text = "Please select your choice";
        
        Response.Cookies["comp"].Expires = DateTime.Now.AddDays(-1);
    }
}
