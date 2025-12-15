// Elabore um programa que solicite ao usuário o seu 
// nome completo e as suas 4 notas parciais no 
// decorrer de um determinado curso.  Após armazenar 
// os dados informados pelo usuário apresente o nome 
// e somente a média aritmética alcançada pelas notas 
// obtidas por cada aluno.  A estrutura deverá consistir 
// em apenas dois componentes (nome, média), onde a 
// média será um vetor (ou matriz) que armazena as 4 
// notas do aluno.  
// Use as funções de leitura de dados que achar mais 
// coerente para solucionar este problema

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define TAM 50

struct Pessoa{
    char nome[TAM];
    float media[4]; 
}pessoa; 

int main(){
    int i; 
    float final=0,mf; //final =0 ja q n tem nada e vai acumular dentro dele 
    puts("Ola, vamos calcular a sua media.");
    puts("Qual e o seu nome completo?"); 
    fgets(pessoa.nome,TAM,stdin); //dessa forma da pra pegar o nome completo
    
    pessoa.nome[strcspn(pessoa.nome,"\n")]=0; //para tirar o enter

    for(i=0;i<4;i++){
        printf("Qual e o valor da %d avaliacao?\n",i+1);
        scanf("%f",&pessoa.media[i]);
        final+=pessoa.media[i]; 
    }

    mf=final/4; 
    system("cls"); 

    printf("Ola %s, a sua media final foi %.2f.",pessoa.nome,mf);

    return 0;
}