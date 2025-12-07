#include <stdio.h> //padrão
#include <locale.h> //arrumar português
#include <ctype.h> //funçao de maiusculo 
#include <stdlib.h> // para system()
 //Leia um valor N que indica o número de casos de teste. Cada caso contém uma quantidade
 //de cobaias e um tipo (?C?, ?R?, ?S?). Apresente o total de cobaias, o total por tipo e o
 //percentual de cada um.

 int main() {
    setlocale(LC_ALL,"portuguese");
    int n,quant,i; 
    double total,pc,ps,pr,c=0,r=0,s=0; 
    char esc,escf; 


    printf("\nEXPERIÊNCIA DE COBAIAS\n"); 
    printf("Qual é a quantidade casos que vão ser analisados?\n"); 
    scanf("%d",&n); 
    system("CLS"); //para limpar tela 

    for(i=1;i<=n;i++){
        printf("Qual é o tipo de cobaia do caso %d?\n",i); 
        printf("C / R / S\n"); 
        scanf(" %c",&esc); 
        escf=toupper(esc); //atribuindo que o caracter recebido seja maiusculo 

        
        while(escf!='C' && escf!='R' && escf!='S'){
            printf("Caracter digitado incorreto! Tente novamente.\n"); 
            printf("C / R / S\n");
            scanf(" %c",&esc);
            escf=toupper(esc); 
        }
        
        switch(escf){
            case 'C': printf("Qual é a quantidade de cobaias?\n"); 
                    scanf("%d",&quant); 
                    c=c+quant; //acumulação da quantidade 
                    system("CLS"); 
                    break; 
            case 'R': printf("Qual é a quantidade de cobaias?\n"); 
                    scanf("%d",&quant); 
                    r=r+quant; 
                    system("CLS"); 
                    break; 
            case 'S': printf("Qual é a quantidade de cobaias?\n"); 
                    scanf("%d",&quant); 
                    s=s+quant; 
                    system("CLS"); 
                    break; 
        }
    }
    total=c+r+s; 
    
    if(total==0){
        pc=0; 
        ps=0;
        pr=0; 
        printf("Nenhuma cobaia registrada\n"); 
    }
    else{
        pc=(c/total)*100; 
        ps=(s/total)*100; 
        pr=(r/total)*100; 
    }

    printf("\n-------------------------------------------------\n"); 
    printf("                ANALISE DOS DADOS                    "); 
    printf("\n-------------------------------------------------\n"); 
    printf("\nTotal de cobaias -> %.0lf\n",total); 
    printf("Total de cobaias tipo 'C' -> %.0lf\n",c); 
    printf("Porcentagem dos cobaias tipo 'C' -> %.2lf%%\n",pc); 
    printf("Total de cobaias tipo 'S' -> %.0lf\n",s); 
    printf("Porcentagem dos cobaias tipo 'S' -> %.2lf%%\n",ps); 
    printf("Total de cobaias tipo 'R' -> %.0lf\n",r); 
    printf("Porcentagem dos cobaias tipo 'R' -> %.2lf%%\n",pr); 

    return 0; 
 }