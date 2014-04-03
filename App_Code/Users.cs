using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{

    private int _id;
    private string _name;
    private string _pass;
    private string _email;
    private string _firstname;
    private string _picture;

    public Users() { }

    public Users(int id, string name, string pass, string email, string firstname, string picture)
    {
        this.ID = id;
        this.Name = name;
        this.Pass = pass;
        this.Email = email;
        this.Firstname = firstname;
        this.Picture = picture;
    }

    public string Picture
    {
        get { return _picture; }
        set { _picture = value; }
    }
	

    public string Firstname
    {
        get { return _firstname; }
        set { _firstname = value; }
    }
	

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
	

    public string Pass
    {
        get { return _pass; }
        set { _pass = value; }
    }
	

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
	


    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
	
}
