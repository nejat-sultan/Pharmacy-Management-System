using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Pharmacist
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["Email"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            //    userLbl.InnerText = Session["Email"].ToString();
            //    Con = new Models.Functions();

            //}
            Con = new Models.Functions();

            if (!IsPostBack)
            {
                ShowMedicines();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(
                    new DataColumn[6]
                    {
                        new DataColumn("Id"),
                        new DataColumn("Product"),
                        new DataColumn("Price"),
                        new DataColumn("Quantity"),
                        new DataColumn("Total"),
                        new DataColumn("Seller")
                    }
                    );
                ViewState["Bill"] = dt;
                this.BindGrid();
            }
        }

        protected void BindGrid()
        {
            Bill.DataSource = (DataTable)ViewState["Bill"];
            Bill.DataBind();
        }

        private void ShowMedicines()
        {
            string Query = "select MedicineCode as Code, MedicineName as Medicine, MedicinePrice as Price, MedicineStock as Stock from MedicineTbl";
            MedicinesList.DataSource = Con.GetData(Query);
            MedicinesList.DataBind();
        }

        string MedCode;
        int Stock;
        protected void MedicinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MedCode = MedicinesList.SelectedRow.Cells[1].Text;
            MedicineName.Value = MedicinesList.SelectedRow.Cells[2].Text;
            MedicinePrice.Value = MedicinesList.SelectedRow.Cells[3].Text;
            Stock = Convert.ToInt32(MedicinesList.SelectedRow.Cells[4].Text);

        }

        int Seller = Login.PharId;
        private void InsertBill()
        {
            try
            {
                string Query = "insert into BillingTbl values('{0}', {1}, {2})";
                Query = string.Format(Query, BillingDate.Value, Seller, Amount);
                Con.SetData(Query);
                ErrMsg.InnerText = "Bill Inserted!";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
        private void UpdateStock()
        {
            int newQty;
            newQty = Convert.ToInt32(MedicinesList.SelectedRow.Cells[4].Text) - Convert.ToInt32(MedicineQuantity.Value);
            string Query = "Update MedicineTbl set MedicineStock = {0} where MedicineCode = '{1}'";
            Query = string.Format(Query, newQty, MedicinesList.SelectedRow.Cells[1].Text);
            Con.SetData(Query);
            ShowMedicines();
            
        }

        int GrdTotal = 0;
        public static int Amount;
        protected void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (MedicineName.Value == "" || MedicinePrice.Value == "" || MedicineQuantity.Value == "")
            {
                ErrMsg.InnerText = "Missing Information!";
            }
            else
            {
                int Total = Convert.ToInt32(MedicinePrice.Value) * Convert.ToInt32(MedicineQuantity.Value);
                DataTable dt = (DataTable)ViewState["Bill"];
                dt.Rows.Add(Bill.Rows.Count + 1,
                    MedicineName.Value.Trim(),
                    MedicinePrice.Value.Trim(),
                    MedicineQuantity.Value.Trim(),
                    Total,
                    Seller

                    ) ;

                ViewState["Bill"] = dt;
                this.BindGrid();
                UpdateStock();
                ErrMsg.InnerText = "Medicine Added To Bill!";


                GrdTotal = 0;
                
                for ( int i = 0; i <= Bill.Rows.Count-1;i++ )
                {
                    GrdTotal = GrdTotal + Int32.Parse(Bill.Rows[i].Cells[4].Text);

                }
                Amount = GrdTotal;
                GrdTot.InnerText = "Br" + GrdTotal;

                MedicineName.Value = "";
                MedicinePrice.Value = "";
                MedicineQuantity.Value = "";

            }

        }

        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            MedicineName.Value = "";
            MedicinePrice.Value = "";
            MedicineQuantity.Value = "";
        }

        protected void Print_Click(object sender, EventArgs e)
        {
            InsertBill();
        }

    }
}