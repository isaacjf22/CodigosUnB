// Elabore um novo tipo de dado que armazene o endereço 
// de uma pessoa. Depois desenvolva um programa que faça 
// o registro de uma pessoa guardando o nome, endereço 
// (usando o tipo novo), o telefone e a altura dela.  Faça um 
// cadastro de algumas pessoas e mostre os dados coletados.

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <locale.h>
#include <conio.h> //getch
#define tam 50

//posso melhorar colocando validações 
//possivel colocar struct encadeada

typedef struct estrutura_endereco{
    char logra[tam];
    int num; 
    char comp[tam]; 
    char bairro[tam]; 
    char cidade[tam]; 
    char uf[tam]; 
    char cep[tam]; 
}endereco; 

int main(){
    char nome[100][tam];  //1 quantidade de indices 2 tamanho da string 
    int tele[100]; 
    float alt[100]; 
    int cont=0; 
    char esc; //escolha se deseja continuar ou não 
    int i;
    endereco end[100]; 
    setlocale(LC_ALL,"portuguese");

    do{
        system("cls");
        printf(">>REGISTRO Nº%d<<\n",cont+1);
        puts(">Nome<"); 
        fgets(nome[cont],tam,stdin); 
        nome[cont][strcspn(nome[cont],"\n")]=0;  //tirando o enter 
        puts(">Endereço<");
        printf("    -Logradouro: "); // sem /n para q a resposta seja no lado 
        fgets(end[cont].logra,tam,stdin);
        end[cont].logra[strcspn(end[cont].logra,"\n")]=0; //tirando o enter 
        puts(""); 
        printf("    -Número: "); 
        scanf("%d",&end[cont].num);
        getchar(); //limpando o enter 
        puts("");
        printf("    -Complemento: ");
        fgets(end[cont].comp,tam,stdin);
        end[cont].comp[strcspn(end[cont].comp,"\n")]=0; //tirando o enter 
        puts("");
        printf("    -UF: ");
        fgets(end[cont].uf,tam,stdin);
        end[cont].uf[strcspn(end[cont].uf,"\n")]=0; //tirando o enter 
        puts(""); 
        printf("    -Cidade: ");
        fgets(end[cont].cidade,tam,stdin);
        end[cont].cidade[strcspn(end[cont].cidade,"\n")]=0; //tirando o enter 
        puts(""); 
        printf("    -Bairro: ");
        fgets(end[cont].bairro,tam,stdin);
        end[cont].bairro[strcspn(end[cont].bairro,"\n")]=0; //tirando o enter 
        puts("");
        printf("    -CEP: ");
        fgets(end[cont].cep,tam,stdin);
        end[cont].cep[strcspn(end[cont].cep,"\n")]=0; //tirando o enter 
        puts(""); 
        puts(">Telefone<"); 
        scanf("%d",&tele[cont]); 
        getchar();
        puts(">Altura<"); 
        scanf("%f",&alt[cont]); 
        getchar(); //limpando o enter 
        cont+=1; 
        puts("");
        puts("Deseja adicionar mais um registro?"); 
        puts("S-SIM ou N-NÃO"); 
        do{
            esc=getch(); //n tem risco de ter enter 
        }while(esc!='S' && esc!='s' && esc!='N' &&esc!='n'); 
        
    }while(esc!='n' && esc!='N'); 
    system("cls"); 

    puts(">>DADOS REGISTRADOS<<");

    for(i=0;i<cont;i++){
        printf("Dados da %dº pessoa: \n",i+1); 
        printf("-Nome: %s\n",nome[i]); 
        puts("-Endereço: ");
        printf("    Logradouro: %s\n",end[i].logra);
        printf("    Numero: %d\n",end[i].num); 
        printf("    Complemento: %s\n",end[i].comp);
        printf("    UF: %s\n",end[i].uf);
        printf("    Cidade: %s\n",end[i].cidade);
        printf("    Bairro: %s\n",end[i].bairro);
        printf("    CEP: %s\n",end[i].cep);
        printf("-Telefone: %d\n",tele[i]); 
        printf("-Altura : %.2f\n",alt[i]); 
        puts(""); 
    }
    return 0; 
}