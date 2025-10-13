public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        LabelResult.Text = "You selected: " + Calendar1.SelectedDate.ToShortDateString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string vacationDate = Calendar1.SelectedDate.ToShortDateString();
        string vacationDetails = TextBoxDetails.Text;

        if (string.IsNullOrEmpty(vacationDetails))
        {
            LabelResult.Text = "Please enter vacation details.";
        }
        else
        {
            LabelResult.Text = $"Vacation on {vacationDate}: {vacationDetails}";
        }
    }
}
