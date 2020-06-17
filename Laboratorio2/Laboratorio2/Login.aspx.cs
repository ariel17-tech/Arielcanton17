using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.usuario = usuarioTxt.Text;
            u.clave = ClaveTxt.Text;

            if (u.usuario != "" && u.clave != "")
            {
                Session["usuario"] = u;
                Response.Redirect("Pagina1.aspx");
            }
        }
    }
}