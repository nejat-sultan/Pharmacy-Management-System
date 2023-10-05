using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Admin
{
    public partial class Pharmacists : System.Web.UI.Page
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
                ShowPharmacists();
      
            }
        }
        private void ShowPharmacists()
        {
            string Query = "select * from PharmacistTbl";
            PharmacistList.DataSource = Con.GetData(Query);
            PharmacistList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PharmacistName.Value == "" || PharmacistEmail.Value == "" || PharmacistPassword.Value == "" || PharmacistAddress.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string PharName = PharmacistName.Value;
                    string PharEmail = PharmacistEmail.Value;
                    string PharPass = PharmacistPassword.Value;
                    string PharDOB = DOB.Value;
                    string PharGen = PharmacistGender.SelectedItem.Value;
                    string PharAddr = PharmacistAddress.Value;
                    string Query = "Insert into PharmacistTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, PharName, PharEmail, PharPass, PharDOB, PharGen, PharAddr);
                    Con.SetData(Query);
                    ShowPharmacists();
                    ErrMsg.InnerText = "Pharmacist Added!";

                    PharmacistName.Value = "";
                    PharmacistEmail.Value = "";
                    PharmacistPassword.Value = "";
                    DOB.Value = "";
                    PharmacistGender.SelectedIndex = -1;
                    PharmacistAddress.Value = "";
          
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }

        int Key = 0;
        protected void PharmacistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(PharmacistList.SelectedRow.Cells[1].Text);
            PharmacistName.Value = PharmacistList.SelectedRow.Cells[2].Text;
            PharmacistEmail.Value = PharmacistList.SelectedRow.Cells[3].Text;
            PharmacistPassword.Value = PharmacistList.SelectedRow.Cells[4].Text;
            DOB.Value = PharmacistList.SelectedRow.Cells[5].Text;
            PharmacistGender.SelectedValue = PharmacistList.SelectedRow.Cells[6].Text;
            PharmacistAddress.Value = PharmacistList.SelectedRow.Cells[7].Text;

        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PharmacistName.Value == "" || PharmacistEmail.Value == "" || PharmacistPassword.Value == "" || PharmacistAddress.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string PharName = PharmacistName.Value;
                    string PharEmail = PharmacistEmail.Value;
                    string PharPass = PharmacistPassword.Value;
                    string PharDOB = DOB.Value;
                    string PharGen = PharmacistGender.SelectedItem.Value;
                    string PharAddr = PharmacistAddress.Value;
                    string Query = "Update PharmacistTbl set PharmacistName = '{0}', PharmacistEmail = '{1}', PharmacistPassword = '{2}', PharmacistDOB = '{3}', PharmacistGender = '{4}', PharmacistAddress = '{5}' where PharmacistId = '{6}'";
                    Query = string.Format(Query, PharName, PharEmail, PharPass, PharDOB, PharGen, PharAddr, PharmacistList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowPharmacists();
                    ErrMsg.InnerText = "Pharmacist Updated!";

                    PharmacistName.Value = "";
                    PharmacistEmail.Value = "";
                    PharmacistPassword.Value = "";
                    DOB.Value = "";
                    PharmacistGender.SelectedIndex = -1;
                    PharmacistAddress.Value = "";

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
                if (PharmacistName.Value == "" || PharmacistEmail.Value == "" || PharmacistPassword.Value == "" || PharmacistAddress.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string PharName = PharmacistName.Value;
                    string PharEmail = PharmacistEmail.Value;
                    string PharPass = PharmacistPassword.Value;
                    string PharDOB = DOB.Value;
                    string PharGen = PharmacistGender.SelectedItem.Value;
                    string PharAddr = PharmacistAddress.Value;
      
                    string Query = "Delete from PharmacistTbl where PharmacistId = '{0}'";
                    Query = string.Format(Query, PharmacistList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowPharmacists();
                    ErrMsg.InnerText = "Pharmacist Deleted!";
                    PharmacistName.Value = "";
                    PharmacistEmail.Value = "";
                    PharmacistPassword.Value = "";
                    DOB.Value = "";
                    PharmacistGender.SelectedIndex = -1;
                    PharmacistAddress.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
     
    }
    }
}