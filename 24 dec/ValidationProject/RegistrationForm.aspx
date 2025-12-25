<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="ValidationProject.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .selfstyle{
            height:450px;
            margin-left:40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
            <div class="selfstyle">
                <h1 style="color:darkblue;font-size:20px;text-align:center">Registraion Form</h1>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="nameid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is Required" ControlToValidate="nameid" ForeColor="Red" ValidationGroup="regis">*</asp:RequiredFieldValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                Age&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="Ageid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Ageid" ErrorMessage="Age must enter" ForeColor="Red" ValidationGroup="regis">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Ageid" ErrorMessage="renge will be between 20 and 30" ForeColor="Red" MaximumValue="30" MinimumValue="20" Type="Integer" ValidationGroup="regis">*</asp:RangeValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="Passid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Passid" ErrorMessage="Password required" ForeColor="Red" ValidationGroup="regis">*</asp:RequiredFieldValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                Confirm Password :
                <asp:TextBox ID="Cpassid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Cpassid" ErrorMessage="password required" ForeColor="Red" ValidationGroup="regis">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Passid" ControlToValidate="Cpassid" ErrorMessage="Compare with password" ForeColor="Red" ValidationGroup="regis">*</asp:CompareValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="emailid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="emailid" ErrorMessage="Email Required" ForeColor="Red" ValidationGroup="regis">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailid" ErrorMessage="should be in email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="regis">*</asp:RegularExpressionValidator>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnregisterid" runat="server" Text="Register" OnClick="btnregisterid_Click" ValidationGroup="regis" />
            </div>

        <div class="selfstyle">
        <h1 style="color:darkblue;font-size:20px;text-align:center">Login Form</h1>
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Login Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="loginid" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="loginid" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="lgngroup">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="nameid" ControlToValidate="loginid" ErrorMessage="CompareValidator" ForeColor="Red" ValidationGroup="lgngroup">*</asp:CompareValidator>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lpassid" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="lpassid" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="lgngroup">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="Passid" ControlToValidate="lpassid" ErrorMessage="CompareValidator" ForeColor="Red" ValidationGroup="lgngroup">*</asp:CompareValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="loginBtnid" runat="server" Text="Login" OnClick="loginBtnid_Click" ValidationGroup="lgngroup" />

        </div>

        
    </form>
</body>
</html>
