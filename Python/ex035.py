#Exercício Python 035: Desenvolva um programa que leia o comprimento de três retas e diga ao usuário se elas podem ou não formar um triângulo.

a,b,c = map(float, input("Digite os valores dos lados A, B e C ,respectivamente, para verificar se é triângulo: ").split()) ##tem q dividir para 
#ficar nas suas variaveis ne

if(a<b+c) or (b<a+c) or (c<a+b):
    print("É triângulo")
else:
    print("Não é triângulo")