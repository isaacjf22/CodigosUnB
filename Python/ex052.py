# Exercício Python 052: Faça um programa que leia um número inteiro e diga se ele é ou não um número primo.
#Mostre os termos que dividiu e quantos foram

from rich import print 

n = int(input("Digite um valor inteiro: "))

resposta = ""
primo = True 
cont = 0

if n==1:
    print("O número 1 não é primo!")
else:
    for i in range(1,n,1): #i f c 
        if(n%i==0):
            print(f"[green]{i}[/green]")
            primo = False #se encontrar algum outro divisor só cancelar a condição 
            cont=cont+1 
        else:
            print(f"[red]{i}[/red]")
    print(f"[green]{i+1}[/green]") #ultimo termo , é garantido que a divisão sempre ocorre no ultimo 

    if(primo):
        print(f"O número {n} é primo!")
    else:
        print(f"O número {n} não é primo!")
        print(f"A quantidade de divisores foi {cont+1}")

            



