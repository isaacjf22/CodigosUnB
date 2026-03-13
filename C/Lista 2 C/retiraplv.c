#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
    char frase[100],frasec[100];
    int i,cc; 

    puts("Digite uma frase onde as letras 'c's serao retiradas");
    fgets(frase,100,stdin);

    strcpy(frasec,frase);

    for(i=0;frasec[i]!='\0';i++){
        if(frasec[i]=='c' || frasec[i]=='C'){
            frasec[i]='_';
            cc++; 
        }
    }
    system("CLS");
    printf("A frase original: %s\n",frase);
    printf("A frase alterada: %s\n",frasec);
    printf("A quantidade de letras 'c's removidas foram: %d",cc);
    return 0;
}