#include <stdio.h>
#include <conio.h>
#include <string.h>

#define MAX 50

// Desenvolva um programa que solicite as três notas de
// provas para cada estudante de uma turma em determinada
// disciplina. Leia os valores na função principal e acione
// uma outra função, chamada calculaMedia, que realizará
// o cálculo da média aritmética para cada estudante
// informado. Apresente na função principal (main) o nome
// válido do estudante e a sua média alcançada, conforme
// suas notas forem sendo informadas (mostrar média para
// cada estudante).
// O nome não poderá ser nulo e nem superar o limite
// definido em uma diretiva de substituição de texto
// chamada MAX. Lembre-se que NÃO é permitido o uso
// de variáveis globais e a validação de cada nota informada
// deverá ocorrer pela função validaNota para valores entre
// zero e dez pontos somente.

double calculaMedia(double n1, double n2, double n3){
    double resul; 
    resul=(n1+n2+n3)/3;
    return resul; 
}

double lerEvalidaNota(){
    double nota; 
    do{
        scanf("%lf",&nota);
        if(nota<0 || nota>10){
            puts("Nota digitada invalida! Tente novamente");
        }
    }while(nota<0 || nota>10);
    return nota; 
}


int main(){
    char nome[MAX];
    double n1,n2,n3; 

    puts("Qual e o seu nome?");
    fgets(nome,MAX,stdin);

    nome[strlen(nome)-1]='\0'; //so quando tem o fgets para tirar o enter=\n
    //nome[strcspn(nome, "\n")] = 0; outra opção, ele procurar dentro da string e so substituir

    while(strlen(nome)==0 || strlen(nome)>MAX){
        puts("Nome digitado invalido!");
        puts("Tente novamente: ");
        fgets(nome,MAX,stdin);
        nome[strlen(nome)-1]='\0';
    }

    puts("Digite a 1 nota: ");
    n1=lerEvalidaNota();

    puts("Digite a 2 nota: ");
    n2=lerEvalidaNota();

    puts("Digite a 3 nota: ");
    n3=lerEvalidaNota();

    printf("%s, o resultado da media das suas tres notas foi %.2lf",nome,calculaMedia(n1,n2,n3));

    return 0;
}