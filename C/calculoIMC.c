#include <stdio.h>
#include <locale.h>

int main(){
    setlocale(LC_ALL,"portuguese"); 
    double peso,alt,imc; 

    printf("\n>>CALCULADORA IMC<<\n");
    printf("Digita o seu peso em KG : \n");
    scanf("%lf",&peso); 
    printf("Digite a sua altura em metros : \n"); 
    scanf("%lf",&alt); 

    imc=(peso/(alt*alt)); 

    printf("O valor do seu IMC é %.2lf\n",imc);
    printf("Sua classificação: \n"); 
    if(imc<18.5){
        printf("ABAIXO DO PESO\n");
    }
    else if(imc>=18.5 && imc<=24.9){
        printf("PESO NORMAL\n");
    }
    else if(imc>=25 && imc<=29.9){
        printf("SOBREPESO\n");
    }
    else if(imc>=30 && imc<=34.9){
        printf("OBESIDADE GRAU 1\n");
    }
    else if(imc>=35 && imc<=39.9){
        printf("OBESIDADE GRAU 2\n");
    }
    else{
        printf("OBESIDADE GRAU 3\n");
    }
return 0; 

}