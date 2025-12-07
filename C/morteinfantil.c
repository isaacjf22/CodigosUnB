#include <stdio.h>
#include <stdlib.h>
#include <conio.h> 

// Foi feita uma pesquisa para determinar o índice de
// mortalidade infantil em um certo período de tempo. Faça um
// programa que:
// • leia o número de crianças nascidas neste período;
// • leia uma quantidade indeterminada de dados de cada
// criança que faleceu neste período, sendo estes dados:
//     + sexo da criança (M = masculino, F = feminino);
//     + número de meses de vida de cada criança falecida.
// O encerramento da leitura destes dados (crianças falecidas)
// ocorrerá quando sexo for X ou o limite de crianças nascidas no
// período for atingido, indicando que todas as crianças que
// nasceram vieram a falecer neste período analisado. Mostre os
// resultados desta pesquisa:
// a) quantidade e porcentagem de crianças mortas neste
// período;
// b) porcentagem de crianças masculinas mortas neste
// período em relação a todas as crianças masculinas;
// c) porcentagem de crianças que viveram 24 meses ou
// menos no período em relação a todas as crianças.

int main(){
    int i,nasc;
    double masc=0,fem=0,mascm=0,femm=0,crianm=0,crian24=0; //variaveis de contagem 
    double porcmm,porc24,porcm; 
    int tempv;
    char resps,respv;

    puts(">>INDICE DE MORTALIDADE INFANTIL<<");
    puts("");
    puts("Quantas crianças nasceram no periodo de analise?");
    scanf("%d",&nasc); 

    for(i=0;i<nasc;i++){
        system("CLS");
        printf("ANALISE INDIVIDUO %d\n",i+1);
        puts("Qual é sexo da criança?");
        puts("M=Masculino / F=Feminino / X=Encerrar");
        scanf(" %c",&resps);
        puts("");
        if(resps=='M' || resps=='m'){
            masc++;
            puts("A crianca esta viva?");
            scanf(" %c",&respv);
            puts("");
            if(respv=='N' || respv=='n'){
                crianm++;
                mascm++;
                puts("Quanto tempo a criança viveu(em meses)?");
                scanf("%d",&tempv);
                if(tempv<25){
                    crian24++;
                }
            }
        }
        else if(resps=='F' || resps=='f'){
            fem++;
            puts("A crianca esta viva?");
            scanf(" %c",&respv);
            puts("");
            if(respv=='N' || respv=='n'){
                crianm++;
                femm++;
                puts("Quanto tempo a criança viveu(em meses)?");
                scanf("%d",&tempv);
                if(tempv<25){
                    crian24++;
                }
            }
        }
        else if(resps=='X' || resps=='x'){
            break;
        }
        else{
            puts("Sexo desconhecido.");
            puts("Aperte qualquer tecla para continuar...");
            getch();
            i--; //para n mudar a ordem e tentar novamente a escolha de sexo
        }
    }

    system("CLS"); 

    //calculo porcentagem
    if(masc>0){
        porcmm=(mascm/masc)*100; 
    }else{
        porcmm=0;
    }
    if(nasc>0){
        porc24=(crian24/nasc)*100; 
        porcm=(crianm/nasc)*100;
    }else{
        porc24=0;
        porcm=0;
    }

    puts(">>RELATORIO DO INDICE DE MORTALIDADE INFANTIL<<");
    puts("");
    printf("Quantidade de criancas mortas no periodo analisado: %.0lf\n",crianm);
    printf("A porcentagem de criancas mortas no periodo analisado: %.0lf%%\n",porcm);
    printf("A porcentagem de criancas masculinas mortas em relacao a todas as criancas masculinas: %.2lf%%\n", porcmm);
    printf("A porcentagem de crianças que viveram 24 meses ou menos em relação a todas as criancas: %.2lf%%\n", porc24);
  
return 0;
}


