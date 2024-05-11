internal class Program
{
    enum Nivel
    {
        Ferro, Bronze, Prata, Ouro, Diamante, Lendário, Imortal
    }
    private static void Main(string[] args)
    {
        string nivel = "";
        int numeroDeDerrotas;
        int numeroDeVitorias;
        int saldoVitorias;
        bool isNumber;

        static int CalcularSaldoVitorias(int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }

        Console.WriteLine("Digite o número de vitórias do Herói:");
        do
        {
            isNumber = int.TryParse(Console.ReadLine(), out numeroDeVitorias);
            if (isNumber == false)
                Console.WriteLine("Digite um valor numérico para o número de vitórias do Herói:");
        } while (isNumber == false);

        Console.WriteLine("Digite o número de derrotas do Herói:");
        do
        {
            isNumber = int.TryParse(Console.ReadLine(), out numeroDeDerrotas);
            if (isNumber == false)
                Console.WriteLine("Digite um valor numérico para o número de derrotas do Herói:");
        } while (isNumber == false);

        saldoVitorias = CalcularSaldoVitorias(numeroDeVitorias, numeroDeDerrotas);

        if (saldoVitorias <= 10) nivel = Nivel.Ferro.ToString();
        if (saldoVitorias >= 11 && saldoVitorias <= 20) nivel = Nivel.Bronze.ToString();
        if (saldoVitorias >= 21 && saldoVitorias <= 50) nivel = Nivel.Prata.ToString();
        if (saldoVitorias >= 51 && saldoVitorias <= 80) nivel = Nivel.Ouro.ToString();
        if (saldoVitorias >= 81 && saldoVitorias <= 90) nivel = Nivel.Diamante.ToString();
        if (saldoVitorias >= 91 && saldoVitorias <= 100) nivel = Nivel.Lendário.ToString();
        if (saldoVitorias >= 101) nivel = Nivel.Imortal.ToString();

        Console.WriteLine($"O Herói tem saldo de {saldoVitorias} vitórias e está no nível de {nivel}");
    }
}