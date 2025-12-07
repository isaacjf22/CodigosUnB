#include <stdio.h> 
#include <conio.h>
#include <stdlib.h>
#include <string.h>

// Tem-se um conjunto de dados contendo a altura e o sexo
// aceito somente em string (masculino ou feminino) de 10
// pessoas. Faça um programa que calcule e escreva: a maior e
// a menor altura do grupo; a média de altura das mulheres; o
// número de homens. O sexo coletado do usuário deverá ser
// uma string validada a ser armazenada e analisada por seu
// programa.

int main(){
    char sexo[5][20]; 
    double h[5],conth=0,contf=0,hfe=0,media; 
    double maiorh,menorh; //para definir so o maior e menor sem precisar organizar 
    int i; 
    
    puts("\n>>ANALISADOR DE ALTURAS<<\n"); 
    
    for(i=0;i<5;i++){
        printf("Digite a altura da %d pessoa: \n",i+1);
        scanf("%lf",&h[i]);

        if(i==0){
            maiorh=h[0];
            menorh=h[0];
        }
        else{ //depois do 1º
            if(h[i]>maiorh){ //analise depois do 1
                maiorh=h[i];
            }
            if(h[i]<menorh){
                menorh=h[i];
            }

        }
        
        printf("Qual e o sexo da %d pessoa? MASCULINO/FEMININO?\n",i+1); 
        scanf("%s",sexo[i]);
        puts("\n"); //para pular uma linha toda
        
        while(strcmp(sexo[i],"MASCULINO")!=0 && strcmp(sexo[i],"masculino")!=0 && strcmp(sexo[i],"FEMININO")!=0 && strcmp(sexo[i],"feminino")!=0){
            puts("Sexo digitado invalido, tente novamente!");
            puts("MASCULINO/FEMININO");
            scanf("%s",sexo[i]); 
            puts("\n");
        }
        if(strcmp(sexo[i],"MASCULINO")==0 || strcmp(sexo[i],"masculino")==0 ){
             conth=conth+1; 
        }
        else{
            hfe=hfe+h[i];
            contf=contf+1;
        }     
    }

    puts("Digite alguma tecla para continuar...\n");
    getch(); 
    
    system("CLS");

    if(contf==0){
        media=0;
    }
    else{
        media=hfe/contf; 
    }

    puts("\n>>DADOS OBTIDOS<<\n");
    printf("A media das alturas dos individuos de sexo feminino -> %.2lf\n",media);
    printf("A quantidade de individuos do sexo masculino -> %.0lf\n",conth); 
    printf("A maior altura do grupo e %.2lf e a menor %.2lf",maiorh,menorh); 

    return 0; 
}