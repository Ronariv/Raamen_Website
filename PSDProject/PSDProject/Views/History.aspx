<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="PSDProject.Views.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewHistory" runat="server" OnRowEditing="GridViewHistory_RowEditing">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Detail" ShowHeader="True" Text="Detail" />
        </Columns>

    </asp:GridView>
</asp:Content>
