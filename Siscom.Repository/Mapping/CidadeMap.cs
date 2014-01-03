using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class CidadeMap : ClassMap<Cidades>
    {
        public CidadeMap()
        {
            Table("cad_cidades");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

            Map(x => x.cidade);
            Map(x => x.uf);
            Map(x => x.cod_ibge);
            Map(x => x.area);

            HasMany<Bairros>(x => x.bairros).Cascade.Merge().LazyLoad().KeyColumn("cidade_id"); ;
            HasMany<Enderecos>(x => x.enderecos).Cascade.Merge().LazyLoad().KeyColumn("cidade_id");
        }
    }
}
