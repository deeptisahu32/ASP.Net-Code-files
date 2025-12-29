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

    <asp:Button runat="server" ID="btnAddOne" Text="Add Current Bill" CssClass="btn btn-primary" OnClick="btnAddOne_Click" />
    &nbsp;&nbsp;<asp:Button runat="server" ID="btnFinish" Text="Finish Adding" CssClass="btn btn-outline" OnClick="btnFinish_Click" /><br /><br />

    <asp:Label runat="server" ID="lblOutput" CssClass="msg-success"></asp:Label>
    <asp:Literal runat="server" ID="litLog"></asp:Literal>

    <hr />
    <h3>Retrieve Last N Bills</h3>
    <label class="label">Enter Last 'N' Number of Bills To Generate:</label>
    <asp:TextBox runat="server" ID="txtLastN" CssClass="input" /><br />
    <asp:Button runat="server" ID="btnRetrieve" Text="Get Last N Bills" CssClass="btn btn-primary" OnClick="btnRetrieve_Click" /><br /><br />

    <asp:GridView runat="server" ID="gvLastN" AutoGenerateColumns="false" CssClass="grid">
        <Columns>
            <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
            <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
            <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
            <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" DataFormatString="{0:N2}" />
        </Columns>
    </asp:GridView>
</asp:Content>

