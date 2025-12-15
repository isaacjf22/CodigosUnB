//  Faça um programa que crie uma ficha cadastral baseada 
// no uso das variáveis compostas heterogêneas. A ficha 
// deve consistir exatamente no diagrama a seguir e possuir 
// um registro que será informado na tela, após leitura do 
// usuário, onde o Endereço é formado por outra estrutura 
// ?interna?. Nome , endereço , data de nascimento , sexo , salario , RG. 

#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>

typedef struct estrutura_endereci{
    char rua[50]; 
    int numero; 
    char bairro[50];
}endereco; 

typedef struct estrutura_ficha{
    char nome[50];
    endereco end; //aqui eu chamo a estrutura do endereço para a estrutura da ficha.  
    int dia,mes,ano; //data de nascimento 
    char sexo[50]; 
    float salario; 
    char rg[20]; 
}ficha; 


int main(){
    char esc;
    setlocale(LC_ALL,"portuguese");
    ficha pessoa; 
    puts("FICHA CADASTRAL"); 
    puts("");
    puts("Qual é o seu nome?"); 
    fgets(pessoa.nome,50,stdin);
    pessoa.nome[strcspn(pessoa.nome,"\n")]=0; //para excluir o enter 
    puts("Qual é a rua do seu endereço?"); 
    fgets(pessoa.end.rua,50,stdin); //fgets considera os espaços 
    pessoa.end.rua[strcspn(pessoa.end.rua,"\n")]=0;  //tirando o enter 
    puts("Qual é o numero do seu endereço?"); 
    scanf("%d",&pessoa.end.numero);
    getchar(); 
    puts("Qual é o bairro do seu endereço?");
    fgets(pessoa.end.bairro,50,stdin); 
    pessoa.end.bairro[strcspn(pessoa.end.bairro,"\n")]=0;
    puts("Qual é sua data de nascimento? DIA/MES/ANO respectivamente");
    scanf("%d %d %d",&pessoa.dia,&pessoa.mes,&pessoa.ano);
    puts("Qual é o seu sexo? M-Masculino ou F-Feminino");
    do{
        esc=getchar();
    }while(esc!='M' && esc!='m' && esc!='F' && esc!='f'); 
    if(esc=='M' || esc=='m'){ //atribuindo a escolha para o sexo 
        strcpy(pessoa.sexo,"Masculino"); 
    }else{
        strcpy(pessoa.sexo,"Feminino");
    }
    puts("Qual é o seu RG?"); 
    do{
        scanf("%s",pessoa.rg);
        getchar(); //para excluir o enter 
        if(strlen(pessoa.rg)<8){ //rg precisa no minimo 15 numeros 
            puts("Quantidade de numeros invalido! Tente novamente");
        }
    }while(strlen(pessoa.rg)<8); 
    puts("Qual é o seu salário atual?");
    scanf("%f",&pessoa.salario); 
    getchar(); //para excluir o enter  

    system("cls"); 

    puts("SAÍDA DE DADOS:");
    puts("");
    printf("Nome: %s\n",pessoa.nome);
    printf("Endereço: RUA: %s / NUMERO: %d / BAIRRO: %s\n",pessoa.end.rua,pessoa.end.numero,pessoa.end.bairro);
    printf("Data de Nascimento: %d/%d/%d\n",pessoa.dia,pessoa.mes,pessoa.ano); 
    printf("Sexo: %s\n",pessoa.sexo); 
    printf("RG: %s\n",pessoa.rg);
    printf("Salário atual: %.2f\n",pessoa.salario);
    return 0;
}