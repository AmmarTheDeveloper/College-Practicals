public partial class _Default : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        int addition, subtraction, multiplication, division;
        addition = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
        subtraction = Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text);
        multiplication = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text);
        division = Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text);

        Label1.Text = "Addition of the number is: " + addition;
        Label2.Text = "Subtraction of the number is: " + subtraction;
        Label3.Text = "Multiplication of the number is: " + multiplication;
        Label4.Text = "Division of the number is: " + division;
    }
}
