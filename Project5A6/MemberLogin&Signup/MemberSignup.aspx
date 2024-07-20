<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberSignup.aspx.cs" Inherits="MemberLoginPages.MemberSignup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSignup" runat="server" Text="Create an account"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Back to Login" />
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Enter Username"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Enter Password"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password"></asp:Label>
            <br />
            <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
             <div class="g-recaptcha" data-sitekey="6LfydQwpAAAAADRITy3YbxiKG3x4xKkMW6JA7iUY"></div>
            <br />
            <br />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Signup" />
            <br />
            <br />
            <asp:Label ID="lblTrue" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
