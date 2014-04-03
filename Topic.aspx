<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Topic.aspx.cs" Inherits="topic" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<p><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
<p><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
<p><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>&nbsp;</p>


<hr>
    
    <h4>คอมเม้น</h4>
    <div style="border: 1px solid #ddd;">
        <asp:Repeater ID="RepeaterComment" runat="server">
            <ItemTemplate>
                <div>
                    <p><%# Eval("comment_text") %></p>

                    <p>โดย <%# Eval("user_name") %> | เมื่อเวลา <%# Eval("comment_date") %></p>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div style="background: #eee;">
                    <p><%# Eval("comment_text") %></p>
                    
                    <p>โดย <%# Eval("user_name") %> | เมื่อเวลา <%# Eval("comment_date") %></p>
                </div>
            </AlternatingItemTemplate>
        </asp:Repeater>
    </div>
   

    <p>
        <asp:TextBox ID="comment_text" runat="server" Height="106px" Width="307px" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" CssClass="k-button" runat="server" Text="ตอบกระทู้" OnClick="Button1_Click" />&nbsp;</p>




</asp:Content>

