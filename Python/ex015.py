#Exercício Python 15: Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
# quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado.

km = float(input("Quantidade de Kms rodados com o carro? "))
dias = int(input("Quantidade de dias ficou com o carro? "))

total = 60*dias + km*0.15

print(f"O total gasto foi R${total:.2f}")