// Fazer um programa que controle uma agenda que contém 
// para cada cliente o nome e telefone. Deverá ser previsto a 
// inclusão, alteração, exclusão e listagem dos elementos da 
// agenda. O programa principal deverá conter apenas a 
// declaração dos dados e as chamadas as funções de 
// manipulação.

#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <string.h> 
#include <stdlib.h>
#include <windows.h>
#define tam 50 

typedef struct ficha_cliente{
    char nome[tam];
    char tele[tam];
}cliente; 

void menu();
int adicionarCliente(int atual, cliente pessoa[] );
void listaCliente(int atual, cliente pessoa[]);
// int excluirClienteNome(int atual, cliente pessoa[]);
int excluirClienteNum(int atual, cliente pessoa[]);
void alteracaoDados(int atual, cliente pessoa[]);

int main(){
    setlocale(LC_ALL,"portuguese");
    menu();
    return 0; 
}

void menu(){
    char esc; //escolha de opção
    int n=0; //registra cada pessoa
    cliente pessoa[200];
    do{  
        system("cls"); 
        printf("===================================\n");
        printf("        Agenda comercial           \n");
        printf("===================================\n");
        puts("");
        printf("Número atual de clientes registrados: %d\n",n); 
        puts("O que deseja fazer?"); 
        puts(""); 
        puts("1- Adicionar cliente");
        puts("2- Alterar dados de cliente"); 
        puts("3- Excluir cliente"); 
        puts("4- Listar clientes"); 
        puts("5- Sair da Agenda"); 
        do{
            esc=getch(); //gecth reconhece como caracter 
        }while(esc!='1' && esc!='2' && esc!='3' && esc!='4' && esc!='5'); 
        switch(esc){
            case '1': n=adicionarCliente(n,pessoa); //so o nome da variavel da struct
            break;
            case '2': alteracaoDados(n,pessoa);
            break;
            case '3': n=excluirClienteNum(n,pessoa);
            break;
            case '4': listaCliente(n,pessoa); 
            break;
            case '5': puts("Saindo da agenda..."); 
            break; 
        }
    }while(esc!='5'); 
}

int adicionarCliente(int atual, cliente pessoa[] ){//sem ponto 
    int total;
    system("cls"); 
    printf("Qual é o nome do cliente a ser adicionado?\n");
    fgets(pessoa[atual].nome,tam,stdin); 
    pessoa[atual].nome[strcspn(pessoa[atual].nome,"\n")]=0; //tirando o enter do nome 
    printf("Qual é o número do cliente a ser adicionado?\n"); 
    fgets(pessoa[atual].tele,tam,stdin); 
    pessoa[atual].tele[strcspn(pessoa[atual].tele,"\n")]=0; //tirando o enter do nome
    total=atual+1; 
    puts("Aperte ENTER para voltar ao MENU...");
    getch();
    return total; 
} 

void listaCliente(int atual, cliente pessoa[]){
    int i; 
    system("cls");
    if(atual==0){
        puts("Nenhum cliente foi registrado no momento...");
        puts("Aperte ENTER para retornar ao MENU..."); 
        getch();
        return;
    }else{
        for(i=0;i<atual;i++){
            printf("CLIENTE Nº%d\n",i+1);
            printf("-Nome: %s\n",pessoa[i].nome);
            printf("-Telefone: %s\n",pessoa[i].tele); 
            printf("---------------------------------\n"); 
        }
        puts("Aperte ENTER para retornar ao MENU...");
        getch(); 
        return; 
    }
}

// int excluirClienteNome(int atual, cliente pessoa[]){ por nome 
//     int i,j;
//     char nome[tam]; 
//     int achou=0;
//     system("cls");
//     if(atual==0){
//         puts("Nenhum cliente para excluir no momento...");
//         puts("Aperte ENTER para voltar ao MENU...");
//         getch();
//         return atual; 
//     }else{
//         puts("Digite o NOME do cliente que vai ser excluído: ");
//         fgets(nome,tam,stdin);
//         nome[strcspn(nome,"\n")]=0;
//         for(i=0;i<atual;i++){
//             if(strcmp(pessoa[i].nome,nome)==0){
//                 achou=1;
//                 for(j=i;j<atual-1;j++){
//                     pessoa[j]=pessoa[j+1]; //a da posição atual vai ser o da frente , trocando o da frente com oq vai ser excluido e tapando
//                 }
//                 atual--; //retirando do total o cliente excluido 
//                 puts("O cliente foi excluído...");
//                 break;  //vai termina o loop j e vai interromper o loop i
//             }
//         }
//     }
//     if(achou==0){
//         puts("Não foi encontrado o nome escolhido..."); 
//     }
//     puts("Aperte ENTER para voltar ao MENU...");
//     getch();
//     return atual;
// }

