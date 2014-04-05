<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>กระทู้ทั้งหมด</h1>


<ul class="nav nav-list bs-docs-sidenav affix-top">
  
  <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        
        <li><a href="topic.aspx?ID=<%# Eval("ID") %>"><i class="icon-chevron-right"></i> <%# Eval("ID") %> <%# Eval("Text") %></a></li>
    </ItemTemplate>
    </asp:Repeater>
</ul>

</asp:Content>

