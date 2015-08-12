<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                User Name
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtUserName" />
                </td>
            </tr>
              <tr>
                <td>
                Password
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                </td>
            </tr>
            <tr>
            <td colspan="2" style="text-align:center;">
                <asp:Button Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
