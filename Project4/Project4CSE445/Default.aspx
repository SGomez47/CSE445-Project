<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project4CSE445.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblNum1" runat="server" Text="Enter the info for a new park"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblNum2" runat="server" Text="Type:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNum3" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNum4" runat="server" Text="Owner:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNum5" runat="server" Text="Address:"></asp:Label>
            <br />
            <asp:TextBox ID="txtOwner" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNum6" runat="server" Text="Url:  "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNum7" runat="server" Text="Neighboring States: (Add commas for multiple; Arizona, California)"></asp:Label>
            <br />
            <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtStates" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNum8" runat="server" Text="Established Date:   "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblNum9" runat="server" Text="Founder(optional):"></asp:Label>
            <br />
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="txtFounder" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Park" />
            <br />
            <asp:Label ID="lblNum10" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter the link and element you are searching"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblEx" runat="server" Text="Example Link: https://www.public.asu.edu/~sgomez47/Parks.xml"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblLink" runat="server" Text="Enter Link:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblElement" runat="server" Text="Enter Element(Ex. Name, Owner, etc.)"></asp:Label>
            <br />
            <asp:TextBox ID="txtBoxXmlInp" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBoxKey" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
            <br />
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
