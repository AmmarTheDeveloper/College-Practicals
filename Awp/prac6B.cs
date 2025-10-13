protected void Button1_Click(object sender, EventArgs e)
{
    string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
    SqlConnection con = new SqlConnection(connStr);
    SqlDataAdapter objDa = new SqlDataAdapter();
    DataSet objDs = new DataSet();
    using (SqlConnection objConn = new SqlConnection(connStr))
    {
        SqlCommand objCmd = new SqlCommand("Select * from Customer", objConn);
        objCmd.CommandType = CommandType.Text;
        objDa.SelectCommand = objCmd;
        objDa.Fill(objDs, "Product");
        GridView1.DataSource = objDs.Tables[0];
        GridView1.DataBind();
    }
}
