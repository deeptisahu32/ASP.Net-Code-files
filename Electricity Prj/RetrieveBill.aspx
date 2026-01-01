<%@ Page Title="Retrieve Bill" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true"
    CodeBehind="RetrieveBill.aspx.cs" Inherits="Electricity_Prj.RetrieveBill" %>

<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!--Retrive N last number customer-->
    <h2>Retrieve Last N Bills</h2>

    <asp:Label ID="lblStatus" runat="server" CssClass="msg-error"></asp:Label><br />

    <label class="label">Enter Last 'N' Number of Bills To Generate:</label>
    <asp:TextBox ID="txtLastN" runat="server" CssClass="input" />
    &nbsp;&nbsp;
    <div class="button-container">
        <asp:Button ID="btnFetch" runat="server" Text="Fetch Last Consumer" CssClass="btn btn-primary" OnClick="btnFetch_Click" />
    </div>


    <!-- Retrieve by Consumer ID -->
    <div class="button-container" style="text-align: center; margin-top: 16px;">
        <label class="label">Enter Consumer Id for fetching details:</label>
        <asp:TextBox ID="txtConsumerId" runat="server" CssClass="c" Placeholder="Consumer Number (e.g., EB12345)" />
        <asp:Button ID="btnRetrieveByCN" runat="server" Text="Retrieve by Consumer ID"
            CssClass="btn btn-outline" OnClick="btnRetrieveByCN_Click" />
    </div>

    <asp:Label ID="lblSearchMsg" runat="server" CssClass="msg-error" />

    <br />
    <br />

    <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="False" CssClass="grid">
        <Columns>
            <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
            <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
            <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
            <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" DataFormatString="{0:N2}" />
            <asp:BoundField DataField="CreatedAt" HeaderText="Date" DataFormatString="{0:dd-MMM-yyyy HH:mm}" HtmlEncode="False" />
        </Columns>
    </asp:GridView>
</asp:Content>
