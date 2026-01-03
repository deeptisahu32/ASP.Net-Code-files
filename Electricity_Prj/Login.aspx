<%@ Page Title="Admin Login" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="Electricity_Prj.Login" %>

<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-wrap" style="max-width: 420px; margin: 40px auto; background: silver; border: 1px solid #e6e9ef; border-radius: 12px; box-shadow: 0 12px 28px rgba(0,0,0,0.08); padding: 24px 20px;">
        <h2 class="login-title" style="margin: 0 0 12px; font-size: 22px; font-weight: 700; color: #1f2937; text-align: center;">Admin Login</h2>
        <asp:Label runat="server" ID="lblMsg" CssClass="m" ForeColor="Red"  />
        <span class="gap"></span>
        <br />
        <asp:TextBox runat="server" ID="txtUser" Placeholder="Username" CssClass="c" />
        <span class="gap"></span>
        <br />
        <br />
        <asp:TextBox runat="server" ID="txtPass" TextMode="Password" Placeholder="Password" CssClass="c" />
        <span class="gap"></span>
        <br />
        <br />
        <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="b" OnClick="btnLogin_Click" />
        <div class="foot-note" style="text-align: center; color: black; font-size: 12px; margin-top: 10px;">
        Use your admin credentials to sign in
       </div>
    </div>
</asp:Content>

