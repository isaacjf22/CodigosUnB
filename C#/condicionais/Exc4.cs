// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas

namespace Course
{
    public class Exc4
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' '); 
            int horaInicial = int.Parse(v[0]);
            int horaFinal = int.Parse(v[1]); 

            int duracao = horaFinal-horaInicial;

            if (duracao <= 0) //passou o dia 
            {
                duracao+=24;
            }
            System.Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}