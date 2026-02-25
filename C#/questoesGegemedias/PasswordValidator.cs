namespace Course
{
    public class PasswordValidator
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Crie uma senha! Ela deve ter: ");
            System.Console.WriteLine("- Pelo menos 8 caracteres");
            System.Console.WriteLine("- Pelo menos 1 letra maíuscula e 1 minúscula");
            System.Console.WriteLine("- Pelo menos 1 número");
            System.Console.WriteLine(""); 
            bool senhaValida = false; //vai ser analisado no processo 
            string senhaTentativa = ""; 

            while (senhaValida == false)
            {
                //sempre q errar , vai reiniciar as variaveis  
                bool temMaiusculo = false;
                bool temMinusculo = false;
                bool temNumero = false;
                int caracteres = 0;
                senhaTentativa = Console.ReadLine(); 

                foreach(char letra in senhaTentativa) //analisar se a senha esta correta 
                {
                    if (char.IsLower(letra))
                    {
                        temMinusculo=true;
                    }
                    if (char.IsUpper(letra))
                    {
                        temMaiusculo=true;
                    }
                    if (char.IsNumber(letra))
                    {
                        temNumero=true;
                    }
                    caracteres++;
                }
                if(caracteres<8 || temMaiusculo==false || temMinusculo==false || temNumero == false)//enquanto todos n mudarem suas condições , a ''perna n quebra''
                {
                    System.Console.WriteLine("Senha inválida, tente novamente! Faltou: ");
                    if(caracteres<8) System.Console.WriteLine("- Pelo menos 8 caracteres");
                    if(temMaiusculo==false || temMinusculo==false) System.Console.WriteLine("- Pelo menos 1 letra maíuscula ou 1 minúscula");
                    if(temNumero==false) System.Console.WriteLine("- Pelo menos 1 número");
                }
                else
                {
                    senhaValida = true; 
                }

            }
            System.Console.WriteLine("Senha criada com sucesso!");
        }
    }
}