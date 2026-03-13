//Fazer um programa para ler dois números inteiros M e N, e depois ler
//uma matriz de M linhas por N colunas contendo números inteiros,
//podendo haver repetições. Em seguida, ler um número inteiro X que
//pertence à matriz. Para cada ocorrência de X, mostrar os valores à
//esquerda, acima, à direita e abaixo de X, quando houver, conforme
//exemplo.

using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class MatrizVizinhos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a linha e coluna da matriz a ser analisada: ");
        string[] v = Console.ReadLine().Split(' ');
        int mLinha = int.Parse(v[0]);
        int nColuna = int.Parse(v[1]);

        int[,] matriz = new int[mLinha, nColuna]; //instanciando a matriz 

        //entrada de valores 


        Console.WriteLine("Entre os elementos da matriz: ");
        for (int i = 0; i < matriz.GetLength(0); i++) // linha 
        {
            for (int j = 0; j < matriz.GetLength(1); j++)//colunas da linha 
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("Qual elemento você quer analisar?");

        int numeroEscolhido = int.Parse(Console.ReadLine());

        
             
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == numeroEscolhido)//melhor fazer logo aq no principal , e não criar uma classe 
                {
                    Console.WriteLine($"Posição {i},{j}");
                    if (j > 0) //condições para o valor estar dentro da matriz 
                    {
                        Console.WriteLine($"Esquerda: {matriz[i,j-1]}");
                    }
                    if (i > 0)
                    {
                        Console.WriteLine($"Cima: {matriz[i-1,j]}");
                    }
                    if (j < nColuna - 1)
                    {
                        Console.WriteLine($"Direita: {matriz[i,j+1]}");
                    }
                    if (i < mLinha - 1)
                    {
                        Console.WriteLine($"Baixo: {matriz[i+1,j]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
