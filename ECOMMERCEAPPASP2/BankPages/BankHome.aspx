<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankHome.aspx.cs" Inherits="ECOMMERCEAPPASP2.BankPages.BankHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" />
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title></title>
</head>
<body>
    <div class="navbar navbar-expand-md navbar-dark bg-dark mb-4" role="navigation">
    <a class="navbar-brand" href="#">BANK HOMEPAGE</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarCollapse">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
                <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="" target="_blank">Contact Us</a>
            </li>
        </ul>
    </div>
</div>
<main>
    <form id="form1" runat="server">
        <div>
          <section class=" px-3 py-5" border-radius: .5rem .5rem 0 0;">
     <div class="card" style="border-radius: 15px;">
        <div class="card-body p-5">
          <div class="d-flex">
            <div class="flex-shrink-0">
              <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-profiles/avatar-1.webp"
                alt="Generic placeholder image" class="img-fluid" style="width: 180px; border-radius: 10px;">
            </div>
            <div class="flex-grow-1  mx-1">
              <h5 class="mb-2">
                  <asp:Label ID="Lbl1" runat="server" Text="NAME" /></h5>
              <p class="mb-2 pb-1"><asp:Label ID="Lbl2" runat="server" Text="Acc no" /></p>
              <div class="d-flex justify-content-start rounded-3 p-2 mb-2 bg-body-tertiary">
                <div>
                  <p class="small text-muted mb-1">Payment Reqeusts</p>
                  <p class="mb-0"><asp:Label ID="Lbl3" runat="server" Text="0"/></p>
                </div>
                 
                <div>
                  <p class="small text-strong mb-1">Account Balance</p> 
                  <p class="mb-0"><asp:Label ID="Lbl4" runat="server" Text="0000" /></p>
                </div>
              </div>
              <div class="d-block pt-1">
                <asp:LinkButton ID="PayReq" runat="server"   class="btn btn-outline-primary me-1 btn-2 w-25" OnClick="PayReq_Click">Pay Now</asp:LinkButton>
                <asp:Button ID="ShowHistory" runat="server"   class="btn btn-outline-warning me-1 btn-2 w-25" Text="Show History"/>

                
              </div>
            </div>
          </div>
        </div>
      </div>
</section>
            <section>
                <asp:Panel ID="PayReqPanel" runat="server" Visible="false">

                  <div class="card m-5 p-3">
                        <div class="card-header">
                                PAYMENT REQUESTS
                        </div>
                      <asp:ListView ID="List1" runat="server" DataKeyNames="PAY_ID" >
                          <ItemTemplate>
                              <div class="card-body">
                             <h5 class="card-title">Amount:<%#Eval("Pay_Amt") %></h5>
                             <h6 class="card-title">To:<%#Eval("To_Acc") %></h6>

                            <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                             <asp:LinkButton ID="PayNow" runat="server" OnClick="PayNow" CommandArgument='<%#Eval("PAY_ID") %>' Text="Pay" class="btn btn-primary"/>
                        </div>
                          </ItemTemplate>

                      </asp:ListView>
                         
                        
                    </div>
                </asp:Panel>
            </section>
        </div>
    </form>
</main>
    
</body>
</html>
