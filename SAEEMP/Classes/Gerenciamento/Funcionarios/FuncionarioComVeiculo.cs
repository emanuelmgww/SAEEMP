namespace SAEEMP.FuncionarioComVeiculo
{
    using SAEEMP.Funcionario;
    public abstract class FuncionarioComVeiculo : Funcionario
    {
        public FuncionarioComVeiculo(string nome, string cpf, string turno, double salario, string departamento) : base(nome, cpf, turno, salario, departamento)
        {
             return;
        }
    }
}