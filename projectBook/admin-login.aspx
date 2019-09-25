<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin-login.aspx.cs" Inherits="projectBook.admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>এই.সময়ের - ব্যক্তিগত লাইব্রেরি | LOGIN</title>
</head>
<body>
    <div class="form1">
    <div class="form">
        <form class="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="btnLogin" CssClass="btn btn-sucess" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User or Password!" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        </form>
    </div>
    </div>
    <style>
       
                .form1 {
                  width: 360px;
                  padding: 8% 0 0;
                  margin: auto;
                }
                .form {
                  position: relative;
                  z-index: 1;
                  background: #FFFFFF;
                  max-width: 360px;
                  margin: 0 auto 100px;
                  padding: 45px;
                  text-align: center;
                  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
                }
                .form input {
                  font-family: "Roboto", sans-serif;
                  outline: 0;
                  background: #f2f2f2;
                  width: 100%;
                  border: 0;
                  margin: 0 0 15px;
                  padding: 15px;
                  box-sizing: border-box;
                  font-size: 14px;
                }
               
                
                body {
                  background: #76b852; /* fallback for old browsers */
                  background: -webkit-linear-gradient(right, #76b852, #8DC26F);
                  background: -moz-linear-gradient(right, #76b852, #8DC26F);
                  background: -o-linear-gradient(right, #76b852, #8DC26F);
                  background: linear-gradient(to left, #76b852, #8DC26F);
                  font-family: "Roboto", sans-serif;    
                }
    </style>
</body>
</html>
