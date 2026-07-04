#Exercício Python 098: Faça um programa que tenha uma função chamada contador(), 
# que receba três parâmetros: início, fim e passo. Seu programa tem que realizar três contagens através da função criada:

# a) de 1 até 10, de 1 em 1
# b) de 10 até 0, de 2 em 2
# c) uma contagem personalizada

from time import sleep 

def contador(inicio,fim,passo):
    print(f"Contagem de {inicio} até {fim} de {passo} em {passo}")
    if inicio>fim: #passo vai reduzir 
        passo = -passo
    for i in range(inicio,fim+1,passo):
        print(i, end=" ", flush=True) #flsuh força o for mostrar o numero logo 
        sleep(1)
    print("FIM!")

print("=+="*30)
contador(1,10,1)
print("=+="*30)
contador(10,0,2)
print("=+="*30)
print("Agora é a sua vez de personalizar a contagem!")
i = int(input("Inicío: "))
f = int(input("Fim: "))
p = int(input("Passo: "))
print("=+="*30)
contador(i,f,p)
