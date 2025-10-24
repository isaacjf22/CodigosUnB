#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
    setlocale(LC_ALL,"portuguese");

    double sal,a,de,t; 

    printf("Digita o seu salário para ver quanto de imposto terá que pagar: \n");
    scanf("%lf",&sal); 

    if(sal<=2259.20){
        printf("FAIXA 1: Você está ISENTO do imposto de renda.");
    }
    else if(sal>2259.2 && sal<=2828.65){
        de=(sal*0.075)-169.44; 
        t=sal-de;
        printf("FAIXA 2: Você irá pagar de imposto R$%.2lf e sobrará R$%.2lf ",de,t);
    }
    else if(sal>2828.65 && sal<=3751.05){
        de=(sal*0.15)-381.44; 
        t=sal-de;
        printf("FAIXA 3: Você irá pagar de imposto R$%.2lf e sobrará R$%.2lf ",de,t);
    }
    else if(sal>3751.05 && sal<=4664.68){
        de=(sal*0.225)-662.77; 
        t=sal-de;
        printf("FAIXA 4: Você irá pagar de imposto R$%.2lf e sobrará R$%.2lf ",de,t);
    }
    else{
        de=(sal*0.275)-896; 
        t=sal-de;
        printf("FAIXA 5: Você irá pagar de imposto R$%.2lf e sobrará R$%.2lf ",de,t);
    }
    return 0;
}