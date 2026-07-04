#Exercício Python 13: Faça um algoritmo que leia o salário de um funcionário e mostre seu novo salário, com 15% de aumento.

valor = float(input("Valor que vai sofrer aumento de 15% : R$"))
a = valor*1.15

print(f"O valor após o aumento foi R${a:.2f}")