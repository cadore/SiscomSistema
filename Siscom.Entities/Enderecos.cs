using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscom.Entities
{
    public class Enderecos
    {
        public override string ToString()
        {
            return this.endereco;
        }
        public virtual long id { get; protected set; }

        public virtual string cep { get; set; }

        public virtual string endereco { get; set; }

        public virtual Cidades cidade { get; set; }

        public virtual long bairro_id { get; set; }

    }
}
