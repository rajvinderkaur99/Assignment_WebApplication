<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonDemo.aspx.cs" Inherits="WebRadiobutton.RadioButtonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 246px;
        }
        .auto-style3 {
            height: 246px;
            width: 955px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricketer" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Player" />
        <asp:Panel ID="Panel1" runat="server" Height="232px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <br />
                        <asp:Panel ID="Panel5" runat="server">
                            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Ms.html">M. S. Dhoni</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Vk.html">Virat Kohli</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/Rs.html">Rohit Sharma</asp:HyperLink>
                        </asp:Panel>
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style2">
                        <br />
                        <asp:Panel ID="Panel3" runat="server">
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Rf.html">Roger Federer</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Rn.html">Raafael Nadal</asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Nd.html">Novak</asp:HyperLink>
                        </asp:Panel>
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
