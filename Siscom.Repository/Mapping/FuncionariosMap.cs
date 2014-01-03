using FluentNHibernate.Mapping;
using Siscom.Entities;
namespace Siscom.Repository.Mapping
{
    public class FuncionariosMap : ClassMap<Funcionarios>
    {
        public FuncionariosMap()
        {
            Table("cad_funcionarios");

            Id(x => x.id).CustomSqlType("bigserial").GeneratedBy.Identity();

            Map(x => x.nome);
            Map(x => x.senha).Length(500);
            Map(x => x.salario_fixo).Length(15);
            Map(x => x.comissao).Length(15);
            Map(x => x.vendas);
            Map(x => x.administrador);
            Map(x => x.relatorios);
            Map(x => x.acesso_inativo);
            Map(x => x.inativo);
        }
    }
}
