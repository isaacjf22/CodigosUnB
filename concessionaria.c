// Elabore um programa que na função principal apresente as
// opções de menu com as seguintes concessionárias de veículos:
// FIAT, CHEVROLET e FORD. Solicite ao usuário qual das
// opções ele deseja verificar os carros disponíveis. Identifique qual
// a opção escolhida e apresente as respectivas opções dos carros
// disponíveis, conforme as listas descritas abaixo. A concessionária
// escolhida deverá acionar outra função que apresentará somente os
// veículos disponíveis da marca especificada. Para cada
// concessionária deverá existir uma função específica com os carros
// disponíveis. Após identificar o carro escolhido pelo usuário,
// apresente no centro de uma janela limpa uma mensagem de
// agradecimento e o nome do carro escolhido (implemente
// conforme esquema ao lado para as funções):

#include <stdio.h>
#include <stdlib.h>

void fiat(){
    int esc; 

    puts("---FIAT---");
    puts("Qual carro voce deseja?");
    puts("1 - UNO");
    puts("2 - PULSE");
    printf("---> ");
    scanf("%d",&esc); 

    system("CLS");
    if(esc==1){
        puts("Obrigado por usar! Voce escolheu o UNO");
    }else{
        puts("Obrigado por usar! Voce escolheu o PULSE");
    }

    return; 
    //n colocarei validao nas escolhas de carros 
}

void chevrolet(){
    int esc; 

    puts("---CHEVROLET---");
    puts("Qual carro voce deseja?");
    puts("1 - ONIX");
    puts("2 - CAMARO");
    printf("---> ");
    scanf("%d",&esc); 

    system("CLS");
    if(esc==1){
        puts("Obrigado por usar! Voce escolheu o ONIX");
    }else{
        puts("Obrigado por usar! Voce escolheu o CAMARO");
    }

    return; 
    //n colocarei validao nas escolhas de carros 
}

void ford(){
    int esc; 

    puts("---FORD---");
    puts("Qual carro voce deseja?");
    puts("1 - FORD KA");
    puts("2 - RANGER");
    printf("---> ");
    scanf("%d",&esc); 

    system("CLS");
    if(esc==1){
        puts("Obrigado por usar! Voce escolheu o FORD KA");
    }else{
        puts("Obrigado por usar! Voce escolheu o RANGER");
    }
    return; 
    //n colocarei validao nas escolhas de carros 
}

int validaEsc(){
    int esc; 
    do{
        scanf("%d",&esc);
        if(esc!=1 && esc!=2 && esc!=3){
            puts("Voce digitou uma opcao errada! Tente novamente");
            printf("---> ");
        }
    }while(esc!=1 && esc!=2 && esc!=3);
    return esc; 
}

int main(){
    int esc;

    puts("======================================");
    puts("|           CONCESSIONARIA           |");
    puts("======================================");
    puts("");
    puts("ESCOLHA QUAL MARCA PARA VER OS CARROS: ");
    puts("1 - FIAT");
    puts("2 - CHEVROLET");
    puts("3 - FORD");
    printf("---> ");
    esc=validaEsc(); 

    system("CLS"); 

    switch(esc){
        case 1: fiat();
        break; 
        case 2: chevrolet();
        break; 
        case 3: ford();
        break;
    }
    return 0; 
}
// \t faz pular para direita o texto