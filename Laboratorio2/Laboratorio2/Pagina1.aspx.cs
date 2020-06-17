using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2
{
    public partial class Pagina1 : System.Web.UI.Page
    {

        delegate double Calc(double x);
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["usuario"];

            if (u != null)
            {
                usuarioLabel.Text = u.usuario;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Calc dobla = Calculo.doblar;
                double res = dobla(Int32.Parse(numTxt.Text));
                resTxt.Text = res.ToString();
                Calculo.escribirBitacora(resTxt.Text);
            }
            catch (Exception ex)
            {
                resTxt.Text = "Error!!!";
                
            }
            

        }
    }
}