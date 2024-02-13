using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null) 
            {
                DatiUtente.InnerText = "Nome: " + Request.Cookies["ASPNET_COOKIE"]["Nome"] + " Cognome: " + Request.Cookies["ASPNET_COOKIE"]["Cognome"];
            }
            else
            {
                Response.Redirect("Default");
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE"); 
            cookie.Expires = DateTime.Now.AddDays(-1); 
            Response.Cookies.Add(cookie); 

            Response.Redirect("Default");
        }
    }
}