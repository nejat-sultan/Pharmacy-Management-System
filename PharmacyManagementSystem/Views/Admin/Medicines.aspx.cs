using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Admin
{
    public partial class Medicines : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["AdminEmail"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            //    userLbl.InnerText = Session["AdminEmail"].ToString();
            //    Con = new Models.Functions();

            //}

            Con = new Models.Functions();

            if (!IsPostBack)
                {
                    ShowMedicines();
                    GetCategories();
                }

        }
        private void ShowMedicines()
        {
            string Query = "select * from MedicineTbl";
            MedicineList.DataSource = Con.GetData(Query);
            MedicineList.DataBind();
        }

        private void GetCategories()
        {
            string Query = "select * from CategoryTbl";
            MedicineCategory.DataTextField = Con.GetData(Query).Columns["CategoryName"].ToString();
            MedicineCategory.DataValueField = Con.GetData(Query).Columns["CategoryId"].ToString();
            MedicineCategory.DataSource = Con.GetData(Query);
            MedicineCategory.DataBind();

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MedicineCode.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string MedCode = MedicineCode.Value;
                    string MedName = MedicineName.Value;
                    string MedPrice = MedicinePrice.Value;
                    string MedStock = MedicineStock.Value;
                    string MedDate = ExpiryDate.Value;
                    string MedCategory = MedicineCategory.SelectedValue.ToString();
                    string Query = "Insert into MedicineTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, MedCode, MedName, MedPrice, MedStock, MedDate, MedCategory);
                    Con.SetData(Query);
                    ShowMedicines();
                    ErrMsg.InnerText = "Medicine Added!";
                    MedicineCode.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }


        }

        string Key = "";
        protected void MedicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = MedicineList.SelectedRow.Cells[1].Text;
            MedicineName.Value = MedicineList.SelectedRow.Cells[2].Text;
            MedicinePrice.Value = MedicineList.SelectedRow.Cells[3].Text;
            MedicineStock.Value = MedicineList.SelectedRow.Cells[4].Text;
            ExpiryDate.Value = MedicineList.SelectedRow.Cells[5].Text;
            MedicineCategory.SelectedValue = MedicineList.SelectedRow.Cells[6].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MedicineName.Value == "" || MedicinePrice.Value == "" || MedicineStock.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string MedCode = MedicineCode.Value;
                    string MedName = MedicineName.Value;
                    string MedPrice = MedicinePrice.Value;
                    string MedStock = MedicineStock.Value;
                    string MedDate = ExpiryDate.Value;
                    string MedCategory = MedicineCategory.SelectedValue.ToString();

                    string Query = "Update MedicineTbl set MedicineName = '{0}', MedicinePrice = '{1}', MedicineStock = '{2}', MedicineExpiryDate = '{3}', MedicineCategory = '{4}' where MedicineCode = '{5}'";
                    Query = string.Format(Query, MedName, MedPrice, MedStock, MedDate, MedCategory, MedicineList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowMedicines();
                    ErrMsg.InnerText = "Medicine Updated!";
                    MedicineName.Value = "";
                    MedicinePrice.Value = "";
                    MedicineStock.Value = "";
                    MedicineCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MedicineName.Value == "" || MedicinePrice.Value == "" || MedicineStock.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string MedCode = MedicineCode.Value;
                    string MedName = MedicineName.Value;
                    string MedPrice = MedicinePrice.Value;
                    string MedStock = MedicineStock.Value;
                    string MedDate = ExpiryDate.Value;
                    string MedCategory = MedicineCategory.SelectedValue.ToString();

                    string Query = "Delete from MedicineTbl where MedicineCode = '{0}'";
                    Query = string.Format(Query, MedicineList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowMedicines();
                    ErrMsg.InnerText = "Medicine Deleted!";
                    MedicineName.Value = "";
                    MedicinePrice.Value = "";
                    MedicineStock.Value = "";
                    MedicineCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}