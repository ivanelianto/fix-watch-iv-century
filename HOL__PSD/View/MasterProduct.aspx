<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="MasterProduct.aspx.cs" Inherits="HOL__PSD.View.MasterProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">    
    Product
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link rel="stylesheet" type="text/css" href="../Assets/css/register-page.css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container content-wrapper">
        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label1" runat="server" Text="Name"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtName" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="requiredName" runat="server"
                ValidationGroup="groupSubmit"
                class="text-danger"
                ErrorMessage="Nama produk harus diisi"
                ControlToValidate="txtName" />
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label4" runat="server" Text="Price"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtPrice" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                Display="Dynamic"
                ValidationGroup="groupSubmit"
                class="text-danger"
                ErrorMessage="Harga harus diisi"
                ControlToValidate="txtPrice" />

            <asp:CustomValidator 
                ID="validatorPrice"
                ClientValidationFunction="isValidPrice"
                Display="Dynamic"
                ValidationGroup="groupSubmit"
                CssClass="text-danger"
                ControlToValidate="txtPrice"
                runat="server"/>
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4 input-group">
                <div class="input-group-prepend">
                    <asp:Label ID="Label2" runat="server" Text="Stock"
                        class="input-group-text" />
                </div>

                <asp:TextBox ID="txtStock" runat="server"
                    class="form-control" />
            </div>

            <asp:RequiredFieldValidator ID="requiredStock" runat="server"
                Display="Dynamic"
                ValidationGroup="groupSubmit"
                class="text-danger"
                ErrorMessage="Stock harus diisi"
                ControlToValidate="txtStock" />

            <asp:CustomValidator 
                ID="validatorStock"
                ClientValidationFunction="isValidStock"
                Display="Dynamic"
                ValidationGroup="groupSubmit"
                CssClass="text-danger"
                ControlToValidate="txtStock"
                runat="server"/>
        </div>

        <div class="row align-items-center">
            <div class="col-md-4 offset-4">
                <asp:Button ID="btnProcess" runat="server" Text="Submit"
                    CausesValidation="true"
                    ValidationGroup="groupSubmit"
                    class="btn btn-primary w-100"
                    OnClick="btnProcess_Click" />
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="Scripts" runat="server">
    <script>
        function isValidPrice(sender, args)
        {
            if (!isNaN(args.Value))
            {
                if (parseInt(args.Value) < 1000)
                {
                    sender.textContent = "Harga Minimal adalah 1000";
                    args.IsValid = false;
                }
                else
                    args.IsValid = true;
            }
            else
            {
                sender.textContent = "Harga Harus Diisi dan Adalah Nilai";
                args.IsValid = false;
            }
        }

        function isValidStock(sender, args)
        {
            if (!isNaN(args.Value)) {
                if (parseInt(args.Value) < 1) {
                    sender.textContent = "Stock Minimal adalah 1";
                    args.IsValid = false;
                }
                else
                    args.IsValid = true;
            }
            else {
                sender.textContent = "Stock Harus Diisi dan Adalah Nilai";
                args.IsValid = false;
            }
        }
    </script>
</asp:Content>
