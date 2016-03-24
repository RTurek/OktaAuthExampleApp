using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OktaAuthExampleApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
            if (claimsPrincipal != null)
            {
                foreach (Claim claim in claimsPrincipal.Claims)
                {
                    Response.Write("Claim Type: " + claim.Type + "</br>");
                    Response.Write("Claim Value: " + claim.Value + "</br></br></br>");
                    // Look for a specific claim example:                
                    // if (claim.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")
                    // {
                    //     userName = claim.Value;
                    // }
                }
            }
            else
            {
                Response.Write("Error during authentication process.");
            }

        }
    }
}