int excluirClienteNum(int atual, cliente pessoa[]){ //por numero 
    int i; 
    int numescolhido, numparamaquina; 

    if(atual==0){
        puts("Não há cliente no momento para excluir...");
        puts("Aperte ENTER para voltar ao MENU...");
        getch();
        return atual; 
    }else{
        system("cls");
        for(i=0;i<atual;i++){
            printf("CLIENTE Nº%d\n",i+1);
            printf("-Nome: %s\n",pessoa[i].nome);
            printf("-Telefone: %s\n",pessoa[i].tele); 
            printf("---------------------------------\n"); 
        }
        puts("Qual cliente deseja excluir da agenda?"); 
        scanf("%d",&numescolhido); 
        getchar(); //limpando buffer
        if(numescolhido<1 || numescolhido>atual){
            puts("Cliente escolhido não existe!"); 
            puts("Aperte ENTER para voltar ao MENU...");
            getch(); 
            return atual; 
        }
        numparamaquina=numescolhido-1; //arrumando para escolher o indice correto
        for(i=numparamaquina;i<atual-1;i++){ //vai trocar da posição atual com o da frente e por diante , assim , tapando o buraco deixado pelo excluido 
            pessoa[i]=pessoa[i+1]; //trocando o atual com o da frente 
        }
        atual--;
        printf("Excluindo");
        for(i=0;i<5;i++){
            Sleep(600);
            printf("..");
        }
        puts("");
        puts("Excluído com sucesso!");
        puts("Aperte ENTER para voltar ao MENU...");
        getch(); 
        return atual; 
    }
}

void alteracaoDados(int atual, cliente pessoa[]){
    system("cls");
    int i; 
    int numescolhido, numparamaquina;
    char esc;  

    if(atual==0){
        puts("Não há cliente no momento para alterar os dados...");
        puts("Aperte ENTER para voltar ao MENU"); 
        getch(); 
    }else{
        for(i=0;i<atual;i++){
            printf("CLIENTE Nº%d\n",i+1);
            printf("-Nome: %s\n",pessoa[i].nome);
            printf("-Telefone: %s\n",pessoa[i].tele); 
            printf("---------------------------------\n"); 
        }
        puts("Qual cliente você quer alterar os dados?"); 
        scanf("%d",&numescolhido); 
        getchar(); 
        numparamaquina=numescolhido-1; //arrumando o indice escolhido 
        printf("O que você quer alterar do cliente nº%d?\n",numescolhido);
        puts("1-NOME / 2-TELEFONE");
        do{
            esc=getch();
        }while(esc!='1' && esc!='2'); 
        if(esc=='1'){
            puts("Qual seria o novo nome para esse cliente?");
            fgets(pessoa[numparamaquina].nome,tam,stdin); 
            pessoa[numparamaquina].nome[strcspn(pessoa[numparamaquina].nome,"\n")]=0; //tirando o enter do novo nome 
            puts("");
            printf("Alterando");
            for(i=0;i<5;i++){ //... para deixar bonitinho
            Sleep(600);
            printf("..");
            }
            puts("");
            puts("Alterado com sucesso!");
            puts("Aperte ENTER para voltar ao MENU...");
            getch(); 
            return;
        }else if(esc=='2'){
            puts("Qual seria o novo número de telefone para esse cliente?");
            fgets(pessoa[numparamaquina].tele,tam,stdin); 
            pessoa[numparamaquina].tele[strcspn(pessoa[numparamaquina].tele,"\n")]=0; //tirando o enter do novo telefone
            puts(""); 
            printf("Alterando");
            for(i=0;i<5;i++){ //... para deixar bonitinho
            Sleep(600);
            printf("..");
            }
            puts("");
            puts("Alterado com sucesso!");
            puts("Aperte ENTER para voltar ao MENU...");
            getch(); 
            return; 
        } 
    }
}