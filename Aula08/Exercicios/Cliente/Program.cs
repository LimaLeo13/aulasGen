namespace Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Leo", 21, "000000000-00", "Masculino", "1,80");
            Cliente c2 = new Cliente("Julia", 21, "000000000-00", "Feminino", "1,59");
            c1.visualizar();

            c1.SetNome("Leonardo Lima");
            c1.SetIdade(25);
            c1.SetCpf("000000000");
            c1.SetGenero("Masculino");
            c1.SetAltura("1,80");

            c1.visualizar();

            c2.SetNome("Julia");
            c2.SetIdade(21);
            c2.SetCpf("000000000");
            c2.SetGenero("Feminino");
            c2.SetAltura("1,59");

            c2.visualizar();

        }  
    }
}