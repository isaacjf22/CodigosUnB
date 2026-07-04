#Exercício Python 033: Faça um programa que leia N números e mostre qual é o maior e qual é o menor.

n = int(input("Quantidade de números à ser analisado: "))

maior = -10000000000000
menor = 100000000000000

for i in range(n):
    num = int(input())
    if(num>maior):
        maior = num 
    if(num<menor):
        menor = num 

print(f"O maior número dos analisados é o {maior} e o menor número é o {menor}")