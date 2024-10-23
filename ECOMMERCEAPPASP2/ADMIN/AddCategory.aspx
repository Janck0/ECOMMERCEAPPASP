<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="ECOMMERCEAPPASP2.ADMIN.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 191px;
    }
    .auto-style6 {
        width: 191px;
        height: 26px;
    }
    .auto-style7 {
        height: 26px;
    }
    .auto-style10 {
        width: 191px;
        height: 39px;
    }
    .auto-style11 {
        height: 39px;
    }
    .auto-style12 {
        width: 191px;
        height: 29px;
    }
    .auto-style13 {
        height: 29px;
    }
    .auto-style14 {
        width: 191px;
        height: 19px;
    }
    .auto-style15 {
        height: 19px;
    }
    .auto-style16 {
        width: 191px;
        height: 12px;
    }
    .auto-style17 {
        height: 12px;
   
    }
     #container{
                  padding:20px;
              }
   #content{
       padding:20px;
   }
    
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <H1 align="center">CATEGORY PAGE</H1>
   
   <div id="content">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:Button ID="Button1" runat="server" Text="ADD CATEGORY" OnClick="Button1_Click" />
    
<div id="container">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server"  DataKeyNames="CAT_ID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" CellPadding="1" Font-Names="Comic Sans MS" Font-Size="X-Small" GridLines="Vertical" Height="236px" HorizontalAlign="Center" Width="308px">
                <AlternatingRowStyle BackColor="#CCFFCC" HorizontalAlign="Center" VerticalAlign="Middle" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowEditButton="True"  >
                    <ControlStyle BackColor="#0099FF" BorderColor="White" BorderStyle="Solid" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" >
                    <ControlStyle BackColor="#66FF99" Font-Bold="True" Font-Italic="True" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="true" >
                    <ControlStyle BackColor="Red" />
                    </asp:CommandField>
                </Columns>
                <EditRowStyle BackColor="#FFCC99" BorderColor="Black" BorderWidth="1px" Font-Bold="True" Font-Size="Small" Font-Underline="True" ForeColor="White" />
                <FooterStyle BackColor="#FFFFCC" />
                <HeaderStyle BackColor="#FF9999" BorderColor="Fuchsia" VerticalAlign="Middle" />
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
<div>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
</div>
<table class="auto-style1">
    <tr>
        <td>
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6"><b>ADD CATEGORY</b></td>
                        <td class="auto-style7"></td>
                    </tr>
                    <tr>
                        <td class="auto-style10">Category Name</td>
                        <td class="auto-style11">
                            <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="287px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">Category Description</td>
                        <td class="auto-style13">
                            <asp:TextBox ID="TextBox2" runat="server" Height="28px" Width="281px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Category Image</td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="113px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16"></td>
                        <td class="auto-style17"></td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Button ID="Button3" runat="server" Height="34px" OnClick="Button3_Click" Text="clear" Width="182px" />
                        </td>
                        <td class="auto-style15">
                            <asp:Button ID="Button2" runat="server" Height="32px" OnClick="Button2_Click" Text="ADD" Width="295px" />
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
</table>
       </div>
</asp:Content>
