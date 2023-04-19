using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingGama.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public Cliente(string userId)
        {
            this.id = userId;
        }

        private string id;
        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
