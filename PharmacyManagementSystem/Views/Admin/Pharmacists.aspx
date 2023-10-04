<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Pharmacists.aspx.cs" Inherits="PharmacyManagementSystem.Views.Admin.Pharmacists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #billing .h6,#title {
            color:teal;
           }
 
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row mt-3">

              <label id="userLbl" runat="server"></label>

                <div class="col-md-4" id="billing">

                    <h3 class="mb-3" id="title"> Manage Pharmacists </h3>
                    <div class="row mb-3">
                      <div class="col">
                        <label class="h6"> Pharmacist Name </label>
                        <input type="text" class="form-control" placeholder="Pharmacist Name" runat="server" id="PharmacistName">
                      </div>
                      <div class="col">
                        <label class="h6"> Pharmacist Email </label>
                        <input type="text" class="form-control" placeholder="Pharmacist Email" runat="server" id="PharmacistEmail">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <div class="col">
                        <label class="h6"> Pharmacist Password </label>
                        <input type="text" class="form-control" placeholder="Pharmacist Password" runat="server" id="PharmacistPassword">
                      </div>
                      <div class="col">
                        <label class="h6"> Pharmacist DOB </label>
                        <input type="date" class="form-control" runat="server" id="DOB">
                      </div>
                      
                    </div>

                    <div class="row mb-3">
                      <div class="col">
                          <label class="h6"> Pharmacist Gender </label>
                          <asp:DropDownList runat="server"  class="form-control" placeholder="Gender" id="PharmacistGender">
                              <asp:ListItem Value=""> Select Your Gender </asp:ListItem>
                              <asp:ListItem Value="Male"> Male </asp:ListItem>
                              <asp:ListItem Value="Female"> Female </asp:ListItem>
                          </asp:DropDownList>
             
                      </div>
                      <div class="col">
                        <label class="h6"> Pharmacist Address </label>
                        <input type="text" class="form-control" placeholder="Pharmacist Address" runat="server" id="PharmacistAddress">
                      </div>
                    </div>

                    <div class="row">
                        <label class="text-danger" id="ErrMsg" runat="server"></label>
                      <div class="col d-grid">
                          <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-success btn-block" OnClick="EditBtn_Click"/>
                      </div>
                      <div class="col d-grid">
                          <asp:Button ID="SaveBtn" runat="server" Text="Add" class="btn btn-primary btn-block" OnClick="SaveBtn_Click"/>
                      </div>
                      <div class="col d-grid">
                          <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger btn-block" OnClick="DeleteBtn_Click"/>
                      </div>
                    </div>

                </div>
                
      
            <div class="col-8">
                <h3 class="text-center mb-3" id="title"> Medicines List</h3>
                <asp:GridView ID="PharmacistList" class="table table-success" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="PharmacistList_SelectedIndexChanged"></asp:GridView>
            </div>
        </div>
     </div>
</div>
</asp:Content>
