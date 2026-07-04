#Exercício Python 060: Faça um programa que leia um número qualquer e mostre o seu fatorial.

n = int(input("Qual número você quer saber o fatorial? "))

cont=1
f=1
if n==0:
    print("O fatorial de 0 é 1")
else:
    while(cont<=n):
        f=f*cont
        cont+=1
    print(f"O fatorial de {n} é {f}")