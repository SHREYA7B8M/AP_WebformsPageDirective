using System;
using System.Data;

namespace PageDirective
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Class", typeof(string));

                table.Rows.Add("Walter", "6B");
                table.Rows.Add("Edith", "6B");
                table.Rows.Add("William", "6B");
                table.Rows.Add("June", "6B");

                foreach (DataRow dr in table.Rows)
                {
                    Response.Write(dr["Name"] + " is in class " + dr["Class"] + "<br>");
                }
            }
        }
    }
}
