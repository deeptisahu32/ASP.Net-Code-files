<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="Electricity_Prj.Home" %>

<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome</h2>
    <p>Select an action:</p>
    <asp:Button ID="btnGoAdd" runat="server" Text="Add Bill" CssClass="btn btn-primary" OnClick="btnGoAdd_Click" />
    &nbsp;&nbsp;
    <asp:Button ID="btnGoRetrieve" runat="server" Text="Retrieve Bill" CssClass="btn btn-outline" OnClick="btnGoRetrieve_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server" CssClass="msg-error" />
</asp:Content>

