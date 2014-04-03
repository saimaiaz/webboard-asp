<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>กระทู้ทั้งหมด</h1>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <p><a href="topic.aspx?ID=<%# Eval("ID") %>">#<%# Eval("ID") %> <%# Eval("Text") %></a></p>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>

