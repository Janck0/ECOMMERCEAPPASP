<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="ECOMMERCEAPPASP2.ADMIN.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 198px;
        }
        .auto-style3 {
            width: 198px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
        #content1{
            padding:25px;
        }
        button{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content1">
        <h3 align="center">PRODUCT DETAILS</h3>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" ForeColor="Black">
                </asp:DropDownList>
                <br />
                <asp:GridView ID="GridView1" runat="server" DataKeyNames="P_ID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanging="GridView1_SelectedIndexChanging1" >
                    <Columns>
                        <asp:CommandField />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD PRODUCT" Font-Bold="True" Font-Size="Large" Height="28px" Width="189px" />
        <br />
        <div id="addprod">
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            <h4>ADD PRODUCT</h4>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">CATEGORY</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="165px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PRODUCT NAME</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">DESCRIPTION</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PRODUCT IMAGE</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PRICE</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox4" runat="server" type="number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">STOCK</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" type="number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="cancel" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
            </div>
    </div>
        
        
        <br />
</asp:Content>
