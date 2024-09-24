<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Insert" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crud Operation</title>
   <link href="css/custom.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="my-form-header">
            <div class="my-form-header">
                <label class="custom_sno" for="TxtSno">Sno:</label>
                <asp:TextBox ID="TxtSno" runat="server" CssClass="custom_sno" />
            </div>

            <div class="my-form-header">
                <label class="Name" for="TxtName">Name:</label>
                <asp:TextBox runat="server" ID="TxtName" CssClass="Name"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="reqname" ControlToValidate="TxtName" ErrorMessage="Name is required" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="my-form-header">
                <label class="Email" for="TxtEmail">Email:</label>
                <asp:TextBox runat="server" ID="TxtEmail" CssClass="Email"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TxtEmail" ErrorMessage="Email is required" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="my-form-header">
                <label class="Mobile" for="TxtMobile">Mobile:</label>
                <asp:TextBox runat="server" ID="TxtMobile" CssClass="Mobile"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="TxtMobile" ErrorMessage="Mobile is required" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="my-form-header">
                <label for="ddlstate">State:</label>
                <asp:DropDownList runat="server" ID="ddlstate" CssClass="ddlstate">
                    <asp:ListItem Value="Select" Text="Select"></asp:ListItem>
                    <asp:ListItem Value="TamilNadu" Text="TamilNadu"></asp:ListItem>
                    <asp:ListItem Value="Kerela" Text="Kerela"></asp:ListItem>
                    <asp:ListItem Value="Maharastra" Text="Maharastra"></asp:ListItem>
                    <asp:ListItem Value="Bihar" Text="Bihar"></asp:ListItem>
                    <asp:ListItem Value="UttarPradesh" Text="UttarPradesh"></asp:ListItem>
                    <asp:ListItem Value="Delhi" Text="Delhi"></asp:ListItem>
                    <asp:ListItem Value="Jharkhand" Text="Jharkhand"></asp:ListItem>
                    <asp:ListItem Value="UK" Text="UK"></asp:ListItem>
                    <asp:ListItem Value="Punjab" Text="Punjab"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="ddlstate" ErrorMessage="State is mandatory" Display="Dynamic" SetFocusOnError="true" InitialValue="Select"></asp:RequiredFieldValidator>
            </div>

            <div class="btn-my-btn">
                <asp:Button runat="server" ID="BtnSubmit" Text="Insert Data" CssClass="btn btn-primary" OnClick="BtnSubmit_Click" />
                <asp:Button runat="server" ID="Btnupdate" Text="Update" CssClass="btn btn-success" OnClick="Btnupdate_Click" />
                <asp:Button runat="server" ID="Btndelete" Text="Delete" CssClass="btn btn-danger" OnClick="Btndelete_Click" />
            </div>
        </div>
    </form>
</body>
</html>
