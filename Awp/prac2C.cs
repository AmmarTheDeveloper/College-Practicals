interface Area
{
    double show(double s, double t);
}

class Rect : Area
{
    public double show(double s, double t)
    {
        return s * t;
    }
}

class Circle : Area
{
    public double show(double s, double t)
    {
        return (3.14 * s * s);
    }
}

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Rect r1 = new Rect();
        double x = r1.show(3, 4);
        Circle c1 = new Circle();
        double y = c1.show(3, 4);
        Label1.Text = x.ToString();
        Label2.Text = y.ToString();
    }
}
