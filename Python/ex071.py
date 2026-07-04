# Exercício Python 071: Crie um programa que simule o funcionamento de um caixa eletrônico. 
# No início, pergunte ao usuário qual será o valor a ser sacado (número inteiro) 
# e o programa vai informar quantas cédulas de cada valor serão entregues.
# OBS: considere que o caixa possui cédulas de R$50, R$20, R$10 e R$1.

n = int(input("Qual é o valor a ser sacado?"))

n50 = n//50
n = n%50 
n20 = n//20
n = n%20 
n10 = n//10
n = n%10
n1 = n

print("CÉDULAS")
if n50>0:
    print(f"R$50.00: {n50}")
if n20>0:
    print(f"R$20.00: {n20}")
if n10>0:
    print(f"R$10.00: {n10}")
if n1>0:
    print(f"R$1.00: {n1}")