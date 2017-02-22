<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1"><strong>Simple Calculator</strong></h1>
    
    </div>
        <p>
            <span class="auto-style2">First Value:</span>&nbsp;
            <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style2">Second Value:</span>&nbsp;
            <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="add" runat="server" OnClick="add_Click" Text="+" />
&nbsp;&nbsp;
            <asp:Button ID="subtract" runat="server" OnClick="subtract_Click" Text="-" />
&nbsp;&nbsp;
            <asp:Button ID="mult" runat="server" OnClick="mult_Click" Text="*" />
&nbsp;&nbsp;
            <asp:Button ID="divide" runat="server" OnClick="divide_Click" style="height: 29px" Text="/" />
        </p>
        <asp:Label ID="result" runat="server" style="background-color: #66CCFF"></asp:Label>
    </form>
</body>
</html>
