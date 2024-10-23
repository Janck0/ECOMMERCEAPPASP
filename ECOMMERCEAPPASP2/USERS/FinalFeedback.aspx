<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/index.Master" AutoEventWireup="true" CodeBehind="FinalFeedback.aspx.cs" Inherits="ECOMMERCEAPPASP2.USERS.FinalFeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-4 mb-4">
        <div class="row d-flex cart align-items-center justify-content-center">
            <div class="col-md-10">
                <div class="card">
                    <div class="d-flex justify-content-center border-bottom">
                        <div class="p-3">
                        </div>
                    </div>
                    <div class="row g-0">
                        <div class="col-md-6 border-right p-5">
                            <div class="text-center order-details">
                                <div class="d-flex justify-content-center mb-5 flex-column align-items-center"><span class="check1"><i class="fa fa-check"></i></span><span class="font-weight-bold">Order Confirmed</span> <small class="mt-2">Your illustraion will go to you soon</small> <a href="#" class="text-decoration-none invoice-link">View Invoice</a> </div>
                                <button class="btn btn-warning btn-block order-button">Continue Shoping</button>
                                <br />
                                <button class="btn btn-primary btn-block order-button" data-target="#loginmodal" data-toggle="modal">"Give us a feedback:)</button>

                                <div class="container" id="popup">

                                    <div class="row">
                                        <div class="col col-sm-12">
                                            <div class="modal" data-keyboard="false" data-backdrop="static" id="loginmodal" tabindex="-1">
                                                <div class="modal-dialog">
                                                    <div class="modal-content">
                                                        <div class="modal-header">
                                                            <h4 class="modal-title">Feedback:)</h4>
                                                            <button class="close" data-dismiss="modal">&times;</button>
                                                        </div>
                                                        <div class="modal-body">
                                                            <form id="form1" runat="server">
                                                                <div class="form-group">
                                                                    <label for="inputUserName">Name</label>
                                                                    <asp:TextBox ID="NAMEFD" runat="server" class="form-control" />
                                                                </div>

                                                                <div class="form-group">
                                                                    <label for="inputPassword">Feedback</label>
                                                                    <asp:TextBox ID="MSGFD" runat="server" TextMode="MultiLine" class="form-control" />
                                                                </div>
                                                        </div>
                                                        <div class="modal-footer">
                                                            <asp:Button runat="server" class="btn btn-primary" ID="SNDFD" OnClick="SNDFD_Click" Text="SEND" />
                                                            <button class="btn btn-primary" data-dismiss="modal">Close</button>
                                                        </div>
                                                        </form>

                                                    </div>

                                                </div>
                                            </div>

                                        </div>
                                    </div>

                                </div>


                            </div>
                        </div>
                        <div class="col-md-6 background-muted">
                            

                            <div class="px-4 py-5">

                                <h6 class="text">Deliver To:<br /><asp:Label ID="Address" runat="server" /></h6>



                                <h4 class="mt-5 theme-color mb-5">Thanks for your order</h4>

                                <span class="theme-color">Payment Summary</span>
                                <div class="mb-3">
                                    <hr class="new1">
                                </div>
                                <div class="mb-3">
                                    
                                </div>
                               <asp:ListView ID="OrderDet" runat="server">
                                   <ItemTemplate>
                                       <div class="d-flex justify-content-between">
                                        <span class="font-weight-bold"><%#Eval("P_NAME")%> x <%#Eval("O_NOOFITEMS") %></span>
                                        <span class="text-muted">₹<%#Eval("O_TOTALPRICE") %></span>
                                </div>
                                   </ItemTemplate>
                               </asp:ListView>
                                

                                <div class="d-flex justify-content-between">
                                    <small>Shipping</small>
                                    <small>Rs:75.00</small>
                                </div>


                                

                                <div class="d-flex justify-content-between mt-3">
                                    <span class="font-weight-bold">Total</span>
                                    <span class="font-weight-bold theme-color">₹<asp:Label ID="Ttl" runat="server" /></span>
                                </div>



                                <div class="text-center mt-5">


                                    <button class="btn btn-primary">Track your order</button>



                                </div>

                            </div>

                        </div>
                    </div>
                    <div></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
