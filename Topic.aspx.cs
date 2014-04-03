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

public partial class topic : System.Web.UI.Page
{

    CommentDB comment;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int topic_id = int.Parse(Request.QueryString["ID"]);

            TopicDB topic = new TopicDB();
            TopicDB topicdetail = topic.showDetail(topic_id);

            Label1.Text = topicdetail.ID.ToString();
            Label2.Text = topicdetail.Head.ToString();
            Label3.Text = topicdetail.Text.ToString();

            //this.bindComment(topic_id);

            // for add a comment 
            comment = new CommentDB();
            RepeaterComment.DataSource = comment.getAllByTopicID( topic_id );
            RepeaterComment.DataBind();
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int topic_id = int.Parse(Request.QueryString["ID"]);
        CommentDB c = new CommentDB();
        c.addComment(topic_id, comment_text.Text, DateTime.Now.ToShortDateString(), 2);
        comment_text.Text = "";
        this.bindComment(topic_id);
    }

    private void bindComment(int id)
    {
        // for add a comment 
        comment = new CommentDB();
        RepeaterComment.DataSource = comment.getAllByTopicID(id);
        RepeaterComment.DataBind();
        
    }
}
