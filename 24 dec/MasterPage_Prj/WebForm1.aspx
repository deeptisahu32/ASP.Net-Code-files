<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPage_Prj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:TextBox ID="txtdata" runat="server" Text="UserName"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnclick" runat="server" Text="Click" />
</asp:Content>
