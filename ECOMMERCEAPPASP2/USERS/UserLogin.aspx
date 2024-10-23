<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/UserLogin.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="input-box underline">
          <asp:TextBox ID="TextBox1" runat="server" placeholder="USERNAME"></asp:TextBox>
          <div class="underline"></div>
        </div>
    <div class="input-box underline">
          <asp:TextBox ID="TextBox2" runat="server" placeholder="PASSWORD" type="password"></asp:TextBox>
          <div class="underline"></div>
        </div>
    <div class="input-box button">
          
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        new user
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/USERS/UserRegn.aspx">register here</asp:HyperLink>
          
        </div>
    <div class="option">or Connect With Social Media</div>
        <div class="twitter">
          <a href="#"><i class="fab fa-twitter"></i>Sign in With Twitter</a>
        </div>
        <div class="facebook">
          <a href="#"><i class="fab fa-facebook-f"></i>Sign in With Facebook</a>
        </div>

<br />

</asp:Content>
        
