<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="HOL__PSD.View.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="container mt-3">
        <div class="row">
            <div class="col-md-8 offset-md-2">
                <%
                    if (headerTransactions.Count < 1)
                    {
                %>
                <h1 class="text-center">You Never Do Any Transaction</h1>
                <%
                    }
                    else
                    {
                        foreach (var header in headerTransactions)
                        {
                            foreach (var detail in header.DetailTransaction)
                            {
                %>
                <div class="card mb-3">
                    <div class="card-header">
                        <strong><%= detail.Product.name %></strong>
                        <strong class="float-right"><%= header.occurance.Value.ToString("dddd, dd MMMM yyyy HH:mm:ss") %></strong>
                    </div>

                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-3">
                                <span>Quantity : <%= detail.quantity %> pcs</span>
                            </div>

                            <div class="col-md-9">
                                <span>Price : <%= ((double)detail.price).ToString("C") %></span>
                            </div>
                        </div>
                    </div>

                    <div class="card-footer">
                        <strong>Total : <%= ((double)(detail.price * detail.quantity)).ToString("C") %></strong>
                    </div>
                </div>
                <%
                            }
                        }
                    }
                %>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
