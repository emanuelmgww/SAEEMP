namespace SAEEMP.FuncionarioComVeiculo.Motorista
{
    using SAEEMP.FuncionarioComVeiculo;

    public class Motorista : FuncionarioComVeiculo
    {
        public string CNHMotorista { get; set; }
        public Motorista(string nome, string cpf, string CNH, double salario, string turno, string departamento) : base(nome, cpf, turno, salario, departamento)
        {   
            CNHMotorista = CNH;
        }
    }
}