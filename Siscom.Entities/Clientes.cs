namespace Siscom.Entities
{
    public class Clientes
    {
        public virtual long id { get; protected set; }

        public virtual string nome { get; set; }

        public virtual string tipo_de_documento { get; set; }

        public virtual string documento { get; set; }

        public virtual string ie { get; set; }

        public virtual bool isento_ICMS { get; set; }

        public virtual string email_principal { get; set; }

        public virtual string email_secundario { get; set; }

        public virtual Enderecos endereco { get; set; }

        public virtual string numero { get; set; }

        public virtual string complemento { get; set; }

        public virtual string cep { get; set; }

        public virtual Bairros bairro { get; set; }

        public virtual Cidades cidade { get; set; }

        public virtual string observacoes { get; set; }

        public virtual string telefone_fixo { get; set; }

        public virtual string telefone_celular { get; set; }

        public virtual bool inativo { get; set; }

        public virtual decimal limite_de_credito { get; set; }

        public virtual bool fornecedor { get; set; }
    }
}
