class VerificarIdade
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você não pode dirigir por ser menor de idade.");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else
        {
            Console.WriteLine("Você é um idoso.");
        }
    }
}
