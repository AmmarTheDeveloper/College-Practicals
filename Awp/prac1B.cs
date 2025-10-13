public partial class pract1b: System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        int numOfRows = Convert.ToInt32(TextBox1.Text);
        int number = 1;
        StringBuilder sb = new StringBuilder();
        
        for (int i = 1; i <= numOfRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                sb.Append(number + " ");
                number++;
            }
            sb.Append("<br />");
        }

        Label1.Text = sb.ToString();
    }
}
