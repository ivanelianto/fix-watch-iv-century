<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="MasterUser.aspx.cs" Inherits="HOL__PSD.View.MasterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link rel="stylesheet" type="text/css" href="../Assets/css/register-page.css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container content-wrapper">
        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label1" runat="server" Text="Username"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtUsername" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="requiredUsername" runat="server"
                ValidationGroup="groupRegister"
                class="text-danger"
                ErrorMessage="Username harus diisi"
                ControlToValidate="txtUsername" />
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label4" runat="server" Text="Name"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtName" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ValidationGroup="groupRegister"
                class="text-danger"
                ErrorMessage="Nama harus diisi"
                ControlToValidate="txtName" />
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label2" runat="server" Text="Password"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="requiredPassword" runat="server"
                ValidationGroup="groupRegister"
                class="text-danger"
                ErrorMessage="Password harus diisi"
                ControlToValidate="txtPassword" />
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label5" runat="server" Text="Role"
                        class="input-group-text" />
                </div>

                <asp:DropDownList ID="roleDropDownList" runat="server"
                    class="form-control">
                    <asp:ListItem Text="User" Value="User"/>
                    <asp:ListItem Text="Admin" Value="Admin"/>
                </asp:DropDownList>
            </div>
        </div>

        <div class="row align-items-center">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="col-md-4 offset-4">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server"
                    class="d-flex flex-column justify-content-center align-items-center card">
                    <ContentTemplate>
                        <asp:Label ID="Label3" runat="server" Text="Tanggal Lahir"
                            class="py-3" />

                        <div class="pb-3">
                            <asp:Calendar ID="calendarTanggalLahir" runat="server" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4">
                <asp:Button ID="btnProcess" runat="server" Text="Submit"
                    ValidationGroup="groupRegister"
                    class="btn btn-primary w-100"
                    OnClick="btnProcess_Click" />
            </div>
        </div>
    </div>
</asp:Content>
