#include <stdio.h>
#include <stdlib.h> 

// Escreva um programa que transforme o computador em
// uma urna eletrônica para eleição do melhor jogador de
// futebol de todos os tempos. O número 25 é do candidato
// Pelé e o 33 do candidato Maradona. Cada voto será
// efetivado pelo número do candidato, permitindo-se ainda
// o voto 00 (em branco) e qualquer outro voto diferente dos
// especificados será considerado nulo.
// O eleitor deverá sempre ser consultado quanto a
// confirmação do voto. Ao final da eleição deverá ser
// apresentado um relatório contendo a votação de cada
// candidato, a quantidade de votos em branco e nulos, além
// do candidato vencedor.

int main(){
    int pel=0,mar=0,br=0,nulo=0,vot=1,esc,conf;
    char resp,resp2;

    do{ //loop da votações 

        do{ //loop do eleitor ate ele ter ctz ou dar nulo
            conf=0;
            system("CLS");
            puts(">>VOTACAO DO GOAT DO FUTEBOL<<");
            puts("");
            printf("Votacao do %d eleitor, quem voce ira votar?\n",vot);
            puts("PELE - 25 / MARADONA - 33 / BRANCO - 00 ");
            scanf("%d",&esc);
            
            switch(esc){
                case 25:    puts("Voce esta votando em PELE, deseja confirmar? S-Sim ou N-nao");
                            scanf(" %c",&resp);
                            if(resp=='S' || resp=='s'){
                                pel=pel+1;
                                conf=1;
                            }
                break;

                case 33:    puts("Voce esta votando em MARADONA, deseja confirmar? S-Sim ou N-nao");
                            scanf(" %c",&resp);
                            if(resp=='S' || resp=='s'){
                                mar=mar+1;
                                conf=1;
                            }
                break;

                case 00:    puts("Voce esta votando em BRANCO, deseja confirmar? S-Sim ou N-nao");
                            scanf(" %c",&resp);
                            if(resp=='S' || resp=='s'){
                                br=br+1;
                                conf=1;
                            }
                break;
            
                default:    puts("Voce votou em nada!");
                            nulo++; 
                            puts("Digite qualquer tecla para continuar...");
                            getch(); 
            }
        }while(conf==0);

        puts("Deseja votar novamente? S-Sim ou N-Nao");
        scanf(" %c",&resp2);
        vot++;
    }while(resp2!='N' && resp2!='n'); 

    system("CLS");
    puts(">>RELATORIO<<");
    printf("VOTOS NO PELE = %d\n",pel); 
    printf("VOTOS NO MARADONA = %d\n",mar);
    printf("VOTOS EM BRANCO = %d\n",br);
    printf("VOTOS EM NULO = %d\n",nulo); 

    if(pel>mar){
        puts("PELE E O GOAT");
    }
    else if(mar>pel){
        puts("MARADONA E O GOAT");
    }
    else{
        puts("EMPATOU");
    }
    return 0; 
}
