using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Laboratorio2
{
    public class Calculo
    {
        public static double doblar(double x)
        {
            return x * 2;
        }

        public static void escribirBitacora(string textoGuardar)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\UIABitacora\bitacoraSistema.txt", true))
            {
                objStrem.WriteLine(textoGuardar);
                objStrem.Flush(); //Guardar en el archivo bitacoraSistema.txt
            }
            //El recurso llamado objStrem en esta linea ya no existe en memoria
        }
    }
}