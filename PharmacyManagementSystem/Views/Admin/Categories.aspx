<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="PharmacyManagementSystem.Views.Admin.Categories" %>
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

                    <h3 class="mb-3" id="title"> Manage Categories </h3>
                    <div class="row mb-3">
                      <div class="col">
                        <label class="h6"> Category Name </label>
                        <input type="text" class="form-control" autocomplete="off" placeholder="Category Name" id="CatName" runat="server">
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
                <h3 class="text-center mb-3" id="title"> Categories List</h3>
                <asp:GridView ID="CategoryList" class="table table-success" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CategoryList_SelectedIndexChanged"></asp:GridView>
            </div>
        </div>
      </div>
</div>
</asp:Content>
