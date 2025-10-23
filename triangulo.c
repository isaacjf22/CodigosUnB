#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
    setlocale(LC_ALL,"portuguese");
    int l[3],i,j,t; 
    
    printf(">>ANÁLISE DE TRIÂNGULOS<<\n");
    printf("SOMENTE VALORES INTEIROS\n");
    printf("\n"); 
    for(i=0;i<3;i++){
        printf("Digite o valor do %dº lado : \n",i+1); 
        scanf("%d",&l[i]); 
        }
    for(i=0;i<3;i++){ //for para organizar 
        for(j=1;j<3;j++){ //organização em ordem decrescente 
            if(l[j]>l[j-1]){
                t=l[j];
                l[j]=l[j-1]; 
                l[j-1]=t; 
            }
    }
    }
    system("CLS");
    if(l[0]>=l[1]+l[2]){
        printf("O SEU TRIÂNGULO NÃO EXISTE!\n"); 
    }
    else{
        if(l[0]==l[1] && l[0]==l[2]){
            printf("O SEU TRIÂNGULO EXISTE E É EQUILÁTERO\n"); 
        }
        else if(l[0]==l[1] || l[0]==l[2] || l[1]==l[2]){
            printf("O SEU TRIÂNGULO EXISTE E É ISÓSCELES\n");
        }
        else{
            printf("O SEU TRIÂNGULO EXISTE E É ESCALENO\n");
        }   
    }
    return 0;
}