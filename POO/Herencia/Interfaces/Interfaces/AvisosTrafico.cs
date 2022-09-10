using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class AvisosTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion Cometida. Pague antes de 3 dias y se beneficiara de una reduccion en la sancion del 50%";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje : {0} ha sido enviado por: {1} con fecha: {2}", mensaje, remitente, fecha);
        }


    }
}
