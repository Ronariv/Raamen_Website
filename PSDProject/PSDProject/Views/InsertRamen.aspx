<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="PSDProject.Views.InsertRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="BackButton" runat="server" NavigateUrl="~/Views/ManageRamen.aspx">Back to Manage Ramen</asp:HyperLink>
    <p></p>
    <div>
        <p>Name</p>
        <div>
            <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
            <asp:Label ID="NameLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
        </div>
        <p>Meat</p>
        <div>
            <asp:DropDownList ID="MeatList" runat="server">

            </asp:DropDownList>
            <asp:Label ID="MeatLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
        </div>
        <p>Broth</p>
        <div>
            <asp:TextBox ID="BrothBox" runat="server" Text =""></asp:TextBox>
            <asp:Label ID="BrothLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
        </div>
        <p>Price</p>
        <div>
            <asp:TextBox ID="PriceBox" runat="server" ></asp:TextBox>
            <asp:Label ID="PriceLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="InsertBtn" runat="server" Text="Insert Ramen" OnClick="InsertBtn_Click"/>
        </div>
    </div>
</asp:Content>
