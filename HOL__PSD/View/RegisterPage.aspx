<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true"
    CodeBehind="RegisterPage.aspx.cs" Inherits="HOL__PSD.View.RegisterPage" %>

<asp:Content ContentPlaceHolderID="title" runat="server">
    Register Page
</asp:Content>

<asp:Content ContentPlaceHolderID="Stylesheets" runat="server">
    <link rel="stylesheet" type="text/css" href="../Assets/css/register-page.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="container content-wrapper">
        <div class="row align-items-center">
            <asp:Label ID="Label1" runat="server" Text="Username" />
            <asp:TextBox ID="txtUsername" runat="server" />
            <asp:RequiredFieldValidator ID="requiredUsername" runat="server"
                ErrorMessage="Username harus diisi"
                ControlToValidate="txtUsername" />
        </div>

        <div class="row align-items-center">
            <asp:Label ID="Label2" runat="server" Text="Password" />
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
            <asp:RequiredFieldValidator ID="requiredPassword" runat="server"
                ErrorMessage="Password harus diisi"
                ControlToValidate="txtPassword" />
        </div>

        <div class="row align-items-center">
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label3" runat="server" Text="Tanggal Lahir" />
                    <asp:Calendar ID="calendarTanggalLahir" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="row align-items-center">
            <asp:Label ID="Label4" runat="server" Text="Foto (Optional)" />
            <asp:FileUpload ID="fileUploadFoto" runat="server" />
        </div>

        <div class="row align-items-center">
            <asp:Button ID="btnRegister" runat="server" Text="Register" 
                class="btn btn-primary"
                OnClick="btnRegister_Click" />
        </div>
    </div>
</asp:Content>
