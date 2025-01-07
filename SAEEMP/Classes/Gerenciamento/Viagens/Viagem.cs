namespace SAEEMP.Viagem
{
    using SAEEMP.Veiculo;
    using SAEEMP.FuncionarioComVeiculo.Cobrador;
    using SAEEMP.FuncionarioComVeiculo.Motorista;

    public class Viagem
    {
        public int ViagemID { get; set; }
        public string CidadeDePartida { get; set; }
        public string CidadedeChegada { get; set;}
        public decimal Preco { get; set; }
        public int TotalPassageiros { get; set; }
        public Veiculo Veiculo { get; set; }
        public Motorista Motorista { get; set; }
        public Cobrador Cobrador { get; set; }

        public Viagem(int viagem, string cidadeDePartida, string cidadedeChegada, int totalPassageiros,decimal precoPorPassagem, Veiculo veiculo, Cobrador cobrador, Motorista motorista)
        {
            ViagemID = viagem;
            CidadeDePartida = cidadeDePartida;
            CidadedeChegada = cidadedeChegada;
            Veiculo = veiculo;
            Cobrador = cobrador;
            Motorista = motorista;
            Preco = precoPorPassagem;
            TotalPassageiros = totalPassageiros;
        }
    }
}