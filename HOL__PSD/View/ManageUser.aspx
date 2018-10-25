<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="HOL__PSD.View.ManageUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Manage User
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div 
        id="UserDataTableWrapper"
        class="w-100" 
        runat="server">
        <div class="col-md-12 py-3">
            <div class="container d-flex justify-content-between 
  align-items-center">
                <h4 class="">List of Users</h4>
                <asp:Button
                    class="btn btn-success"
                    ID="btnAddNewUser"
                    Text="Add New User"
                    OnClick="btnAddNewUser_Click"
                    runat="server" />
            </div>
        </div>

        <div class="col-md-12">
            <div class="container">
                <asp:Table
                    ID="UserTable"
                    class="table table-bordered text-center"
                    runat="server">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>No.</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Username</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Password</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Role</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Birthday</asp:TableHeaderCell>
                        <asp:TableHeaderCell ColumnSpan="2">Action</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </div>
    </div>
</asp:Content>
