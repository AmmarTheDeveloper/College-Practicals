public partial class Pract1C : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b, c, i, n;
        a = 0;
        b = 1;
        Label1.Text = a.ToString() + b.ToString();
        n = Convert.ToInt32(TextBox1.Text);
        for (i = 1; i <= n; ++i)
        {
            c = a + b;
            Label1.Text = Label1.Text + c.ToString();
            a = b;
            b = c;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int n, i, s = 0;
        n = Convert.ToInt32(TextBox1.Text);
        if (n == 0 || n == 1)
            s = 1;
        for (i = 2; i <= n / 2; ++i)
        {
            if (n % i == 0)
            {
                s = 1;
                break;
            }
        }
        if (s == 0)
            Label2.Text = "The given number is prime";
        else
            Label2.Text = "The given number is not prime";
    }
}