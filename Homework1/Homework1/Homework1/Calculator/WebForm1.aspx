<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Homework1.Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculator</title>
    <style type="text/css">
        .kutu {}
    </style>
</head>
<body style="height: 771px">
    <form id="form1" runat="server">
         <div style="height: 522px">
    <asp:Panel ID="Panel1" runat="server"
            Width="280px" BackColor="#282828">
            <table class="style1">
                <tr>
                    <td colspan="4">
                        <asp:TextBox ID="TextBox1" runat="server" Height="60px" Width="263px" BackColor="Gray" BorderColor="Silver" Font-Bold="True" Font-Size="Medium" ForeColor="White" ReadOnly="True">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button16" runat="server" Height="60px" Text="C" Width="60px" OnClick="Button16_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="Red"  />
                    </td>
                    <td>
                        <asp:Button ID="Button10" runat="server" Height="60px" 
                            Text="/" Width="60px" OnClick="Button10_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button11" runat="server" Height="60px" 
                            Text="x" Width="60px" OnClick="Button11_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button12" runat="server" Height="60px" 
                            Text="-" Width="60px" OnClick="Button12_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button7" runat="server" Height="60px" 
                            Text="7" Width="60px" OnClick="Button7_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button8" runat="server" Height="60px" 
                            Text="8" Width="60px" OnClick="Button8_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button9" runat="server" Height="60px" 
                            Text="9" Width="60px" OnClick="Button9_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td rowspan="2">
                        <asp:Button ID="Button13" runat="server" Height="120px" 
                            Text="+" Width="60px" OnClick="Button13_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button4" runat="server" Height="60px" 
                            Text="4" Width="60px" OnClick="Button4_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Height="60px" 
                            Text="5" Width="60px" OnClick="Button5_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button6" runat="server" Height="60px" 
                            Text="6" Width="60px" OnClick="Button6_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="60px" 
                            Text="1" Width="60px" OnClick="Button1_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Height="60px" 
                            Text="2" Width="60px" OnClick="Button2_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Height="60px" 
                            Text="3" Width="60px" OnClick="Button3_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />
                    </td>
                    <td rowspan="2">
                        <asp:Button ID="Button14" runat="server" Height="120px"
                            Text="=" Width="60px" OnClick="Button14_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button15" runat="server" Height="60px" 
                            Text="0" Width="132px" OnClick="Button15_Click" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" />

                    </td>
                    <td><asp:Button ID="Button17" runat="server" BackColor="#282828" BorderColor="#CCCCCC" BorderStyle="Solid" ForeColor="White" Height="60px" Text="-/+" Width="60px" OnClick="Button17_Click" />
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
     
    </div>
    </form>
</body>
</html>
