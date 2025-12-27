<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Electricity_Prj.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Admin Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f5f7fb;
            margin: 0;
            padding: 0;
        }

        .login-wrap {
            max-width: 420px;
            margin: 50px auto;
            background: #ffffff;
            border: 1px solid #e6e9ef;
            border-radius: 12px;
            box-shadow: 0 12px 28px rgba(0,0,0,0.08);
            padding: 24px 20px;
        }

        .login-title {
            margin: 0 0 12px 0;
            font-size: 22px;
            font-weight: 700;
            color: #1f2937;
            text-align: center;
        }

        .m {
            display: block;
            min-height: 18px;
            color: #dc2626;
            font-size: 13px;
            text-align: center;
            margin-bottom: 8px;
        }

        .c {
            padding: 10px 12px;
            border: 1px solid #cbd5e1;
            border-radius: 8px;
            font-size: 14px;
            background: #fff;
            width: 280px;
            max-width: 90%;
            display: block;
            margin: 0 auto;
        }

            .c::placeholder {
                color: #9aa3af;
            }

            .c:focus {
                outline: none;
                border-color: #6366f1;
                box-shadow: 0 0 0 3px rgba(99,102,241,0.18);
            }

        .gap {
            height: 12px;
            display: block;
        }

        .b {
            width: 280px;
            max-width: 90%;
            margin: 0 auto;
            display: block;
            padding: 10px 14px;
            border: 1px solid transparent;
            border-radius: 8px;
            background: #2563eb;
            color: #fff;
            font-weight: 700;
            letter-spacing: 0.2px;
            cursor: pointer;
            transition: background .15s ease, transform .05s ease;
        }

            .b:hover {
                background: #1d4ed8;
            }

            .b:active {
                transform: translateY(1px);
            }

            .b:disabled {
                background: #9ca3af;
                cursor: not-allowed;
                opacity: 0.75;
            }

        .foot-note {
            text-align: center;
            color: #64748b;
            font-size: 12px;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="login-wrap">
            <h2 class="login-title">Admin Login</h2>

            <!-- error/success message -->
            <asp:Label runat="server" ID="lblMsg" CssClass="m"></asp:Label>
            <span class="gap"></span>

            <!-- username -->
            <asp:TextBox runat="server" ID="txtUser" Placeholder="Username" CssClass="c"></asp:TextBox>
            <span class="gap"></span>

            <!-- password -->
            <asp:TextBox runat="server" ID="txtPass" TextMode="Password" Placeholder="Password" CssClass="c"></asp:TextBox>
            <span class="gap"></span>

            <!-- login button -->
            <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="b" OnClick="btnLogin_Click" />

            <div class="foot-note">Use your admin credentials to sign in</div>
        </div>
    </form>
</body>
</html>

