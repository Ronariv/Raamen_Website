<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSDProject.Views.Login" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-grid mx-auto col-6 gap-2 mt-3">
        <h2>Login</h2>
        <div class="">

            <div>
                <p>Email</p>
                <div>
                <asp:TextBox ID="EmailTxt" runat="server" class="form-control"></asp:TextBox>
                </div>
                <p>Password</p>
                <div>
                <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                <p>
                    <asp:CheckBox class="" ID="RememberCheckBox" runat="server"/>
                    <asp:Label ID="RememberLabel" runat="server" Text="Remember Me" AssociatedControlID="RememberCheckBox"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </p>
                <div class="d-grid gap-2 col-6 mx-auto">
                    <asp:Button class="btn btn-success" ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
                    <asp:HyperLink class="btn btn-outline-success" ID="RegisterLink" runat="server" NavigateUrl="~/Views/Register.aspx">
                        <%--<input class="btn btn-outline-success" type="button"value="Register"/>--%>
                        Register
                    </asp:HyperLink>
                </div>
            </div>
            </div>

        </div>

    </div>
</asp:Content>