#include <stdio.h> 
#include <locale.h>
// Leia um valor inteiro N, que indica a quantidade de casos de teste. Para cada caso, leia
//um valor inteiro X e mostre se ele � par ou �mpar, positivo ou negativo, ou nulo.

int main() {
    int num,quant,i;
    setlocale(LC_ALL,"portuguese"); 

    printf("\n>>ANALISADOR DE N�MEROS<<\n"); 
    printf("Quantos casos ser�o analisados?\n");
    scanf("%d",&quant);

    for(i=1;i<=quant;i++) { //2� � a condi��o para continuar o para , enq vdd ele rola
        printf("\nDigite o %d� valor\n",i);
        scanf("%d",&num);

        if(num%2==0) {
            printf("O seu n�mero � par!\n");
        }
        else if (num%2!=0) {  //se for colocar comando no else bota else if 
            printf("O seu n�mero � �mpar!\n");
        }

        if(num>0) {
            printf("O seu n�mero � positivo!\n");
        }
        else if(num<0){
            printf("O seu n�mero � negativo!\n"); 
        }
        else{
            printf("O seu n�mero � nulo!\n");
        }
    }
return 0; 

}