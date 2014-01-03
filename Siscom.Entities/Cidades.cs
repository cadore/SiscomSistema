using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscom.Entities
{
    public class Cidades
    {
        public override string ToString()
        {
            return this.cidade;
        }
        public virtual long id { get; set; }

        public virtual string cidade { get; set; }

        public virtual string uf { get; set; }

        public virtual string cod_ibge { get; set; }

        public virtual int area { get; set; }

        public virtual IList<Bairros> bairros { get; set; }

        public virtual IList<Enderecos> enderecos { get; set; }
    }
}
