<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSDProject.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid mx-auto col-6 gap-2 mt-3">
        <h2>Register</h2>
              <div class="d-grid gap-2">
                <p>Username</p>
                <div class="d-grid gap-1">
                    
                    <asp:TextBox ID="UsernameTxt" runat="server" ></asp:TextBox>
                    <asp:Label ID="UsernameLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Email</p>
                <div class="d-grid gap-1">
                    <asp:TextBox ID="EmailTxt" runat="server" ></asp:TextBox>
                    <asp:Label ID="EmailLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Gender</p>
                 <div class="d-grid gap-1">
                     <asp:DropDownList class="dropdown" ID="GenderLists" runat="server">
                         <asp:ListItem class="dropdown-item">Male</asp:ListItem>
                         <asp:ListItem class="dropdown-item">Female</asp:ListItem>

                     </asp:DropDownList>
                    <asp:Label ID="GenderLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Password</p>
                <div class="d-grid gap-1">
                    <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="PasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Confirm Password</p>
                <div class="d-grid gap-1">
                    <asp:TextBox ID="ConfirmPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <div class="d-grid gap-2 col-6 mx-auto">
                    <asp:Button class="btn btn-success" ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
                    <asp:HyperLink class="btn btn-outline-success" ID="HyperLink1" runat="server" NavigateUrl="~/Views/Login.aspx">Login</asp:HyperLink>
                </div>
                    
                    
            </div>
          </div>
</asp:Content>
