using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscom.Entities
{
    public class Bairros
    {
        public override string ToString()
        {
            return this.bairro;
        }
        public virtual long id { get; protected set; }

        public virtual string bairro { get; set; }

        public virtual Cidades cidade { get; set; }
    }
}
