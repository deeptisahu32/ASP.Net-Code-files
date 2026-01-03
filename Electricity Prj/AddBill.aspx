
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.master"
    CodeBehind="AddBill.aspx.cs" Inherits="Electricity_Prj.AddBill" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Bills</h2>
    <asp:Label runat="server" ID="lblAuth" CssClass="msg-error"></asp:Label><br />

    <label class="label">Enter Number of Bills To Be Added:</label>
    <asp:TextBox runat="server" ID="txtCount" CssClass="input" /><br />

    <label class="label">Enter Consumer Number:</label>
    <asp:TextBox runat="server" ID="txtConsumerNumber" CssClass="input" /><br />

    <label class="label">Enter Consumer Name:</label>
    <asp:TextBox runat="server" ID="txtConsumerName" CssClass="input" /><br />

    <label class="label">Enter Units Consumed:</label>
    <asp:TextBox runat="server" ID="txtUnits" CssClass="input" /><br />
    <asp:Label runat="server" ID="lblUnitsError" CssClass="msg-error"></asp:Label><br />


    
<div class="button-container">
    <asp:Button runat="server" ID="btnAddOne" Text="Add Current Bill"
                CssClass="btn btn-primary" OnClick="btnAddOne_Click" />
    <asp:Button runat="server" ID="btnFinish" Text="Finish Adding"
                CssClass="btn btn-outline" OnClick="btnFinish_Click" />
</div>
<br /><br />

    <asp:Label runat="server" ID="lblOutput" CssClass="msg-success"></asp:Label>
    <asp:Literal runat="server" ID="litLog"></asp:Literal>
</asp:Content>
