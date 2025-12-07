#include <stdio.h>
#include <string.h>

// Faça um programa que receba uma palavra e a imprima de trás-para-frente

int main(){
    char texto[50],textoc[50];
    int i,j=0,numt;

    puts("Digite um texto para ser analisado: ");
    printf("--> ");
    fgets(texto,50,stdin);
    
    texto[strlen(texto)-1]='\0';

    numt=strlen(texto);

    //foi criado um contador q comeca do inicio e o for do final 
    //duas variaveis um do original que vai servir de referencia , e o outro q vai se formar o texto invertido 
    for(i=numt-1;i>=0;i--){ //o num-1 foi para arrumar a quantidade de incides e tirar o do \0
        textoc[j]=texto[i]; //aq ocorre a criação do novo texto atribuindo cada caracter com o final do texto original 
        j++;
    }

    //precisa colocar no ultimo j o freio do string 
    textoc[j]='\0'; 

    printf("O texto original: %s / O texto alterado: %s ",texto,textoc);
    
    return 0;
}