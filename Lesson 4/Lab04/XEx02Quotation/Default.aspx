<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XEx02Quotation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Quotation</title>
    <style type="text/css">
        .auto-style1 {
            width: 513px;
            height: 241px;
        }
        .auto-style2 {
            width: 163px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Price Quotation</h1>
        <table cellpadding="3" cellspacing="1" class="auto-style1">
            <tr>
                <td class="auto-style4">Sales Price</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSalesPrice" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSalesPrice" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalesPrice" ErrorMessage="Sales price must range from 10 to 1000." ForeColor="Red" MaximumValue="1000" MinimumValue="10" Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Discount Percent</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDiscountPercent" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDiscountPercent" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtDiscountPercent" ErrorMessage="Discount percent must range from 10 to 50." ForeColor="Red" MaximumValue="50" MinimumValue="10" Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Discount Amount</td>
                <td class="auto-style3">
                    <asp:Label ID="lblDiscountAmount" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Total Price</td>
                <td class="auto-style3">
                    <asp:Label ID="lblTotalPrice" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
