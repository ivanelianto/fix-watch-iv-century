<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" 
    CodeBehind="Index.aspx.cs" Inherits="HOL__PSD.View.Index" %>

<asp:Content ContentPlaceHolderID="Stylesheets" runat="server">
    <link rel="stylesheet" href="../Assets/css/index.css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 product-wrapper">
                <%
                    if (products.Count > 0)
                    {
                        foreach (var product in products)
                        {
                %>
                            <div class="card product">
                                <div class="card-body">
                                    <p><%= product.name %></p>
                                    <p><%= ((decimal)product.price).ToString("C") %></p>
                                </div>
                                <div class="card-footer">
                                    <a href='<%= ResolveUrl("~/View/ProductDetail.aspx?id=" + product.id) %>'>
                                        View More
                                    </a>
                                </div>
                            </div>
                <%
                        }
                    }
                %>
            </div>
        </div>
    </div>
</asp:Content>
