<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm2.aspx.cs" Inherits="ValidationProject.CustomForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Validation Client Side JS enabled</title>
    <script type="text/javascript">
        function CheckLength(source,args)
        {
            if (args.Value == "") {
                args.IsValid = false;
                alert("Empty text , enter some text")
            }
            else
            {
                if (args.Value.length>= 8) {
                    args.IsValid = true;
                    alert("Validation Suceeded");
                }
                else
                {
                    args.IsValid = false;
                    alert("Validation Failed try again");
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            &nbsp;&nbsp;Enter some text or name&nbsp;&nbsp;
            <asp:TextBox ID="textid" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckLength" ControlToValidate="textid" ErrorMessage="text length should be 8 or greater than 8" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="saveid" runat="server" Text="Save" OnClick="saveid_Click" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
