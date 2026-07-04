#Exercício Python 051: Desenvolva um programa que leia o primeiro termo e a razão de uma PA. 
# No final, mostre os 10 primeiros termos dessa progressão.

r = int(input("Digite a razão da PA: "))
p1 = int(input("Digite o primeiro termo da PA: "))

for i in range(10):
    print(f"A{i+1} = {p1+r*i}")