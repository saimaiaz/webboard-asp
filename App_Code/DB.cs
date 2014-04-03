using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Diagnostics;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{



    private SqlConnection _myConnection;

    public SqlConnection myConnection
    {
        get { return _myConnection; }
        set { _myConnection = value; }
    }
	

    public SqlConnection getConnection()
    {
        return myConnection;
    }

	public DB()
	{
        myConnection = new SqlConnection("user id=sa;" +
                                       "password=1234;server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=wb; " +
                                       "connection timeout=30");

        try
        {
            myConnection.Open();
        }
        catch (Exception e1)
        {
            //Console.WriteLine(e.ToString());
            Debug.WriteLine(e1.ToString());
        }
	}

    public void closeDB()
    {
        myConnection.Close();
      
    }
}
