using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("cad_clientes");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Native();

            Map(x => x.nome);
            Map(x => x.tipo_de_documento);
            Map(x => x.documento);
            Map(x => x.ie);
            Map(x => x.isento_ICMS);
            Map(x => x.email_principal);
            Map(x => x.email_secundario);
            Map(x => x.numero);
            Map(x => x.complemento);
            Map(x => x.observacoes);
            Map(x => x.ddd_telefone_fixo);
            Map(x => x.telefone_fixo);
            Map(x => x.ddd_telefone_celular);
            Map(x => x.telefone_celular);
            Map(x => x.inativo);
            Map(x => x.limite_de_credito);

            References(x => x.bairro);
            References(x => x.cidade);
            References(x => x.endereco);

        }
    }
}
