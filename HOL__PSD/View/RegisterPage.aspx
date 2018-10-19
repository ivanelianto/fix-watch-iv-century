<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="HOL__PSD.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username" />
            <asp:TextBox ID="txtUsername" runat="server" />
            <asp:RequiredFieldValidator ID="requiredUsername" runat="server" 
                ErrorMessage="Username harus diisi"
                ControlToValidate="txtUsername" />
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Password" />
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
            <asp:RequiredFieldValidator ID="requiredPassword" runat="server" 
                ErrorMessage="Password harus diisi"
                ControlToValidate="txtPassword" />
        </div>
        
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server" Text="Tanggal Lahir" />
                <asp:Calendar ID="calendarTanggalLahir" runat="server" />
              </ContentTemplate>
        </asp:UpdatePanel>

        <div>
            <asp:Label ID="Label4" runat="server" Text="Foto (Optional)" />
            <asp:FileUpload ID="fileUploadFoto" runat="server" />
        </div>

        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
    </form>
</body>
</html>
