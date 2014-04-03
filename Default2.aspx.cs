using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Hashtable s = new Hashtable();
        s.Add(0, "Zero");
        s.Add(1, "One");

        ListBox1.DataSource = s;
        ListBox1.DataValueField = "key";
        ListBox1.DataTextField = "value";
        ListBox1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //StreamWriter st = File.CreateText( Server.MapPath("test.txt"));
        //st.Write("ok");
        //st.Close();
        //Response.Write("ok");

        using (SqlConnection c = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=SSPI"))
        {
            c.Open();
            // 2
            // Create new DataAdapter
            using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Employees", c))
            {
                // 3
                // Use DataAdapter to fill DataTable
                DataTable t = new DataTable();
                a.Fill(t);
                t.TableName = "a";
                t.WriteXml(Server.MapPath("a.xml") );

                // 4
                // Render data onto the screen
                // dataGridView1.DataSource = t; // <-- From your designer
            }
        }

    }
}
