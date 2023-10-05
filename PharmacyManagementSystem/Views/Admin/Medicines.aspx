<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Medicines.aspx.cs" Inherits="PharmacyManagementSystem.Views.Admin.Medicines" %>
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

                        <h3 class="mb-3" id="title"> Manage Medicines </h3>
                        <div class="row mb-3">
                            <div class="col">
                              <label class="h6"> Medicine Code </label>
                              <input type="text" class="form-control" placeholder="Medicine Code" runat="server" id="MedicineCode" autocomplete="off">
                            </div>
                            <div class="col">
                            <label class="h6"> Medicine Name </label>
                            <input type="text" class="form-control" placeholder="Medicine Name" runat="server" id="MedicineName" autocomplete="off">
                          </div>
                          
                        </div>

                        <div class="row mb-3">
                          <div class="col">
                            <label class="h6"> Medicine Price </label>
                            <input type="text" class="form-control" placeholder="Medicine Price" runat="server" id="MedicinePrice" autocomplete="off">
                          </div>
                          <div class="col">
                            <label class="h6"> Medicine Stock </label>
                            <input type="text" class="form-control" placeholder="Medicine Stock" runat="server" id="MedicineStock" autocomplete="off">
                          </div>
                          
                        </div>

                        <div class="row mb-3">
                          <div class="col">
                            <label class="h6"> Expiry Date </label>
                            <input type="date" class="form-control" runat="server" id="ExpiryDate">
                          </div>
                          <div class="col">
                              <label class="h6"> Medicine Category </label>
                              <asp:DropDownList runat="server"  class="form-control" id="MedicineCategory">
                                 
                              </asp:DropDownList>
                           
                          </div>
                        </div>

                        <div class="row">
                          <label id="ErrMsg" class="text-danger" runat="server"></label>
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
                    <asp:GridView ID="MedicineList" class="table table-success" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="MedicineList_SelectedIndexChanged"></asp:GridView>
                </div>


            </div>
    </div>
</asp:Content>
