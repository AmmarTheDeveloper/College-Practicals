public partial class _Default : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str = "Vedshree Sambare";
            if (ViewState["name"] == null)
            {
                ViewState["name"] = str;
            }
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
       lblStr.Text = ViewState["name"].ToString( );
    }
    protected void Button1_Click(object sender, EventArgs e)
{
    TextBox1.Text = "";
    for (int i = 0; i < ListBox1.Items.Count; i++)
    {
        if (ListBox1.Items[i].Selected == true)
        {
            TextBox1.Text = TextBox1.Text + " " + ListBox1.Items[i].Text + "\n";
        }
    }
}

protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{
    Label1.Text = DropDownList1.SelectedItem.Text;
}

protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
{
    Label1.Font.Size = int.Parse(DropDownList2.SelectedItem.Text);
}

protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
{
    Label1.BackColor = System.Drawing.Color.Red;
}

protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
{
    Label1.BackColor = System.Drawing.Color.Green;
}

protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
{
    Label1.BackColor = System.Drawing.Color.Blue;
}

protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
{
    Label1.Font.Bold = true;
}

protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
{
    Label1.Font.Italic = true;
}

protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
{
    label1.Font.Underline = true;
}

}
