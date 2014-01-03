using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class EnderecoMap : ClassMap<Enderecos>
    {
        public EnderecoMap()
        {
            Table("cad_enderecos");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

            Map(x => x.cep);
            Map(x => x.endereco);
            Map(x => x.bairro_id);

            References<Cidades>(x => x.cidade).Cascade.Merge().LazyLoad().Column("cidade_id");
        }
    }
}
