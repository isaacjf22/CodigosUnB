//Fazer um programa para ler um número inteiro N e uma matriz de
//ordem N contendo números inteiros. Em seguida, mostrar a diagonal
//principal e a quantidade de valores negativos da matriz.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é a ordem da sua matriz?");
        int ordemMatriz = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] matriz = new int[ordemMatriz, ordemMatriz]; //instanciando a matriz 

        string diagonalPrincipal = "";
        int negativos = 0;

        for(int i = 0; i < matriz.GetLength(0); i++)//percorrendo a linha , 'ponto referencia' 
        {
            for(int j=0;j<matriz.GetLength(1); j++)//percorrendo as colunas da linha , 'ponto varredura'
            {
                Console.WriteLine($"Digite o valor do elemento da linha {i+1} e coluna {j+1}");
                matriz[i,j] = int.Parse(Console.ReadLine());
                if (i == j) //se estiver nessa posição de linha = coluna 
                {
                    diagonalPrincipal += matriz[i, j] + ", "; //precisa acumular , para juntar todos os resultados
                }
                if(matriz[i, j] < 0) //se for negativo , é contalizado 
                {
                    negativos++;
                }
            }
        }

        Console.WriteLine("Diagonal principal: ");
        Console.WriteLine(diagonalPrincipal);
        Console.WriteLine($"Quantidade de números negativos: {negativos}");



    }
}