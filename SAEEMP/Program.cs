using SAEEMP.FuncionarioComVeiculo.Motorista;
using SAEEMP.FuncionarioComVeiculo.Cobrador;
using SAEEMP.Veiculo;
using SAEEMP.Viagem;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Veiculo onibus720 = new Veiculo("Mercedes-Benz 0500R", 52, "ABC 1234", 720);

        Cobrador emanuel = new Cobrador("Emanuel", "123.456.789-01", 2000, "noite", "Transporte");

        Motorista maxVerstappen = new Motorista("Max Verstappen", "098.765.432-11","18427502931", 3500, "noite", "Transporte");

        Viagem viagem = new Viagem(1, "Belo Horizonte - MG", "Sao Paulo - SP", 52, 230m, onibus720, emanuel, maxVerstappen);

        string viagemJson = JsonSerializer.Serialize(viagem, new JsonSerializerOptions { WriteIndented = true } );

        Console.WriteLine(viagemJson);

        Console.ReadLine();
    }
}
