using System.IO;
using System.Globalization;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            bool escolha = false;
            string caminhoArquivoEscolhido;
            string caminhoPasta;
            string[] linhasArquivoEscolhido = { };
            do
            {
                Console.Clear(); //limpeza da tela 
                Console.Write("Caminho da pasta a ser analisada: ");
                caminhoPasta = Console.ReadLine();
                bool ehPasta = Directory.Exists(caminhoPasta); //verificando se existe uma pasta no caminho digitado 

                if (ehPasta)
                {       
                    string[] arquivos = Directory.GetFiles(caminhoPasta);
                    Console.WriteLine($"Arquivos presentes na pasta {Path.GetDirectoryName(caminhoPasta)}");
                    foreach (string arquivo in arquivos)
                    {
                        Console.WriteLine($"- {Path.GetFileName(arquivo)}");
                    }
                    Console.WriteLine();
                    Console.Write("Qual deseja arquivo escolher para realizar a análise (csv/txt): ");
                    string arquivoEscolhido = Console.ReadLine();
                    string extensao = Path.GetExtension(arquivoEscolhido);
                    caminhoArquivoEscolhido = Path.Combine(caminhoPasta, arquivoEscolhido);
                    bool existeArquivo = File.Exists(caminhoArquivoEscolhido);

                    if(!existeArquivo || (extensao != ".txt" && extensao != ".csv" && extensao!=".TXT" && extensao!=".CSV")){
                        Console.WriteLine("Arquivo escolhido inválido.");
                        Pausar();
                    }
                    else
                    {
                        linhasArquivoEscolhido = File.ReadAllLines(caminhoArquivoEscolhido);
                        escolha = true;
                    }
                }
                else
                {
                    Console.WriteLine("O caminho de pasta está inválido");
                    Pausar();
                }

            } while (!escolha);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Criando pasta de saída...");
            Thread.Sleep(2000);
            string pastaSaida = Path.Combine(caminhoPasta, "out");
            Directory.CreateDirectory(pastaSaida); //criandoa  a pasta a
            Console.WriteLine("Criando o arquivo da análise...");
            Thread.Sleep(2000);
            string caminhoDoArquivoFinal = Path.Combine(pastaSaida, "summary.txt");

            using(StreamWriter sw = File.AppendText(caminhoDoArquivoFinal)) //caso n tenha nada, vai ser criado e vai realizar a escrita
            {
                foreach(string linha in linhasArquivoEscolhido)
                {
                    string[] partes = linha.Split(',');
                    string nome = partes[0];
                    double valor = double.Parse(partes[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(partes[2]);

                    double total = valor * quantidade;

                    sw.Write($"{nome} - Total de mercadoria: R${total.ToString("F2")}\n");
                }
            }
            Console.WriteLine("Arquivo escrito com sucesso!");

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: " + e.Message);
        }
    }


    static void Pausar()
    {
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey(true);
    }





}