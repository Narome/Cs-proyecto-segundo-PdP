using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    internal class Clientes
    {
        private int idCliente;
        private string nombreCli;
        private string apellidoCli;
        private string emailCli;
        private string telefonoCli;

        public Clientes()
        {
        }

        public Clientes(int idCliente, string nombreCli, string apellidoCli, string emailCli, string telefonoCli)
        {
            this.idCliente = idCliente;
            this.nombreCli = nombreCli;
            this.apellidoCli = apellidoCli;
            this.emailCli = emailCli;
            this.telefonoCli = telefonoCli;
        }

        private int getidCliente()
        {
            return idCliente;
        }
        private string getnombreCli()
        {
            return nombreCli;
        }
        private string getapellidoCli()
        {
            return apellidoCli;
        }
        private string getemailCli()
        {
            return emailCli;
        }
        private string gettelefonoCli()
        {
            return telefonoCli;
        }

        private void setidCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
        private void setnombreCli(string nombreCli)
        {
            this.nombreCli = nombreCli;
        }
        private void setapellidoCli(string apellidoCli)
        {
            this.apellidoCli = apellidoCli;
        }

        private void setemailCli(string emailCli)
        {
            this.emailCli = emailCli;
        }
        private void settelefonoCli(string telefonoCli)
        {
            this.telefonoCli = telefonoCli;
        }
    }
}
