#include <stdio.h> 
#include <locale.h>
// Leia um valor inteiro N, que indica a quantidade de casos de teste. Para cada caso, leia
//um valor inteiro X e mostre se ele é par ou ímpar, positivo ou negativo, ou nulo.

int main() {
    int num,quant,i;
    setlocale(LC_ALL,"portuguese"); 

    printf("\n>>ANALISADOR DE NÚMEROS<<\n"); 
    printf("Quantos casos serão analisados?\n");
    scanf("%d",&quant);

    for(i=1;i<=quant;i++) { //2º é a condição para continuar o para , enq vdd ele rola
        printf("\nDigite o %dº valor\n",i);
        scanf("%d",&num);

        if(num%2==0) {
            printf("O seu número é par!\n");
        }
        else if (num%2!=0) {  //se for colocar comando no else bota else if 
            printf("O seu número é ímpar!\n");
        }

        if(num>0) {
            printf("O seu número é positivo!\n");
        }
        else if(num<0){
            printf("O seu número é negativo!\n"); 
        }
        else{
            printf("O seu número é nulo!\n");
        }
    }
return 0; 

}