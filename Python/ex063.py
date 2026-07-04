#Exercício Python 063: Escreva um programa que leia um número N inteiro qualquer 
# e mostre na tela os N primeiros elementos de uma Sequência de Fibonacci. 

# Ex: 0 - 1 - 1 - 2 - 3 - 5 - 8

a = 0 
b = 1 
cont = 0

n = int(input("Quantos termos de Fibonacci você quer ver? "))

while(cont<n):
    print(f"{a} - ", end="")
    s = a+b 
    a = b
    b = s 
    cont+=1

print("FIM")