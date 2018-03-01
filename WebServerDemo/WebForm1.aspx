<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServerDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>
                <b>First Integer</b>
            </td>
            <td>
                <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Second Integer</b>
            </td>
            <td>
                <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Result</b>
            </td>
            <td>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAdd" runat="server" Text="Add" /> 
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
