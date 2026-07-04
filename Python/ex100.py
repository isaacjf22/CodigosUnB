#Exercício Python 100: Faça um programa que tenha uma lista chamada números e duas funções chamadas sorteia() e somaPar(). 
# A primeira função vai sortear 5 números e vai colocá-los dentro da lista e 
# a segunda função vai mostrar a soma entre todos os valores pares sorteados pela função anterior.
from random import randint
from time import sleep

numeros = []

def sorteio():
    return randint(1,9)

def somaPar(*nums):
    s = 0
    for n in nums:
        if n%2==0: #se par 
            s+=n
    return s


print("Sorteando 5 valores da lista:", end=" ")
for i in range(5):
    n = sorteio()
    print(n, end=" ", flush=True)
    numeros.append(n)
    sleep(1)

print(f"\nSomando os valores pares de {numeros}, temos {somaPar(*numeros)}.")

 