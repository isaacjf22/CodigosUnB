# Exercício Python 044: Elabore um programa que calcule o valor a ser pago por um produto, considerando o seu preço normal e condição de pagamento:

#     à vista dinheiro/cheque: 10% de desconto
#     à vista no cartão: 5% de desconto
#     em até 2x no cartão: preço formal
#     3x ou mais no cartão: 20% de juros simples 

valor = float(input("Digite o valor do produto: "))
print("Qual será a forma de pagamento?")
print("1-À vista dinheiro/cheque 2-À vista no cartão 3-2x no cartão 4-3x ou mais(juros de 20%)")

esc = int(input("-> "))

match esc:
    case 1: 
        print(f"Você teve um desconto de 10%! Valor a ser pago: R${valor*0.9:.2f}")
    case 2:
        print(f"Você teve um desconto de 5%! Valor a ser pago: R${valor*0.95:.2f}")
    case 3:
        print(f"Valor das parcelas em 2x: R${(valor/2):.2f}")
    case 4:
        q = int(input("Qual é a quantidade de parcelas? -> "))
        juros = valor*0.2*q
        total = valor+juros
        print(f"Em {q} parcelas o valor de cada um será: R${(total/q):.2f}")
    case _:
        print("Opção inválida!")
