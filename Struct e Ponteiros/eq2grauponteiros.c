// Faça uma função para calcular as raízes de uma
// equação do segundo grau. A função deve ter o
// seguinte protótipo:

#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <locale.h>
#include <stdlib.h> 

int calculoDelta(double a,double b,double c,double *r1, double *r2);
void calculoRaizes(double delta, double a, double b, double *r1, double *r2); //prototipos das funções feitas 

int main(){
    char esc; //se tem outra equação para calcular ou não
    setlocale(LC_ALL,"portuguese");
    double a,b,c; //coeficientes da equação
    double r1,r2; //raízes da equação
    do{
        system("cls"); //limpar tela
        puts(">CALCULADORA DE EQUAÇÃO DO 2° GRAU<"); 
        puts("Digite os valores de Ax² , Bx e C da equação de 2º grau (respectivamente): "); 
        scanf("%lf %lf %lf",&a,&b,&c); 
        getchar(); //limpando o buffer
        puts("");   
        if(calculoDelta(a,b,c,&r1,&r2)==0){
            printf("A equação do 2º grau:  %+.0lfx²%+.0lfx%+.0lf\n",a,b,c); //o + para mostra o sinal e .0 para n mostrar o decimal
            printf("Possui delta negativo, logo não há raízes reais!\n"); 
            puts(""); 
        }else if(calculoDelta(a,b,c,&r1,&r2)==1){
            printf("A equação do 2º grau:  %+.0lfx²%+.0lfx%+.0lf\n",a,b,c); 
            printf("Possui delta=0, logo as raízes são reais e iguais!\n");
            printf("As raízes dessa equação são %+.0lf e %+.0lf\n",r1,r2); 
            puts(""); 
        }else if(calculoDelta(a,b,c,&r1,&r2)==2){
            printf("A equação do 2º grau:  %+.0lfx²%+.0lfx%+.0lf\n",a,b,c); 
            printf("Possui delta positivo, logo as raízes são reais e diferentes!\n");
            printf("As raízes dessa equação são %+.0lf e %+.0lf\n",r1,r2); 
            puts(""); 
        }
        puts("Deseja calcular outra equação do 2º grau?");
        puts("1-SIM 2-NÃO"); 
        do{
            esc=getch(); 
        }while(esc!='1' && esc!='2'); 
    }while(esc!='2'); 
    return 0; 
}

int calculoDelta(double a,double b,double c,double *r1, double *r2){ //vai retornar os valores das raízes e o tipo de caso
    double delta; 

    delta=(b*b)-4*a*c; //calculdo do delta 

    if(delta<0){
        return 0;
    }else if(delta==0){
        calculoRaizes(delta,a,b,r1,r2); //como o endereço já esta na 1 função , é so repassar normalmente 
        return 1;
    }else{
        calculoRaizes(delta,a,b,r1,r2);
        return 2; 
    }
}

void calculoRaizes(double delta, double a, double b, double *r1, double *r2){
    *r1=(-b+sqrt(delta))/(2*a); //alterou diretamente a variavel da raiz na MAIN
    *r2=(-b-sqrt(delta))/(2*a); 
    return; 
}
