<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="HOL__PSD.View.ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row h-100">
            <div class="col-md-12 h-100 d-flex align-items-center justify-content-center">
                <div class="col-md-3">
                    <div class="card">
                        <%
                            if (product != null)
                            {
                        %>
                        <div class="card-header">
                            <h4><%= product.name %></h4>
                        </div>

                        <div class="card-body">
                            <p><%= ((decimal)product.price).ToString("C") %></p>
                            <p>Stock Available : <%= product.stock %></p>
                        </div>
                        <%
                            if (Session["auth_user"] != null)
                            {
                        %>
                                <div class="card-footer">
                                    <div class="col-md-12 d-flex flex-column">
                                        <asp:Label
                                            Text="Quantity : "
                                            runat="server" />

                                        <asp:TextBox
                                            class="my-2"
                                            TextMode="Number"
                                            ID="txtQuantity"
                                            runat="server" />

                                        <asp:RangeValidator
                                            CssClass="text-danger"
                                            ID="qtyValidator" 
                                            MinimumValue="1"
                                            Type="Integer"
                                            ControlToValidate="txtQuantity"
                                            ErrorMessage="Invalid Quantity!"
                                            Display="Dynamic"
                                            runat="server" />

                                        <asp:Button
                                            CssClass="btn btn-primary float-right"
                                            OnClick="btnBuy_Click"
                                            Text="Buy"
                                            runat="server" />
                                    </div>
                                </div>
                        <%
                                }
                            }
                        %>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
