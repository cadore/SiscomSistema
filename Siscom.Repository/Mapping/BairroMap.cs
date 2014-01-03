using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class BairroMap : ClassMap<Bairros>
    {
        public BairroMap()
        {
            Table("cad_bairros");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

            Map(x => x.bairro);

            References<Cidades>(x => x.cidade).Cascade.Merge().LazyLoad().Column("cidade_id");
        }
    }
}
