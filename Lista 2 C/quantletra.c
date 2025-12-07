#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// Faça um programa que receba uma frase (máximo 100 caracteres) e uma letra
// qualquer, calcule e mostre a quantidade que essa letra aparece na frase digitada. Para
// descobrir o tamanho da frase digitada utilize a função strlen(cadeia de
// caracteres).

int main(){
    char frase[100],letra;
    int i,vi;

    puts("Digite uma frase no máximo 100 caracteres");
    fgets(frase,100,stdin);
    puts("");
    puts("Digite uma letra para vermos a quantidade de vezes que aparece na frase");
    letra=getchar();

    for(i=0;frase[i]!='\0';i++){
        if(letra==frase[i]){
            vi++;
        }
    }
    system("CLS");
    printf("Frase: %s",frase);
    printf("A quantidade de vezes que sua palavra ja apareceu na frase foi %d vezes",vi);
    return 0;
}