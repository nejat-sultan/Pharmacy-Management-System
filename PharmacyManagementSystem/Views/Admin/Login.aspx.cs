using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminEmail"] != null)
            {
                Response.Redirect("Medicines.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            if (AdminEmail.Value == "" || AdminPassword.Value == "")
            {
                ErrMsg.InnerText = "No data";
            }
            else if(AdminEmail.Value == "Admin@gmail.com" && AdminPassword.Value == "Password")
            {
                Session["AdminEmail"] = AdminEmail.Value;
                Response.Redirect("Medicines.aspx");
            }
            else
            {
                ErrMsg.InnerText = "Incorrect data";
            }
        }
    }
}

