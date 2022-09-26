<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCalc.aspx.cs" Inherits="DefaultCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Bashier</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 40px">
            <asp:TextBox ID="textBox_ProgramCode" runat="server" BorderColor="#000066" Height="400px" TextMode="MultiLine"></asp:TextBox>
&nbsp;&nbsp;
            <asp:ListBox ID="listBox_ExeCode" runat="server" Height="400px" Width="120px"></asp:ListBox>
&nbsp;
            <asp:ListBox ID="listBox_StackViewer" runat="server" Height="400px" Width="120px"></asp:ListBox>
&nbsp;
            <asp:ListBox ID="listBox_IPStackViewer" runat="server" Height="400px" Width="120px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBoxMemoryData" runat="server" Height="400px" Width="90px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:ImageMap ID="ImageMap_MemoryViewer" runat="server" Height="363px" Width="312px">
            </asp:ImageMap>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnBuild" runat="server" OnClick="BuildCode_Click" Text="Build" Width="115px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnExecuteStep" runat="server" OnClick="ExecuteStep_Click" Text="Execute Step" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPC" runat="server" Text="PC:  "></asp:Label>
            <asp:TextBox ID="tbxPcValue" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnClear" runat="server" Text="Clear" Width="117px" />
&nbsp;&nbsp;
            <asp:Button ID="btnRun" runat="server" Text="RUN" Width="124px" OnClick="Run_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textBox_ExecutingMessage" runat="server" Width="201px"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnLoadProg" runat="server" Text="Load Program" Width="117px" />
&nbsp;&nbsp;
            <asp:Button ID="btnSaveProg" runat="server" Text="Save Program" Width="125px" />
        </p>
        
        <p style="margin-left: 40px">
            <asp:Image ID="ImageMemory" runat="server" Height="223px" Width="533px" />
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
    </form>
</body>
</html>
