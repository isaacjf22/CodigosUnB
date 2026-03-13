// Elabore um programa que armazene o nome, a primeira 
// nota e a segunda nota de um grupo de cinco alunos. Use o 
// recurso das estruturas para fazer este armazenamento.  
// Apresente todas as notas por meio de uma outra função e 
// com a terceira função calcule a média de cada um destes 
// alunos, apresentando-as em seguida.

#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>
#define TAM 50 

typedef struct aluno_est{
    char nome[TAM]; 
    float nota1;
    float nota2; 
    float media; 
}aluno;

void display(aluno alunos[],int n); //protótipo das funções utilizadas 
void media(aluno alunos[],int n); 

int main(){
    setlocale(LC_ALL,"portuguese");
    int i,n;
    puts("Qual é a quantidade de alunos para análise?");
    scanf("%d",&n); 
    getchar(); //para limpar o buffer 
    aluno alunos[n]; //declarando um vetor dos alunos 
    
    for(i=0;i<n;i++){
        alunos[i].media=0;
        printf("Qual é o nome do %dº aluno?\n",i+1); 
        fgets(alunos[i].nome,TAM,stdin);
        alunos[i].nome[strcspn(alunos[i].nome,"\n")]=0; //para retirar o enter do fgets
        puts("Qual é a 1º nota do aluno?");
        scanf("%f",&alunos[i].nota1);
        getchar(); //limpando o buffer 
        puts("Qual é a 2º nota do aluno?");
        scanf("%f",&alunos[i].nota2);
        getchar(); //limpando o buffer 
        alunos[i].media+=alunos[i].nota1+alunos[i].nota2; 
        system("CLS"); 
    }

    display(alunos,n);    //usar somente o nome da variavel da struct 
    puts(""); 
    media(alunos,n);
    return 0;
}

void display(aluno alunos[],int n){ //n representa quantidade de alunos q estão na analise 
    int i; 
    for(i=0;i<n;i++){
        printf("%dº Aluno, %s , P1: %.2f P2: %.2f\n",i+1,alunos[i].nome,alunos[i].nota1,alunos[i].nota2); 
    }
    return; 
}

void media(aluno alunos[],int n){ //na função coloca a struct, nome e [] se for vetor 
    float mediaf; 
    int i;
    for(i=0;i<n;i++){
        mediaf=0;
        mediaf=(alunos[i].nota1+alunos[i].nota2)/2; 
        printf("Média do %dº aluno: %.2f\n",i+1,mediaf); 
    }
    return; 
}

