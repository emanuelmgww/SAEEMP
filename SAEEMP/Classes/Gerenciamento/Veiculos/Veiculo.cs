namespace SAEEMP.Veiculo
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public int Identificador { get; set; }
        public string Placa { get; set; }
        public int CapacidadeDePessoas { get; set; }
        public static int TotalVeiculos { get; private set; }

        public Veiculo(string modelo, int capacidadeDePessoas, string placa, int identificador)
        {
            Modelo = modelo;
            CapacidadeDePessoas = capacidadeDePessoas;
            Placa = placa;
            Identificador = identificador;
            TotalVeiculos++;
        }
    }
}