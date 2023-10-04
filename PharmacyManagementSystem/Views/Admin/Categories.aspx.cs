using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PharmacyManagementSystem.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["AdminEmail"] == null)
            // {
            //     Response.Redirect("Login.aspx");
            // }
            // else
            // {
            //     userLbl.InnerText = Session["AdminEmail"].ToString();
            //     Con = new Models.Functions();

            // } 

            Con = new Models.Functions();

            if (!IsPostBack)
            {
                ShowCategories();
            }
            
        }

        private void ShowCategories()
        {
            string Query = "select CategoryId as Number, CategoryName as [Categories Names] from CategoryTbl";
            CategoryList.DataSource = Con.GetData(Query);
            CategoryList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string CategoryName = CatName.Value;
                    string Query = "Insert into CategoryTbl values('{0}')";
                    Query = string.Format(Query, CategoryName);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.InnerText = "Category Added!";
                    CatName.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

            
        }

        protected void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatName.Value = CategoryList.SelectedRow.Cells[2].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string CategoryName = CatName.Value;
                    string Query = "Update CategoryTbl set CategoryName = '{0}' where CategoryId = '{1}'";
                    Query = string.Format(Query, CategoryName, CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.InnerText = "Category Updated!";
                    CatName.Value = "";
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
                if (CatName.Value == "")
                {
                    ErrMsg.InnerText = "No Data!";
                }
                else
                {
                    string CategoryName = CatName.Value;
                    string Query = "Delete from CategoryTbl where CategoryId = '{0}'";
                    Query = string.Format(Query, CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.InnerText = "Category Deleted!";
                    CatName.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}