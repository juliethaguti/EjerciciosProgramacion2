using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassEjercicio_56
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        #region Constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Métodos
        public static void Guardar(Persona p)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream archivo = new FileStream("Persona.bin", FileMode.Create);
            formatter.Serialize(archivo, p);
            archivo.Close();
        }

        public static Persona Leer()
        {
            Persona p;
            IFormatter formatter = new BinaryFormatter();
            Stream archivo = new FileStream("Persona.bin", FileMode.Open);
            p = (Persona)formatter.Deserialize(archivo);
            archivo.Close();
            return p;
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: " + this.nombre);
            sb.AppendLine("APELLLIDO: " + this.apellido);
            return sb.ToString();
        }
        #endregion
    }
}
