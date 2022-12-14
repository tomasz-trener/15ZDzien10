using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Rejestracja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            MembershipCreateStatus p = MembershipCreateStatus.Success;

            Membership.CreateUser(
                CreateUserWizard1.UserName,
                CreateUserWizard1.Password,
                CreateUserWizard1.Email,
                CreateUserWizard1.Question,
                CreateUserWizard1.Answer,
                true,
                out p);
        }

        protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("Logowanie.aspx");
        }
    }
}