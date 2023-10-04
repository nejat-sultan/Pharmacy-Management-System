<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Pharmacist/PharmacistMaster.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="PharmacyManagementSystem.Views.Pharmacist.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <script type="text/javascript">
           function PrintBill() {
               var PGrid = document.getElementById('<%=Bill.ClientID%>');
               PGrid.border = 0;
               var PWin = window.open('', 'PrintGrid', 'left=100, width=1024, height=768, tollbar=0, scrollbars=1, status=0, resizable=1');
               PWin.document.write(PGrid.outerHTML);
               PWin.document.close();
               PWin.focus();
               PWin.print();
               PWin.close();
           }
       </script>

    
        <style>
            #billing .h6,#title {
                color:teal;
               }
    
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div class="container-fluid">    
    <div class="row mt-3">
   
            <div class="row">
                <div class="col-md-4" id="billing">

                    <h3 class="mb-3" id="title"> Pharmacy Billing </h3>
                    <div class="row mb-3">
                        <div class="col">
                            <label class="h6"> Medicine Name </label>
                          <input type="text" class="form-control" placeholder="Medicine Name" runat="server" id="MedicineName" autocomplete="off">
                        </div>
                        <div class="col">
                            <label class="h6"> Medicine Price </label>
                            <input type="text" class="form-control" placeholder="Medicine Price" runat="server" id="MedicinePrice" autocomplete="off">
                        </div>
  
                    </div>

                    <div class="row mb-3">
                        <div class="col">
                            <label class="h6"> Medicine Quantity </label>
                          <input type="text" class="form-control" placeholder="Medicine Quantity" runat="server" id="MedicineQuantity" autocomplete="off">
                        </div>
                        <div class="col">
                            <label class="h6"> Billing Date </label>
                            <input type="date" class="form-control" runat="server" id="BillingDate">
                        </div>
  
                    </div>

                    <div class="row">
                        <label class="text-danger text-center" id="ErrMsg" runat="server"></label>
                        <div class="col d-grid">
                            <asp:Button ID="AddToBillBtn" runat="server" Text="Add to Bill" class="btn btn-success btn-block" OnClick="AddToBillBtn_Click" />
                        </div>
                        <div class="col d-grid">
                            <asp:Button ID="ResetBtn" runat="server" Text="Reset" class="btn btn-danger btn-block" OnClick="ResetBtn_Click" />
                        </div>
                    </div>


                    <div class="row">
                        <div class="col">
                            <h3 class="mt-5" id="title"> Medicine List</h3>
                            <asp:GridView ID="MedicinesList" class="table table-success" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="MedicinesList_SelectedIndexChanged"></asp:GridView>
                        </div>
                    </div>

                </div>

                <div class="col-md-8">
                   <h3 class="text-center" id="title"> Customer Bill</h3>
                   <asp:GridView ID="Bill" class="table table-success" runat="server"></asp:GridView>
                    <div class="row">
                        <div class="col-5"></div>
                        <div class="col-6">
                            <label class="h5 text-danger text-center" id="GrdTot" runat="server"></label>
                        </div>

                    </div>
                    
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-6 d-grid">
                            <asp:Button ID="Print" OnClientClick="PrintBill()" runat="server" Text="Print" class="btn btn-success" OnClick="Print_Click" />
                        </div>
                        <div class="col-3"></div>
                    </div>
                </div>

            </div>

      </div>
    </div>
</asp:Content>
