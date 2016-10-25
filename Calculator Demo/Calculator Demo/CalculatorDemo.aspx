<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorDemo.aspx.cs" Inherits="Calculator_Demo.CalculatorDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBoxResult" runat="server" BorderWidth="1px" Enabled="False" Width="182px" Height="38px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="30px" Text="1" Width="30px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="30px" Text="2" Width="30px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="30px" Text="3" Width="30px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAdd" runat="server" Height="30px" Text="+" Width="30px" OnClick="ButtonAdd_Click" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Height="30px" Text="4" Width="30px" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="30px" Text="5" Width="30px" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="30px" Text="6" Width="30px" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonMinus" runat="server" Height="30px" Text="-" Width="30px" OnClick="ButtonMinus_Click" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Height="30px" Text="7" Width="30px" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Height="30px" Text="8" Width="30px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" Height="30px" Text="9" Width="30px" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonMultiply" runat="server" Height="30px" Text="*" Width="30px" OnClick="ButtonMultiply_Click" />
        <br />
        <br />
        <asp:Button ID="ButtonPoint" runat="server" Height="30px" Text="." Width="30px" OnClick="ButtonPoint_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button0" runat="server" Height="30px" Text="0" Width="30px" OnClick="Button0_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEqual" runat="server" Height="30px" Text="=" Width="30px" OnClick="ButtonEqual_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDivide" runat="server" Height="30px" Text="/" Width="30px" OnClick="ButtonDivide_Click" />
    </div>
    </form>
</body>
</html>
