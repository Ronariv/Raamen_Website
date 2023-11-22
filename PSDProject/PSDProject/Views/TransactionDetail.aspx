<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="PSDProject.Views.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="BackBtn" runat="server" NavigateUrl="~/Views/History.aspx">Back To History</asp:HyperLink>
    <div>
    <asp:Repeater ID="RepeaterDetail" runat="server">
        <ItemTemplate>
            <asp:LinkButton runat="server" ID="detailBtn">
                <div style="border:solid; border-color:black">
                    <div>
                        <h4><%# Eval("HeaderId") %></h4>
                    </div>
                    <div>
                        <p>Ramen    : <%# Eval("Ramen") %></p>
                        <p>Quantity : <%# Eval("Quantity") %></p>
                    </div>
                </div>
            </asp:LinkButton>
        </ItemTemplate>
    </asp:Repeater>

    </div>
</asp:Content>
