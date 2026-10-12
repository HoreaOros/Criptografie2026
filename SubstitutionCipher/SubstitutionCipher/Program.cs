namespace SubstitutionCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher c = new CaesarCipher();
            c.PlainText = "ABC";
            Console.WriteLine(c.CiperText);


            MonoalphabeticSubstitution ms = new MonoalphabeticSubstitution();
            ms.PlainText = "ATTACKATDAWN";
            Console.WriteLine(ms.CiperText);
            Console.WriteLine(ms.EncryptionKey);
            
        }
    }
}
