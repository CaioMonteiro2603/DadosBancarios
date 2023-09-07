namespace DadosBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosBancarios dados = new DadosBancarios("Carlos Alberto", 39,"465889689-78", 0304, 01012552-9, 12500);
            dados.DepositoBancario(25254);
            dados.ExibirSaldo();
            dados.SaqueBancario(31200);
            dados.ExibirSaldo();

            dados.setNome("Marcos");
            Console.WriteLine(dados.getNome());
        }
    }
}