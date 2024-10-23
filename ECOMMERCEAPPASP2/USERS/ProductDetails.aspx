<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <form id="form1" runat="server">
   <asp:DataList ID="ProdDet" runat="server">
       
       <ItemTemplate>
            
    <section class="single_product_details_area d-flex align-items-center">
        <!-- Single Product Thumb -->
        <div class="single_product_thumb clearfix">
            <div class="">
                <img src="<%#Eval("P_IMAGE") %>" class="object-fit-md-contain border rounded" alt="">
                
            </div>
        </div>

        <!-- Single Product Description -->
        <div class="single_product_desc clearfix">
            <span>mango</span>
          
                <h2><asp:Label runat="server" ID="Title" Text="HEADER"/></h2>
           
            <p class="product-price"><span class="old-price">$65.00</span> <%#Eval("P_PRICE") %></p>
            <p class="product-desc">Mauris viverra cursus ante laoreet eleifend. Donec vel fringilla ante. Aenean finibus velit id urna vehicula, nec maximus est sollicitudin.</p>

            <!-- Form -->
            <form class="cart-form clearfix" method="post">
                <!-- Select Box -->
                
                <!-- Cart & Favourite Box -->
                <div class="cart-fav-box d-flex align-items-center">
                    <!-- Cart -->
                    <asp:button type="submit" ID="AddCartBt" runat="server" OnClick="AddCart" CommandArgument='<%#Eval("P_ID") %>' name="addtocart" value="5" class="btn essence-btn mr-5" Text="Add to cart" />
                    <button type="submit" name="addtocart" value="5" class="btn essence-btn">Buy Now</button>
                    <!-- Favourite -->
                    <div class="product-favourite ml-4">
                        <a href="#" class="favme fa fa-heart"></a>
                    </div>
                </div>
            </form>
        </div>
        </section>
     
       </ItemTemplate>

   </asp:DataList>
                  </form> 
    </asp:Content>
