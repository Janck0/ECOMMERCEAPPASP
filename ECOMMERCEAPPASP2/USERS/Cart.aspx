<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
        <ContentTemplate>
    <section class="h-100">
        <!-- Font Awesome -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet"/>

<link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet"/>
<!-- MDB -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/7.3.2/mdb.min.css" rel="stylesheet"/>
  <div class="container h-100 py-5">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-10">

        <div class="d-flex justify-content-between align-items-center mb-4">
          <h3 class="fw-normal mb-0">Shopping Cart</h3>
          <div>
            <p class="mb-0"><span class="text-muted">Sort by:</span> <a href="#!" class="text-body">price <i
                  class="fas fa-angle-down mt-1"></i></a></p>
          </div>
        </div>
       </div>
       

       <%-- Populate thing--%>
        
        <asp:ListView ID="CartList" runat="server" DataKeyNames="C_ID" OnItemUpdating="CartList_ItemUpdating" >
        <ItemTemplate>
        <div class="card rounded-3 mb-4">
          <div class="card-body p-4">
            <div class="row d-flex justify-content-between align-items-center">
              <div class="col-md-2 col-lg-2 col-xl-2">
                <img
                  src="<%#Eval("P_IMAGE") %>"
                  class="img-fluid rounded-3" alt="Cotton T-shirt" style="width: 125px;">
              </div>
              <div class="col-md-3 col-lg-3 col-xl-3">
                <p class="lead fw-normal mb-2"><%#Eval("P_NAME") %></p>
                
              </div>
              <div class="col-md-3 col-lg-3 col-xl-2 d-flex">
                  <button data-mdb-button-init data-mdb-ripple-init class="btn btn-link px-2"
                  onclick="">
                  <i class="fas fa-minus"></i>
                </button>
               
                <asp:TextBox ID="Txt1" runat="server" min="0" name="Txt1" Text='<%#Eval("COUNT") %>' onkeyup="submitValue(this)" type="number"
                  class="form-control form-control-sm" />
                  <asp:Button ID="Btn1" runat="server" Text="Submit" CommandName="Update" style="display:none" />
                  <script type="text/javascript">
                    function submitValue(textBox) {
                        var button = textBox.parentElement.querySelector('input[type="submit"]');
                        button.click();
                     }
                  </script>
                  <asp:Label ID="Cid" runat="server"  Text='<%#Eval("C_ID") %>' style="display:none"/>
                <button data-mdb-button-init data-mdb-ripple-init class="btn btn-link px-2"
                  onclick="PlusItem" CommandArgument="<%#Eval("C_ID") %>">
                  <i class="fas fa-plus"></i>
                </button>

              </div>
              <div class="col-md-3 col-lg-2 col-xl-2 offset-lg-1">
                <h5 class="mb-0">₹<%#Eval("P_PRICE") %></h5>
              </div>
              <div class="col-md-1 col-lg-1 col-xl-1 text-end">
                <asp:LinkButton ID="Delete" runat="server" OnClick="DeleteCart" CommandArgument='<%#Eval("C_ID") %>' Class="text-danger" Text="<i class='fas fa-trash fa-lg'></i>"/></i>
              </div>
            </div>
          </div>
        </div>
            </ItemTemplate>
            </asp:ListView>
           
        <%-- Populate thing end--%>
       

        <div class="card mb-4">
          <div class="card cart-md-12">
          <div class="card-body">
           Total:<asp:Label ID="Total" runat="server" Text="000" />
          </div>
        </div>

        <div class="card card-md-12">
          <div class="card-body">
            <button  type="button"  class="btn btn-primary btn-block btn-lg"><a href="CheckOut.aspx" style="color:white" target="_blank">Proceed to Pay</a></button>
          </div>
        </div>
        <div class="card">
          <div class="card-body">
            <button  type="button" class="btn btn-warning btn-block btn-lg"><a href="UserHome.aspx" style="color:white">Continue to Shop</a></button>
          </div>
        </div>

      </div>
    </div>
  </div>
    </section>
         </ContentTemplate>
        </asp:UpdatePanel>
</form>
</asp:Content>

