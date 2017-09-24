using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Operaciones
    {
        //creacion del metodo para escribir caracteres, está hecho de tipo bool
        //para que devuelva valor true en caso de que se realice con exito el metodo
        //y false en caso de que no
        //como parametros se ponen el contenido que va a tener el archivo de texto
        //y el nombre del archivo de texto
        public bool EscribirCaracteres(string contenido,string nombre)
        {
            //se instancia el streamwriter con valor nulo
            StreamWriter sw = null;
            //en el if se verifica que no esten vacios ninguno de los dos campos
            if (!string.IsNullOrEmpty(contenido)||!string.IsNullOrEmpty(nombre))
            {
                try
                {
                    //crea un flujo hacia el archivo de texto
                    //se concatena el nombre que se agrego como parametro en el metodo
                    sw = new StreamWriter(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\"+nombre+".txt");

                    //esxribe la linea leida en el archivo
                    sw.WriteLine(contenido);

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    //se cierra la conexion al archivo
                    if (sw != null) sw.Close();
                }
                return true;
            }else
            {

                return false;
            }        
        }


        //creacion de metodo para eliminar, usando como parametro el nombre del archivo
        public void eliminarArchivo(string nombre) {
            //se verifica si el archivo existe, si es asi elimina el archivo con su 
            //nombre dado en el parametro
            if (File.Exists(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\" + nombre + ".txt"))
            {
                
                try
                {
                    //se elimina
                    File.Delete(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\" + nombre + ".txt");
                    MessageBox.Show("Archivo eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.IO.IOException e)
                {
                    MessageBox.Show(e.Message);
                    
                }
            }else
            {
                MessageBox.Show("Archivo inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //metodo para buscar usando como parametro el nombre
        public string buscar(string nombre) {
            //crear variable string nula, donde se va a guardar el contenido del archivo txt
            string texto = null;
            //verificar si existe el archivo
            if (File.Exists(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\" + nombre + ".txt"))
            {
                //se guarda el contenido en la variable texto, y se devuelve la variable
                //estando vacia o no
                using (StreamReader sr = new StreamReader(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\" + nombre + ".txt"))
                {
                    texto = sr.ReadToEnd();
                }

                return texto;
                
            }
            else
            {
                
                return texto;
            }

        }

        //creacion de metodo para modificar
        public void modificar(string contenido, string nombre)
        {
                StreamWriter sw=null;
            if (!string.IsNullOrEmpty(contenido) || !string.IsNullOrEmpty(nombre))
            {
                try
                {
                    //crea un flujo hacia el archivo de texto
                    //se concatena el nombre que se agrego como parametro en el metodo
                    sw = new StreamWriter(@"C:\Users\Roberto Reyes\Desktop\Textos_RA\" + nombre + ".txt");

                    //esxribe la linea leida en el archivo
                    sw.WriteLine(contenido);
                    MessageBox.Show("Modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    //se cierra la conexion al archivo
                    if (sw != null) sw.Close();
                }

            }else
            {
                MessageBox.Show("No deje espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
