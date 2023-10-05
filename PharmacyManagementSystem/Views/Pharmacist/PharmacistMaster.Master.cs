using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Pharmacist
{
    public partial class PharmacistMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                userLbl.InnerText = Session["Email"].ToString();

            }

            
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {

            Session["Email"] = null;
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}