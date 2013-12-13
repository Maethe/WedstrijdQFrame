<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SamenSterker.Views.Login" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <link href="../../Resources/CSS/bootstrap.css" rel="stylesheet" type="text/css" />
        <title>Login Page</title>
    </head>
    <body>
        <div id="formDiv">
        <form id="form1" runat="server">
            <asp:Label ID="emailLabel" runat="server" Text="E-mail: "></asp:Label>
            <br />
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="pwdLabel" runat="server" Text="Wachtwoord"></asp:Label>
            <br />
            <asp:TextBox ID="wachtwoordTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Meld u aan" />
        </form>
        </div>
        <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
        <script src="https://code.jquery.com/jquery.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
        <script src="../../Resources/JS/bootstrap.min.js"></script>
    </body>
</html>