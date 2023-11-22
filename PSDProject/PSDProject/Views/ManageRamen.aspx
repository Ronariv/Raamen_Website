<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="PSDProject.Views.ManageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p></p>
    <asp:HyperLink ID="InsertRamenBtn" runat="server" NavigateUrl="~/Views/InsertRamen.aspx" >Insert Ramen</asp:HyperLink>

    <asp:GridView ID="GridViewRamen" runat="server" OnRowDeleting="GridViewRamen_RowDeleting" OnRowEditing="GridViewRamen_RowEditing">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>

    </asp:GridView>
</asp:Content>
