<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="HOL__PSD.View.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container mt-3">
        <div class="row">
            <div class="col-md-8 offset-md-2">
                <div class="card">
                    <div class="card-header">
                        <span>Product Name</span>
                        <span class="float-right">Occurance</span>
                    </div>

                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-6">
                                <span>Quantity</span>
                            </div>

                            <div class="col-md-6">
                                <span>Price</span>
                            </div>
                        </div>
                    </div>

                    <div class="card-footer">
                        <span>Subtotal</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
