<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Coding05_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Quotation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Price Quotation</h1>
        <main>
            <asp:TextBox ID="txtSalesPrice" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSalesPrice" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalesPrice" ErrorMessage="Sales price must range from 10 to 1000." ForeColor="Red" MaximumValue="1000" MinimumValue="10" Type="Double"></asp:RangeValidator>      
            <asp:TextBox ID="txtDiscountPercent" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDiscountPercent" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>        
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtDiscountPercent" ErrorMessage="Discount percent must range from 10 to 50." ForeColor="Red" MaximumValue="50" MinimumValue="10" Type="Double"></asp:RangeValidator>
            <asp:Label ID="lblDiscountAmount" runat="server" Text="Label"></asp:Label>       
            <asp:Label ID="lblTotalPrice" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />      
        </main>
    </div>
    </form>
</body>
</html>
