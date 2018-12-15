<%@ Page Title="My Cart" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="HOL__PSD.View.CartPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container mt-3">
        <div class="row">
            <div class="col-md-12">
                <%
                    if (carts == null || carts.Count < 1)
                    {
                %>
                <h1 class="text-center">
                    Your Cart is Empty
                </h1>
                <%
                    }
                    else
                    {

                        foreach (var item in carts)
                        {
                %>
                <div class="card mb-3">
                    <div class="card-header">
                        <%= item.Product.name %>
                    </div>

                    <div class="card-body">
                        Quantity : <%= item.Quantity %> pcs
                    </div>

                    <div class="card-footer">
                        Subtotal : <%= ((double)(item.Product.price * item.Quantity)).ToString("C") %>
                    </div>
                </div>
                <%
                    }
                %>

                <div class="card mb-3">
                    <div class="card-body">
                        <h3>
                            <strong>
                                Grandtotal : <%= ((double)carts.Sum(x => x.Product.price * x.Quantity)).ToString("C") %>
                            </strong>
                        </h3>
                    </div>
                </div>

                <asp:Button
                    CssClass="btn btn-primary w-100 mb-3"
                    ID="btnCheckout"
                    Text="Checkout"
                    OnClick="btnCheckout_Click"
                    runat="server" />
                <%
                    }
                %>
            </div>
        </div>
    </div>
</asp:Content>
