<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="ECOMMERCEAPPASP2.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="top_catagory_area section-padding-80 clearfix">
            <div class="container">
            <div class="row justify-content-center">
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div class="col-12 col-sm-6 col-md-4">
                    <div class="single_catagory_area border_radius-12px d-flex align-items-center justify-content-center bg-img" style="background-image:url('<%#Eval("C_IMAGE")%>')">
                        <div class="catagory-content">
                            
                            <a href="ProductPage.aspx?cid=<%#Eval("CAT_ID") %>""> <%#Eval("C_NAME") %></a>
                        </div>
                    </div>
             </div>
        </ItemTemplate>
    </asp:ListView>
                </div>
            </div>
     </div>    
</asp:Content>

<%--<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
     
   <asp:ListView ID="cartList" runat="server">
       <ItemTemplate>
           <div class="single-cart-item">
                    <a href="#" class="product-image">
                        <img src="<%#Eval("P_IMAGE") %>" class="cart-thumb " alt="">
                        <!-- Cart Item Desc -->
                        <div class="cart-item-desc">
                          <span class="product-remove"><i class="fa fa-close" aria-hidden="true"></i></span>
                            <span class="badge"></span>
                            <h6><%#Eval("P_NAME")%></h6>
                            <p class="size">Size: S</p>
                            
                            <p class="price"><%#Eval("P_PRICE") %></p>
                        </div>
                    </a>
                </div>
       </ItemTemplate>
   </asp:ListView>
</asp:Content>--%>
