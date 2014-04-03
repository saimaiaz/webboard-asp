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
using System.Web.UI.MobileControls;
using System.Collections.Generic;

/// <summary>
/// Summary description for TopicDB
/// </summary>
public class TopicDB 
{
    private int _id;
    private string _head;
    private string _text;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
	
    public string Head
    {
        get { return _head; }
        set { _head = value; }
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    
    List<TopicDB> list;
    TopicDB topic;

	public TopicDB()
	{
        //base.myConnection;
        list = new List<TopicDB>();
	}

    public List<TopicDB> getAll()
    {
        DB db = new DB();

        SqlCommand myCommand = new SqlCommand("select * from topic", db.myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();

        while (myReader.Read())
        {
            topic = new TopicDB();
            topic.ID = int.Parse(myReader["topic_id"].ToString());
            topic.Head = myReader["topic_head"].ToString();
            topic.Text = myReader["topic_text"].ToString();

            list.Add(topic);
        }
        db.closeDB();
        return list;
    }

    public void addTopic(string head, string text, int user_id)
    {
        DB db = new DB();
        string cmd = string.Format("insert into topic (topic_head, topic_text, topic_create_time, user_id )values( '{0}','{1}',getdate() ,{2}) ",head, text,user_id  );
        SqlCommand myCommand = new SqlCommand(cmd, db.myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();

        db.closeDB();
    }

    public TopicDB showDetail(int id)
    {
        DB db = new DB();

        SqlCommand myCommand = new SqlCommand("select * from topic where topic_id="+id, db.myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();
        
        topic = new TopicDB();
        myReader.Read();
        topic.ID = int.Parse(myReader["topic_id"].ToString());
        topic.Head = myReader["topic_head"].ToString();
        topic.Text = myReader["topic_text"].ToString();
        
        db.closeDB();
        return topic;        
    }


}
