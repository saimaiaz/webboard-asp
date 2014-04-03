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

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "หน้าลงทะเบียน";        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UsersDB u = new UsersDB();
        bool registerResult = u.Register(username.Text, password.Text, email.Text, firstname.Text, picture.FileName.ToString());
        bool uploadResult = this.uploadPicture(picture);

        if (registerResult && uploadResult)
        {
            Response.Write("<script>alert('ลงทะเบียนสำเร็จ');</script>");
            Response.Redirect("~/Default.aspx");
        }

    }

    public bool uploadPicture(FileUpload FileUploadControl)
    {

        if (FileUploadControl.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(FileUploadControl.FileName);
                FileUploadControl.SaveAs(Server.MapPath(@"Uploads\" + filename));
                //StatusLabel.Text = "Upload status: File uploaded!";
            }
            catch (Exception ex)
            {
                //StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                return false;
            }
            return true;
        }
        return false;
    }
}
