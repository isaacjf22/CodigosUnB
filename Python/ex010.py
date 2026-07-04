#Exercício Python 10: Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e mostre quantos dólares ela pode comprar. 

c = float(input("Quanto você tem na carteira? "))
cot = float(input("Qual é a cotação do dolar nesse momento? "))
t = c/cot

print(f"Com R${c:.2f} consegue obter U${t:.2f}")