public partial class Pract2A : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Boxing: Converting a value type to an object type
        int valueType = Convert.ToInt32(TextBox1.Text);
        object boxed = valueType; // The value type valueType is boxed
        Label1.Text = "Boxed value: " + boxed;

        // Unboxing: Converting an object type back to a value type
        int unboxed = (int)boxed; // The object boxed is unboxed
        Label2.Text = "Unboxed value: " + unboxed;
    }
}
