internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva uma palavra simples para o jogo da forca : ");
        string palavra = Console.ReadLine();
        char[] letras = palavra.ToCharArray();

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"{i} tentativas restantes");
            Console.Write("Chute uma das letras da palavra oculta : ");
            string chute = Console.ReadLine();

            if (chute.ToLower() == palavra.ToLower())
            {
                i = 0;
                Console.WriteLine($"Voce acertou a palavra {palavra}");
            }

            for (int vetor = 0; vetor < letras.Length; vetor++)
            {
                if (letras[vetor].ToString().ToLower() == chute.ToLower())
                {
                    Console.WriteLine($"{vetor + 1}º letra = {letras[vetor]}");
                }
            }
        }
    }
}