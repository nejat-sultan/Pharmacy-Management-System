<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PharmacyManagementSystem.Views.Pharmacist.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <style>
       * {
           font-family: poppins;
       }
</style>

</head>
<body class="bg-success">
   
    <div class="container-fluid">
        <div class="mb-3">

        </div>
        <div class="row mt-5 mb-3">
            <div class="col-md-4"></div>
            <div class="col-md-4 bg-white">
                <h5 class="text-center"> Pharmacy Management system </h5>
                <div class="justify-content-center">
                    <img src="" height="90px"/>
                </div>
                
                <form runat="server">
                  <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Email address</label>
                    <input type="email" class="form-control" id="Email" runat="server" autocomplete="off" aria-describedby="emailHelp">
                    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                  </div>
                  <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Password</label>
                    <input type="password" class="form-control" id="Password" runat="server" autocomplete="off">
                  </div>

                  <div class="d-grid mb-3">
                      <label id="ErrMsg" class="text-danger" runat="server"></label>
                      <a href="../Admin/Login.aspx"> <label> Admin Login</label> </a>
                      <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn btn-success btn-block" OnClick="LoginBtn_Click" />
                    
                  </div>
                </form>
            </div>
            <div class="col-md-4"></div>
        </div>
    </div>
</body>
</html>
