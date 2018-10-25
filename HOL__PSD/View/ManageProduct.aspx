<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="HOL__PSD.View.ManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Manage Product
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div 
        id="ProductDataTableWrapper"
        class="w-100" 
        runat="server">
        <div class="col-md-12 py-3">
            <div class="container d-flex justify-content-between 
  align-items-center">
                <h4 class="">List of Products</h4>
                <asp:Button
                    class="btn btn-success"
                    ID="btnAddNewProduct"
                    Text="Add New Product"
                    OnClick="btnAddNewProduct_Click"
                    runat="server" />
            </div>
        </div>

        <div class="col-md-12">
            <div class="container">
                <asp:Table
                    ID="ProductTable"
                    class="table table-bordered text-center"
                    runat="server">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>No.</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Stock</asp:TableHeaderCell>
                        <asp:TableHeaderCell ColumnSpan="2">Action</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </div>
    </div>
</asp:Content>
