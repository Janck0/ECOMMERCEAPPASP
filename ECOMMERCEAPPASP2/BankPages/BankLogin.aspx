<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankLogin.aspx.cs" Inherits="ECOMMERCEAPPASP2.BankPages.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100" style="background-color: #508bfc;">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card shadow-2-strong" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <h2 class="mb-5">BANK PAGE LOGIN</h2>

            <div data-mdb-input-init class="form-outline mb-4">
              <asp:TextBox runat="server" ID="BnkUsrNm" type="text" class="form-control form-control-lg" placeholder="USERNAME"/>
            </div>

            <div data-mdb-input-init class="form-outline mb-4">
              <asp:TextBox ID="BnkPwd" runat="server" type="password" class="form-control form-control-lg" placeholder="PASSWORD"/>
            </div>

            <!-- Checkbox -->
            <div class="form-check d-flex justify-content-start mb-4">
              <input class="form-check-input" type="checkbox" value="" id="form1Example3" />
              <label class="form-check-label" for="form1Example3"> Remember password </label>
            </div>

            <asp:Button runat="server" ID="BnkLogin" data-mdb-ripple-init class="btn btn-primary btn-lg btn-block" Text="Login" OnClick="BnkLogin_Click"/>
              <br />
              <asp:Label ID="Lbl1" runat="server" class="text-danger" Visible="false" />
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
        </div>
    </form>
</body>
</html>
