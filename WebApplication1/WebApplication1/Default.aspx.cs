using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrati_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE"); 
            cookie.Values["nome"] = Nome.Text; 
            cookie.Values["cognome"] = Cognome.Text; 
            cookie.Expires = DateTime.Now.AddDays(10); 

            Response.Cookies.Add(cookie); 

            Response.Redirect("WebForm2");
        }
    }
}