using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siscom.Entities
{
    public class Estados
    {
    public virtual long id { get; protected set; }

    public virtual string uf { get; set; }

    public virtual string estado { get; set; }

    public virtual string cod_ibge { get; set; }
    }
}
