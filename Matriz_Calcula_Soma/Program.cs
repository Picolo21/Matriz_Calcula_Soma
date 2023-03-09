internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[6, 7];

        Console.Write("Aperte ENTER para começar a inserir os valores na matriz");
        Console.ReadKey();

        char escolha;
        do
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write($"Digite um valor na posição mat[{i}, {j}] = ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            // Resultado da soma na PRIMEIRA COLUNA
            for (int i = 0; i < 5; i++)
            {
                mat[i, 0] = mat[i, 1] + mat[i, 2] + mat[i, 3] + mat[i, 4] + mat[i, 5];
            }

            // Resultado da soma na ÚLTIMA COLUNA
            for (int i = 0; i < 5; i++)
            {
                mat[i, 6] = mat[i, 1] + mat[i, 2] + mat[i, 3] + mat[i, 4] + mat[i, 5];
            }

            // Resultado da soma na ÚLTIMA LINHA
            for (int j = 1; j < 6; j++)
            {
                mat[5, j] = mat[0, j] + mat[1, j] + mat[2, j] + mat[3, j] + mat[4, j];
            }

            // Diagonal Principal
            mat[5, 6] = mat[0, 1] + mat[1, 2] + mat[2, 3] + mat[3, 4] + mat[4, 5];

            // Diagonal Secundária
            mat[5, 0] = mat[0, 5] + mat[1, 4] + mat[2, 3] + mat[3, 2] + mat[4, 1];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mat[i, j].ToString().PadRight(6) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Deseja preencher uma nova matriz [Y / N]? ");
            escolha = char.Parse(Console.ReadLine());
        } while ((escolha.Equals('y')) || (escolha.Equals('Y')));
        Console.WriteLine();

        Console.WriteLine("Fim do programa!");
    }
}