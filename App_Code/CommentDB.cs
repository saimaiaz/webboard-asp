using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.UI.MobileControls;
using System.Collections.Generic;
using System.Data.SqlClient;


/// <summary>
/// Summary description for CommentDB
/// </summary>
public class CommentDB
{
    List<Comment> list;
    Comment comment;

	public CommentDB()
	{
        list = new List<Comment>();
	}

    public List<Comment> getAllByTopicID(int id)
    {
        DB db = new DB();
        db.getConnection();

        SqlCommand myCommand = 
            new SqlCommand(@"select * from comment inner join 
            users on comment.user_id=users.user_id 
            where comment.topic_id="+id, db.myConnection);
        

        SqlDataReader myReader = myCommand.ExecuteReader();

        while (myReader.Read())
        {
            comment = new Comment();
            comment.comment_id = int.Parse(myReader["comment_id"].ToString());
            comment.topic_id = int.Parse(myReader["topic_id"].ToString());
            comment.comment_text = myReader["comment_text"].ToString();
            comment.comment_date = myReader["comment_date"].ToString();
            comment.user_id = int.Parse(myReader["user_id"].ToString());
            comment.user_name = myReader["user_name"].ToString();

            list.Add(comment);
        }
        db.closeDB();
        return list;
    }

    public void addComment( int tid, string text, string date, int uid)
    {
        DB db = new DB();
        //comment = new Comment(tid, text, date, uid);

        string cmd = string.Format(@"insert into comment 
(topic_id, comment_text, comment_date, user_id )
values( '{0}','{1}','{2}' ,{3}) "
            , tid, text, date, uid);
        
        SqlCommand myCommand = new SqlCommand(cmd, db.myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();

        db.closeDB();
    }

}
