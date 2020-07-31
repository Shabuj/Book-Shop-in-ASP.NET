<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowBookUi.aspx.cs" Inherits="BookShop.ShowBookUi" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>SHOW BOOK</h2>
     <div class="form-group row">
        <table style="width:100%;">
        <tr>
            <td style="width: 145px" class="text-center"><strong>Name</strong></td>
            <td class="modal-sm" style="width: 128px">
                <asp:TextBox ID="searchBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="searchButton" class="btn btn-success" runat="server" Text="Search" CssClass="col-xs-offset-0" OnClick="searchButton_Click" />
            </td>
        </tr>
        </table>
    
    </div>

    <p>
        <br />
        <asp:GridView ID="GridView" AutoGenerateColumns="False" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <Columns>
            <asp:TemplateField HeaderText="Book Name "> 
                <ItemTemplate>
                    <%#Eval("BookName")  %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="ISBN "> 
                <ItemTemplate>
                    <%#Eval("ISBN") %>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Author "> 
                <ItemTemplate>
                    <%#Eval("Author") %>
                </ItemTemplate>
            </asp:TemplateField>

            

        </Columns>

            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
         


       
    </p>
<p>
        &nbsp;</p>


</asp:Content>
