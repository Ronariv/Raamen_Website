<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="PSDProject.Views.TransactionQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewUnhandled" runat="server" OnRowEditing="GridViewUnhandled_RowEditing">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Handle" ShowHeader="True" Text="Handle" />
        </Columns>

    </asp:GridView>
    <asp:Button ID="HandleBtn" runat="server" Text="Handle All Transaction" OnClick="HandleBtn_Click"/>
</asp:Content>
