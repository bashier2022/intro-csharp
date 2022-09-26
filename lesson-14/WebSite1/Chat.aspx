<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBoxChatMessages" runat="server" Height="188px" Width="893px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
&nbsp;
            <asp:TextBox ID="tbChatMessage" runat="server" Height="44px" Width="663px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="btnSend" runat="server" OnClick="OnSend_Click" Text="Send" />
        </div>
    </form>
</body>
</html>
