using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clases para acceder al disco (buscar, borrar, crear)
using System.IO;
// Clase para dar formato binario
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacionArticulo
{
    public class Auxiliar
    {
        public void Guardar(string ruta, Articulo articulo)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, articulo);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            catch
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public Articulo Cargar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                Articulo art = (Articulo)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                return art;
            }
            catch
            {

                throw;
            }
            finally
            {
                fs.Close();
            }
        }
        
    }
}
