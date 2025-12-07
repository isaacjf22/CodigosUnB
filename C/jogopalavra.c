#include <stdio.h> 
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>

// Faça um programa que sorteie um número aleatório entre 0 e 500 e pergunte ao usuário
// qual é o "número mágico". O programa deverá indicar se a tentativa efetuada pelo
// usuário é maior ou menor que o número mágico e contar o número de tentativas.
// Quando o usuário conseguir acertar o número o programa deverá classificar o usuário
// como:
// a. De 1 a 3 tentativas: muito sortudo
// b. De 4 a 6 tentativas: sortudo
// c. De 7 a 10 tentativas: normal
// d. > 10 tentativas: tente novamente


int main(){
    int contt=0,num,resp,contr=0,tent=1; 

    srand(time(NULL));

    num=(rand()%501);

    puts(">>PALAVRA MAGICA<<");
    puts(""); 
    do{
        printf("%d tentativa!\n",tent);
        tent++;
        puts("Adivinhe um valor entre 0 a 500: ");
        printf("-->");
        scanf("%d",&resp);
        contt++;
        system("CLS");
        while(resp>500 || resp<1){
            puts("Numero digitado fora dos parametros!");
            puts("Digite um numero dentro -> 0 a 500");
            printf("--> ");
            scanf("%d",&resp);
            system("CLS");        
        }
        if(resp!=num){
            puts("Tentativa errada!");
            if(resp>num){
                puts("O numero escondido esta abaixo");
            }
            else{
                puts("O numero escondido esta acima");
            }
            puts("Aperte qualquer tecla para continuar...");
            getch();
            system("CLS");
        }
    }while(resp!=num);

    puts("VOCE ACERTOU!");
    printf("NUMERO DE TENTATIVAS = %d\n",contt); 
    puts("");
    if(contt<=3){
        puts("VOCE FOI CONSIDERADO MUITO SORTUDO");
    }
    else if(contt<=6){
        puts("VOCE FOI CONSIDERADO SORTUDO");
    }
    else if(contt<=10){
        puts("VOCE FOI CONSIDERADO NORMAL");
    }
    else{
        puts("TENTE NOVAMENTE...");
    }
    return 0;
}
