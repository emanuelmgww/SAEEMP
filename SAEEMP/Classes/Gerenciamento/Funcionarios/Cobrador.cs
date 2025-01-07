namespace SAEEMP.FuncionarioComVeiculo.Cobrador
{
    using SAEEMP.FuncionarioComVeiculo;

    public class Cobrador : FuncionarioComVeiculo
    {
        public Cobrador(string nome, string cpf, double salario, string turno, string departamento) : base(nome, cpf, turno, salario, departamento)
        {
            return;
        }
    }
}