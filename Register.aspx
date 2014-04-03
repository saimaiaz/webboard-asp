<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
        <tr>
            <td colspan="2" style="text-align: center">
            ŧ����¹
            </td>
        </tr>
        <tr>
            <td style="width: 208px; text-align: right">
            ���������
            </td>
            <td>
                <asp:TextBox ID="username" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="username" runat="server" ErrorMessage="�ô��� Username"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            ���ʼ�ҹ
            </td>
            <td>
                <asp:TextBox ID="password" CssClass="k-textbox" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="password" runat="server" ErrorMessage="�ô������ʼ�ҹ"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            ���ʼ�ҹ�׹�ѹ
            </td>
            <td>
                <asp:TextBox ID="repassword" CssClass="k-textbox" TextMode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="repassword" runat="server" ErrorMessage="�ô������ʼ�ҹ�׹�ѹ"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" ControlToCompare="password" ControlToValidate="repassword" runat="server" ErrorMessage="���ʼ�ҹ�׹�ѹ ���١��ͧ"></asp:CompareValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            �����
            </td>
            <td>
                <asp:TextBox ID="email" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="email" runat="server" ErrorMessage="�ô��� �����"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            �������
            </td>
            <td>
                <asp:TextBox ID="firstname" CssClass="k-textbox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="firstname" runat="server" ErrorMessage="�ô���������"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td style="width: 208px; text-align: right">
            �ٻ
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

