<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <br />
    <br />
    <table style="width: 437px">
        <tr>
            <td style="width: 70px; height: 43px">

User
            </td>
            <td style="height: 43px">
<asp:TextBox ID="username" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 70px; height: 39px">
Pass
            </td>
            <td style="height: 39px">
<asp:TextBox ID="password" TextMode="password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 70px">
            </td>
            <td>
<asp:Button ID="BtnLogin" runat="server" CssClass="btn btn-default" OnClick="BtnLogin_Click" Text="Login now" /></td>
        </tr>
    </table>




    

</asp:Content>

