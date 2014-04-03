<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
        <tr>
            <td colspan="2" style="text-align: center">
            ลงทะเบียน
            </td>
        </tr>
        <tr>
            <td style="width: 208px; text-align: right">
            ชื่อเข้าใช้
            </td>
            <td>
                <asp:TextBox ID="username" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="username" runat="server" ErrorMessage="โปรดใส่ Username"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            รหัสผ่าน
            </td>
            <td>
                <asp:TextBox ID="password" CssClass="k-textbox" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="password" runat="server" ErrorMessage="โปรดใส่รหัสผ่าน"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            รหัสผ่านยืนยัน
            </td>
            <td>
                <asp:TextBox ID="repassword" CssClass="k-textbox" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="repassword" runat="server" ErrorMessage="โปรดใส่รหัสผ่านยืนยัน"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" ControlToCompare="password" ControlToValidate="repassword" runat="server" ErrorMessage="รหัสผ่านยืนยัน ไม่ถูกต้อง"></asp:CompareValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            อีเมล
            </td>
            <td>
                <asp:TextBox ID="email" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="email" runat="server" ErrorMessage="โปรดใส่ อีเมล"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            ชื่อเต็ม
            </td>
            <td>
                <asp:TextBox ID="firstname" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="firstname" runat="server" ErrorMessage="โปรดใส่ชื่อเต็ม"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            รูป
            </td>
            <td>
                <asp:FileUpload ID="picture" CssClass="k-textbox" runat="server" />
            </td>
        </tr>
        
        <tr>
            <td colspan="2" style="text-align: center; height: 100px;">
                <asp:Button ID="Button1" CssClass="k-button" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>

    </table>

</asp:Content>

