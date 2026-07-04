#Exercício Python 12: Faça um algoritmo que leia o preço de um produto e mostre seu novo preço, com 5% de desconto.

valor = float(input("Qual é o valor a ser descontado?"))

nv = valor*0.95

print(f"O novo valor após o desconto de 5% é R${nv:.2f}")