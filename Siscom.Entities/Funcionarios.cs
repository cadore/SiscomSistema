namespace Siscom.Entities
{
    public class Funcionarios
    {
        public virtual long id { get; protected set; }

        public virtual string nome { get; set; }

        public virtual string senha { get; set; }

        public virtual decimal salario_fixo { get; set; }

        public virtual decimal comissao { get; set; }

        public virtual bool vendas { get; set; }

        public virtual bool administrador { get; set; }

        public virtual bool relatorios { get; set; }

        public virtual bool acesso_inativo { get; set; }

        public virtual bool inativo { get; set; }
    }
}
