<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment15.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h2>LOGIN</h2>
    <table>
        <tr>
            <td style="width: 302px">
                <asp:Label ID="label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 26px; width: 302px">
                <asp:TextBox ID="userName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 302px">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 56px; width: 302px">
               <input id="Password1" type="password" />
            </td>
        </tr>
        <tr>
            <td>
               <asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
