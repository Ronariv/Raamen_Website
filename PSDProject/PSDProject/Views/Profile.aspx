<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PSDProject.Views.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid mx-auto col-6 gap-2 mt-3">
        <h2>Profile</h2>
        <p>Username</p>
        <div>
            <asp:TextBox ID="UsernameTxt" runat="server" class="form-control"></asp:TextBox>
            <asp:Label ID="UsernameLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        </div>

        <p>Email</p>
        <div>
            <asp:TextBox ID="EmailTxt" runat="server" class="form-control"></asp:TextBox>
            <asp:Label ID="EmailLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        </div>

        <p>Gender</p>
            <div class="d-grid gap-1">
                <asp:DropDownList ID="GenderLists" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>

                </asp:DropDownList>
            <asp:Label ID="GenderLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
            </div>

        <p>Password</p>
        <div>
            <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
            <asp:Label ID="PasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        </div>
        <asp:Button class="btn btn-success" ID="UpdateButton" runat="server" Text="Update Profile" OnClick="UpdateButton_Click" />
    </div>
    
</asp:Content>
