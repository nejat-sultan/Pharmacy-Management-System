<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PharmacyManagementSystem.Views.Admin.Login" %>

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
<body class="bg-white" style="background-image:url(https://th.bing.com/th/id/R.68faeeae9fc55fcf7572d3761e14d01e?rik=cvMD6LS4vSrpEA&pid=ImgRaw&r=0); background-repeat:no-repeat;background-size:auto;">
   
    <div class="container-fluid">
        <div class="mb-3">

        </div>
        <div class="row mt-5 mb-3">
            <div class="col-md-4"></div>
            <div class="col-md-4" style="border:2px solid teal;border-radius:10px;background-color:teal;">
                
                <div class="justify-content-center text-center mt-3">
                    <h2 class="bold text-white">Admin Login</h2>
                    <img src="https://th.bing.com/th/id/R.b8d4e2106aa859f34154362f84e59818?rik=kpDwoDaLm7lRZw&pid=ImgRaw&r=0" height="40px"/>
                </div>
                <h5 class="text-center text-white"> Pharmacy Management system </h5>
                
                <form runat="server" class="text-white">
                  <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Email address</label>
                    <input type="email" class="form-control" autocomplete="off" runat="server" id="AdminEmail">
                    <div id="emailHelp" class="form-text text-white">We'll never share your email with anyone else.</div>
                  </div>
                  <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Password</label>
                    <input type="password" class="form-control" autocomplete="off" runat="server" id="AdminPassword">
                  </div>

                  <div class="d-grid mb-3">
                      <label id="ErrMsg" class="text-danger" runat="server"></label>
                     
                      <asp:Button ID="LoginBtn" runat="server" Text="Login" class="mt-3 mb-3 btn btn-light btn-block" OnClick="LoginBtn_Click" />
                    
                  </div>
                </form>
            </div>
            <div class="col-md-4"></div>
        </div>
    </div>
</body>
</html>
