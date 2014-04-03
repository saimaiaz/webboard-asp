<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Table ID="Table1" runat="server">
        <asp:TableRow runat="server">
            <asp:TableCell ColumnSpan="3" runat="server">
                เข้าสู่ระบบ
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">User</asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="username" runat="server"></asp:TextBox></asp:TableCell>

        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Pass </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="password" TextMode="password" runat="server"></asp:TextBox></asp:TableCell>

        </asp:TableRow>
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell ID="TableCell1" ColumnSpan="3" runat="server">
                <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="Button" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    

</asp:Content>

