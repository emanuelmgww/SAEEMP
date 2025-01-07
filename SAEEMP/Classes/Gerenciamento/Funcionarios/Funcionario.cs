namespace SAEEMP.Funcionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Turno { get; set; }
        public double Salario { get; set; }
        public string Departamento { get; set; }


        public Funcionario(string nome, string cpf, string turno, double salario, string departamento)
        {
            Nome = nome;
            Salario = salario;
            Turno = turno;
            CPF = cpf;
            Departamento = departamento;
        }
    }
}
