public delegate int MathOperation(int a, int b);

public partial class Prac2b : System.Web.UI.Page
{
    int Add(int a, int b)
    {
        return a + b;
    }
    int Subtract(int a, int b)
    {
        return a - b;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(TextBox1.Text);
        int y = Convert.ToInt32(TextBox2.Text);
        MathOperation add = new MathOperation(Add);
        MathOperation sub = new MathOperation(Subtract);
        Label1.Text = add(x, y).ToString();
        Label2.Text = sub(x, y).ToString();
    }
}
