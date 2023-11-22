<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSDProject.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hello,</h1>
    <asp:Label ID="CurrentUser" runat="server" Text="Guest" Font-Size="X-Large" Font-Bold ="true"></asp:Label>
    <p></p>
    <b>Current Role</b>
    <asp:Label ID="CurrentRole" runat="server" Text="Guest" Font-Size="Large"></asp:Label>

    <p></p>
    <div>
        <asp:Label ID="UserTable" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:GridView ID="GridViewHome" runat="server" Width="535px">
        </asp:GridView>
    </div>

</asp:Content>
