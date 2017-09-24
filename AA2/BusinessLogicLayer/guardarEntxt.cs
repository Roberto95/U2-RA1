using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class guardarEntxt
    {
        public bool escribirCaracteres(string us,string pass) {
            StreamWriter sw = null;
            if (!string.IsNullOrEmpty(us) && !string.IsNullOrEmpty(pass))
            {

                //crea un flujo hacia el archivo datos.txt
                //con el true, el archivo ya no se destruye
                sw = new StreamWriter(@"C:\Users\Roberto Reyes\Desktop\Datos.txt", true);

                string UsPass = "Usuario: " + us + ", Contraseña: " + pass + ". Fecha de registro: " + DateTime.Now.ToString();

                //escribe la linea leida en el archivo
                sw.WriteLine(UsPass);
                if (sw != null) sw.Close();

                return true;
            }
            else {
                return false;
            }
        }

        public string leerCaracteres() {

            
            string line;
            
           
            using (StreamReader sr = new StreamReader(@"C:\Users\Roberto Reyes\Desktop\Datos.txt"))
            {
                //ingresar en variable line lo que se lea en el archivo
                line = sr.ReadToEnd();
                
            }

          
            return line;
            
        }
    }
}
