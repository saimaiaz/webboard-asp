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
/// Summary description for Comment
/// </summary>
public class Comment
{
    private int _comment_id;

    public int comment_id
    {
        get { return _comment_id; }
        set { _comment_id = value; }
    }

    private int _topic_id;

    public int topic_id
    {
        get { return _topic_id; }
        set { _topic_id = value; }
    }

    private string _comment_text;

    public string comment_text
    {
        get { return _comment_text; }
        set { _comment_text = value; }
    }

    private string _comment_date;

    public string comment_date
    {
        get { return _comment_date; }
        set { _comment_date = value; }
    }

    private int _user_id;

    public int user_id
    {
        get { return _user_id; }
        set { _user_id = value; }
    }

    private string _user_name;

    public string user_name
    {
        get { return _user_name; }
        set { _user_name = value; }
    }
	

	public Comment()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Comment( int tid, string text, string date, int uid)
    {
        this.topic_id = tid;
        this.comment_text = text;
        this.comment_date = date;
        this.user_id = uid;
    }
}
