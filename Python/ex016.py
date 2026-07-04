#Exercício Python 16: Crie um programa que leia um número Real qualquer pelo teclado e mostre na tela a sua porção Inteira.
from math import trunc

x = float(input("Digite qualquer número real: "))

print(f"O seu número sem parte decimal é : {trunc(x)}")