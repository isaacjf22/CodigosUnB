// escreva uma função que receba um número inteiro n e dois
// endereços para números reais, leia n números reais, atribua
// ao conteúdo dos ponteiros os valores mínimo e máximo dos n
// números e retorne sua média aritmética. Escreva também um
// // programa para testar sua função.

#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

float analiseNum(int esco,float *max,float *min); 

int main(){
    setlocale(LC_ALL,"portuguese"); 
    float min,max,media; //estabele o inicio de comparação aq
    int esco; 
    do{  //validação da escolha 
        system("cls"); 
        printf("Quantos números você quer dar entrada na análise? de 1 a 100\n");
        scanf("%d",&esco);
        getchar(); //limpeza de buffer 
    }while(esco<0 || esco>101); //repita enquanto for valido 

    media=analiseNum(esco,&max,&min);

    printf("De acordo com as análises dos números, a média deles é %.2f , o maior deles é %.0f e o menor é %.0f\n",media,max,min);

    return 0;     
}

float analiseNum(int esco, float *max,float *min){
    int i;
    float num[100];
    float media=0;  
    puts("");
    for(i=0;i<esco;i++){ //entrada de numeros 
        printf("Qual é o %dº número?\n",i+1);
        scanf("%f",&num[i]); 
        media+=num[i]; //acumulação de valor 
        if(i==0){//definindo que 1 primeiro é o molde de comparação inicial
            *min=num[i];
            *max=num[i];
        }else{ //agora o restante dos números vão ser comparadados 
            if(num[i]>*max){ //maior numero 
                *max=num[i];
            }
            if(num[i]<*min){ //menor numero 
                *min=num[i];
            }
        }
    }
    return media/esco; 
}