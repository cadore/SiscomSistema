using FluentNHibernate.Mapping;
using Siscom.Entities;

namespace Siscom.Repository.Mapping
{
    public class ClientesMap : ClassMap<Clientes>
    {
        public ClientesMap()
        {
            Table("cad_clientes");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

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
            Map(x => x.telefone_fixo);
            Map(x => x.telefone_celular);
            Map(x => x.inativo);
            Map(x => x.limite_de_credito).Column("limite_de_credito").Length(15);
            Map(x => x.cep);
            Map(x => x.fornecedor);

            References(x => x.bairro);
            References(x => x.cidade);
            References(x => x.endereco);

        }
    }
}
