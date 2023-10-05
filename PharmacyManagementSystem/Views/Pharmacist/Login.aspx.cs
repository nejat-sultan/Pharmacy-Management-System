using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Pharmacist
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
            {
                Response.Redirect("Billing.aspx");
            }
            else
            {
                Con = new Models.Functions();
            }
            

        }

        public static string PharName, PharEmail;
        public static int PharId;
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                String Query = "select PharmacistId,PharmacistName, PharmacistEmail, PharmacistPassword from PharmacistTbl where PharmacistEmail = '{0}' and PharmacistPassword = '{1}' ";
                Query = string.Format(Query, Email.Value, Password.Value);
                DataTable dt = Con.GetData(Query);
                if(dt.Rows.Count == 0 )
                {
                    ErrMsg.InnerText = "Incorrect data";
                }
                else
                {
                    Session["Email"] = Email.Value;

                    PharId = Convert.ToInt32(dt.Rows[0][0].ToString());
                    PharName = dt.Rows[0][0].ToString();
                    Response.Redirect("Billing.aspx");
                }
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}