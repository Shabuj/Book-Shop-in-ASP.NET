<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBookUi.aspx.cs" Inherits="BookShop.AddBookUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Add Book Information </h1>
    <div class="form-group">
        <label for="inputBookName">Book Name </label>
        <input type="text" class="form-control" runat="server" id="inputBookName" placeholder="Enter Book Name">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" Display="Dynamic" ControlToValidate="inputBookName" ErrorMessage="Field can't be empty "></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label for="inputISBN">ISBN </label>
        <input type="text" runat="server" class="form-control" id="inputISBN" placeholder="Enter ISBN">
    </div>
    <div class="form-group">
        <label for="inputAuthor">Author </label>
        <input type="text" runat="server" class="form-control" id="inputAuthor" placeholder="Enter Author Address">
    </div>
    
    <asp:Button ID="saveButton" class="btn btn-success" runat="server" Text="Add Student" OnClick="saveButton_Click" />
     
    <br />
    <asp:Label ID="messageLabel" runat="server" ></asp:Label>
</asp:Content>
