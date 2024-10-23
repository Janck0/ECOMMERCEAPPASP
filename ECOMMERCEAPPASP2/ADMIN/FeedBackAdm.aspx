<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/AdminLayout.Master" AutoEventWireup="true" CodeBehind="FeedBackAdm.aspx.cs" Inherits="ECOMMERCEAPPASP2.ADMIN.FeedBackAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        <center>ADMIN FEEDBACK</center>
    </h1>
    <center>
        <asp:Panel ID="GRIDPANEL" runat="server" Visible="true">
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>

                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="SendMail"
                            Text="SendMail" OnClick="Button1_Click" CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </asp:Panel>

        

    </center>
    <div>
    </div>
    <asp:Panel ID="Pn1" runat="server" Visible="false">
        <center>

            <br />
            <div class="card-header" style="width:50%">
               sent through mail:
            </div>
            <div class="card-body">
                <asp:TextBox ID="RMSG" runat="server" Class="form-control" style="width:40%" rows="3"></asp:TextBox>
                <br />
                <asp:Button ID="SndMail" runat="server" Text="send" OnClick="SndMail_Click" class="btn btn-primary"/>
            </div>
           
        </center>
    </asp:Panel>

</asp:Content>
