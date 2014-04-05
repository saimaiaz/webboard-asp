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
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Summary description for UsersDB
/// </summary>
public class UsersDB
{
    List<Users> list;
    Users users;

	public UsersDB()
	{
        list = new List<Users>();
	}

    public bool Register(string name, string pass, string email, string firstname, string picture)
    {

        if (this.checkUserExist(name, pass)!=0)
        {
            return false;
        }

        DB db = new DB();

        string cmd = string.Format(@"
        INSERT INTO [wb].[dbo].[users]
           ([user_name]
           ,[user_pass]
           ,[user_email]
           ,[user_firstname]
           ,[user_picture])
         VALUES
               ('{0}'
               ,'{1}'
               ,'{2}'
               ,'{3}'
               ,'{4}')
        "
            , name, pass, email, firstname, picture);

        SqlCommand myCommand = new SqlCommand(cmd, db.myConnection);
        int result = myCommand.ExecuteNonQuery();

        if (result == 0)
        {
            return false;
        }
        else
        {
            return true;
        }


        db.closeDB();
    }

    public int checkUserExist(string name, string pass)
    {
        DB db = new DB();

        string cmd = string.Format(@"
        select count([user_name]) 
        from users where [users].[user_name]='{0}' 
        and [users].[user_pass]='{1}'
        ", name, pass);

        SqlCommand myCommand = new SqlCommand(cmd, db.myConnection);
        int RowCount = Convert.ToInt32(myCommand.ExecuteScalar());        

        db.closeDB();
        return RowCount;
    }

    public Users Login(string name, string pass)
    {
        if (this.checkUserExist(name, pass) > 0)
        {
            string cmd = string.Format(@"
            select *
            from users where [users].[user_name]='{0}' 
            and [users].[user_pass]='{1}' "
            , name, pass);

            DB db = new DB();
            SqlCommand myCommand = new SqlCommand(cmd, db.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();

            users = new Users();
            reader.Read();
            users.ID = Int32.Parse(reader["user_id"].ToString());
            users.Name = reader["user_name"].ToString();
            users.Firstname = reader["user_firstname"].ToString();
            users.Picture = reader["user_picture"].ToString();

            db.closeDB();
        }
        else return null;
            
        return users;
    }

    public Users getUsers()
    {
        return new Users();
    }


}
