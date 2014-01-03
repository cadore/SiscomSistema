using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class EstadoMap : ClassMap<Estados>
    {
        public EstadoMap()
        {
            Table("cad_estados");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

            Map(x => x.uf);
            Map(x => x.estado);
            Map(x => x.cod_ibge);
        }
    }
}
