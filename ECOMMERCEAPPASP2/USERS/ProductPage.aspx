<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <h4 align="center" padding="5px">Showing Results for <asp:Label ID="Label1" runat="server" /> </h4>
    <div class="d-flex justify-content-center row">
        <div class="col-md-10">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
        <ContentTemplate>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <div class="row p-2 bg-white border rounded" >
    <div class="col-md-3 mt-1" onclick="window.location.href = 'ProductDetails.aspx?PID=<%#Eval("P_ID")%>','_blank';"  ><img class="img-fluid img-responsive rounded product-image" style="height:auto" src="<%# Eval("P_IMAGE") %>"></div>
    <div class="col-md-6 mt-1">
        <h5><%#Eval("P_NAME") %></h5>
        <div class="d-flex flex-row">
            <div class="ratings mr-2"><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i></div><span>310</span>
        </div>
        <div class="mt-1 mb-1 spec-1"><span><%# Eval("P_DESCRIPTION")%></span></div>
       
        <p class="text-justify text-truncate para mb-0">There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.<br><br></p>
    </div>
    <div class="align-items-center align-content-center col-md-3 border-left mt-1">
        <div class="d-flex flex-row align-items-center">
            <h4 class="mr-1">₹<%#Eval("P_PRICE") %></h4>
        </div>
        <h6 class="text-success">Free shipping</h6>
        <div class="d-flex flex-column mt-4"><asp:Button ID="BuyNowBt" Class="btn btn-primary btn-sm" runat="server" OnClick="BuyNow" CommandArgument='<%#Eval("P_ID") %>' Text="BUY NOW"  />
                                             <asp:Button ID="AddCartBt" Class="btn btn-outline-primary btn-sm mt-2" runat="server" OnClick="AddCart" CommandArgument='<%#Eval("P_ID") %>' Text="Add to cart" /></div>
    </div>
</div>
                </ItemTemplate>
            </asp:ListView>
            </ContentTemplate>
        </asp:UpdatePanel>

            
        </div>
    </div>
    </form>
</asp:Content>

    

