<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.CheckOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form2" runat="server">
    <div class="checkout_area section-padding-80">
        <div class="container">
            <div class="row">

                <div class="col-12 col-md-6">
                    <div class="checkout_details_area mt-50 clearfix">

                        <div class="cart-page-heading mb-30">
                            <h5>Billing Address</h5>
                        </div>

                            <div class="row">
                                <div class="col-md-12 mb-3">
                                    <label for="first_name">First Name <span>*</span></label>
                                    <asp:textbox ID="fName" runat="server" Type="text" class="form-control" value="" required/>
                                </div>
                                
                                
                                <div class="col-12 mb-3">
                                    <label for="street_address">Address <span>*</span></label>
                                    <asp:textbox ID="StreetAddress" runat="server" Type="text" class="form-control" value="" required/>
                                   
                                </div>
                                <div class="col-12 mb-3">
                                    <label for="postcode">Postcode <span>*</span></label>
                                    <asp:textbox ID="PostCode" runat="server" Type="text" class="form-control" value="" required/>
                                </div>
                                <div class="col-12 mb-3">
                                    <label for="city">Town/District <span>*</span></label>
                                    <asp:textbox ID="District" runat="server" Type="text" class="form-control" value="" required/>
                                </div>
                                <div class="col-12 mb-3">
                                    <label for="state">State <span>*</span></label>
                                    <asp:textbox ID="State" runat="server" Type="text" class="form-control" value="" required/>
                                </div>
                                <div class="col-12 mb-3">
                                    <label for="phone_number">Phone No <span>*</span></label>
                                    <asp:textbox ID="PhoneNo" runat="server" Type="number" class="form-control" value="" required/>
                                </div>
                                <div class="col-12 mb-4">
                                    <label for="email_address">Email Address <span>*</span></label>
                                    <asp:textbox ID="Email" runat="server" Type="text" class="form-control" value="" required/>
                                </div>

                                <div class="col-12">
                                    <div class="custom-control custom-checkbox d-block mb-2">
                                        <input type="checkbox" class="custom-control-input" id="customCheck1">
                                        <label class="custom-control-label" for="customCheck1">Terms and conitions</label>
                                    </div>
                                    <div class="custom-control custom-checkbox d-block mb-2">
                                        <input type="checkbox" class="custom-control-input" id="customCheck2">
                                        <label class="custom-control-label" for="customCheck2">Create an accout</label>
                                    </div>
                                    <div class="custom-control custom-checkbox d-block">
                                        <input type="checkbox" class="custom-control-input" id="customCheck3">
                                        <label class="custom-control-label" for="customCheck3">Subscribe to our newsletter</label>
                                    </div>
                                </div>
                            </div>
                       
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-5 ml-lg-auto">
                    <div class="order-details-confirmation">

                        <div class="cart-page-heading">
                            <h5>Your Order</h5>
                            <p>The Details</p>
                        </div>

                        <ul class="order-details-form mb-4">
                            <li><span>Product</span> <span>Total</span></li>
                            <asp:ListView runat="server" ID="CheckOutList">
                                <ItemTemplate>
                                    <li><span><%#Eval("P_NAME") %> X <%#Eval("COUNT") %></span> <span>₹<%#Eval("SUB_TOTAL") %></span></li>
                                    
                                </ItemTemplate>
                            </asp:ListView>
                            <li><span>Subtotal</span> <span>₹<asp:Label ID="ChkLbl" runat="server" Text="00"/></span></li>
                            <li><span>Shipping</span> <span>Free</span></li>
                            <li><span>Total</span> <span>₹<asp:Label ID="TotalAmt" runat="server" Text="000" /></span></li>
                        </ul>

                        <div id="accordion" role="tablist" class="mb-4">
                            <div class="card">
                                <div class="card-header" role="tab" id="headingOne">
                                    <h6 class="mb-0">
                                        <a data-toggle="collapse" href="#collapseOne" aria-expanded="false" aria-controls="collapseOne"><i class="fa fa-circle-o mr-3"></i>Upi</a>
                                    </h6>
                                </div>

                                <div id="collapseOne" class="collapse" role="tabpanel" aria-labelledby="headingOne" data-parent="#accordion">
                                    <div class="card-body">
                                       <asp:Button ID="UpiButton" runat="server" Text="Pay Using Upi" Class="btn btn-danger" />
                                        <asp:Panel ID="UpiPanel" runat="server" Visible="false">
                                            <div class="form-group">
                                             <asp:TextBox ID="UpiID" runat="server" class="form-control " />
                                            <asp:Button ID="Pay" runat="server" Class="btn btn-primary" Text="Pay"/>
                                            <asp:Button ID="CancelUpi" runat="server" Class="btn btn-danger" Text="Cancel" />
                                            </div>
                                        </asp:Panel>
                                    </div> 
                                </div>
                            </div>
                            <div class="card">
                                <div class="card-header" role="tab" id="headingTwo">
                                    <h6 class="mb-0">
                                        <a class="collapsed" data-toggle="collapse" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo"><i class="fa fa-circle-o mr-3"></i>cash on delievery</a>
                                    </h6>
                                </div>
                                <div id="collapseTwo" class="collapse" role="tabpanel" aria-labelledby="headingTwo" data-parent="#accordion">
                                    <div class="card-body">
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo quis in veritatis officia inventore, tempore provident dignissimos.</p>
                                    </div>
                                </div>
                            </div>
                            <div class="card">
                                <div class="card-header" role="tab" id="headingThree">
                                    <h6 class="mb-0">
                                        <a class="collapsed" data-toggle="collapse" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree"><i class="fa fa-circle-o mr-3"></i>credit card</a>
                                    </h6>
                                </div>
                                <div id="collapseThree" class="collapse" role="tabpanel" aria-labelledby="headingThree" data-parent="#accordion">
                                    <%--<div class="card-body">
                                        <div class="form-group"> <label for="username">
                                        <h6>Card Owner</h6>
                                    </label> <asp:TextBox ID="Crd1" runat="server" type="text" name="username" placeholder="Card Owner Name" required class="form-control "/> </div>
                                <div class="form-group"> <label for="cardNumber">
                                        <h6>Card number</h6>
                                    </label>
                                    <div class="input-group"> <asp:TextBox runat="server" ID="Crd2" type="text" name="cardNumber" placeholder="Valid card number" class="form-control " required/>
                                        <div class="input-group-append"> <span class="input-group-text text-muted"> <i class="fab fa-cc-visa mx-1"></i> <i class="fab fa-cc-mastercard mx-1"></i> <i class="fab fa-cc-amex mx-1"></i> </span> </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-8">
                                        <div class="form-group"> <label><span class="hidden-xs">
                                                    <h6>Expiration Date</h6>
                                                </span></label>
                                            <div class="input-group"> <asp:TextBox runat="server" ID="crd3" type="number" placeholder="MM" name="" class="form-control" required/> <asp:TextBox runat="server" ID="crd4" type="number" placeholder="YY" name="" class="form-control" required/> </div>
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group mb-4"> <label data-toggle="tooltip" title="Three digit CV code on the back of your card">
                                                <h6>CVV <i class="fa fa-question-circle d-inline"></i></h6>
                                            </label> <asp:TextBox ID="Crd5" runat="server" type="text" required class="form-control"/> </div>
                                    </div>
                                </div>
                                <div class="card-footer"> <asp:Button ID="CARDPAYM" runat="server" Text="Confirm Payment" type="button" class="subscribe btn btn-primary btn-block shadow-sm"> </asp:Button>
                                    </div>
                                </div>--%>
                            </div>
                            <div class="card">
                                <div class="card-header" role="tab" id="headingFour">
                                    <h6 class="mb-0">
                                        <a class="collapsed" data-toggle="collapse" href="#collapseFour" aria-expanded="true" aria-controls="collapseFour"><i class="fa fa-circle-o mr-3"></i>direct bank transfer</a>
                                    </h6>
                                </div>
                                <div id="collapseFour" class="collapse" role="tabpanel" aria-labelledby="headingThree" data-parent="#accordion">
                                    <div class="card-body">
                                        <asp:TextBox ID="BankID" runat="server" class="form-control" placeholder="Enter Your BankID"/>
                                         <br />
                                        <asp:Button ID="PayBank" runat="server" Text="Pay 0000" Class="btn btn-danger" OnClick="PayBank_Click" OnClientClick="target ='_blank';"/>
                                     </div>
                                </div>
                            </div>
                        </div>
                            <asp:Button runat="server" ID="PlaceOrdr" Text="Confirm Order" Class="btn essence-btn" OnClick="PlaceOrdr_Click" Enabled="false"/>
                            <br /><asp:Label ID="PyChk" runat="server" Text="Payment not done" class="text-danger"/>
                    </div>
                </div>
            </div>
        </div>
    </div> 

     </form>
    <!-- ##### Checkout Area End ##### -->

    <!-- ##### Footer Area Start ##### -->
    
    <!-- ##### Footer Area End ##### -->

    <!-- jQuery (Necessary for All JavaScript Plugins) -->
    <script src="js/jquery/jquery-2.2.4.min.js"></script>
    <!-- Popper js -->
    <script src="js/popper.min.js"></script>
    <!-- Bootstrap js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Plugins js -->
    <script src="js/plugins.js"></script>
    <!-- Classy Nav js -->
    <script src="js/classy-nav.min.js"></script>
    <!-- Active js -->
    <script src="js/active.js"></script>

</body>

</html>

</asp:Content>
