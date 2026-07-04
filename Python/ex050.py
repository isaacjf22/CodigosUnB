# Exercício Python 050: Desenvolva um programa que leia seis números inteiros 
# e mostre a soma apenas daqueles que forem pares. Se o valor digitado for ímpar, desconsidere-o.

soma=0
for i in range(6):
    n = int(input(f"{i+1}º Valor: "))
    if(n%2==0):
        soma=soma+n

print(soma)