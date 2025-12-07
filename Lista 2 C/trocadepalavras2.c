#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// Faça um programa que receba uma palavra e calcule quantas vogais (a, e, i, o, u)
// possui essa palavra. Entre com um caractere (vogal ou consoante) e substitua todas
// as vogais da palavra dada por esse caractere

int main(){
    char texto[50],carac,textoalt[50];
    int i,contv=0;

    puts("Digite uma palavra para ser analisado:");
    printf("--> ");
    fgets(texto,50,stdin);
    system("CLS"); 
    puts("Digite um caracter que vai trocar que vai substituir todas as vogais da palavra: ");

    carac=getchar();
    strcpy(textoalt,texto);
    
    for(i=0;textoalt[i]!='\0';i++){
        if(textoalt[i]=='A' || texto[i]=='a' || texto[i]=='E' || texto[i]=='e' || texto[i]=='I' || texto[i]=='i' || texto[i]=='O' || texto[i]=='o' || texto[i]=='U' || texto[i]=='u'){
            contv++;
            textoalt[i]=carac;
        }
    }

    printf("O texto original %s / O texto alterado %s\n",texto,textoalt);
    puts("");
    printf("A quantidade de vogais da palavra analisada foi %d",contv);

    return 0; 
}