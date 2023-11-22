<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="PSDProject.Views.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Cart</h2>
        <asp:GridView ID="GridViewCart" runat="server">

        </asp:GridView>
        <asp:Button ID="ClearBtn" runat="server" Text="Clear All" OnClick="ClearBtn_Click"/>
        <asp:Button ID="BuyBtn" runat="server" Text="Buy Ramen" OnClick="BuyBtn_Click"/>
    </div>
    <div>
    <asp:Repeater ID="RepeaterRamen" runat="server">
        <ItemTemplate>
            <asp:LinkButton runat="server" ID="detailBtn" OnClick="detailBtn_Click" CommandArgument='<%#Eval("Id") %>'>
                <div style="border:solid; border-color:black">
                    <div>
                        <h4><%# Eval("Name") %></h4>
                    </div>
                    <div>
                        <p>Meat  : <%# Eval("Meat") %></p>
                        <p>Broth : <%# Eval("Broth") %></p>
                        <h4>Price : $<%# Eval("Price") %></h4>
                    </div>
                </div>
            </asp:LinkButton>
        </ItemTemplate>
    </asp:Repeater>

    </div>
    
</asp:Content>
