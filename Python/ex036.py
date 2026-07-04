#Exercício Python 036: Escreva um programa para aprovar o empréstimo bancário para a compra de uma casa. 
# Pergunte o valor da casa, o salário do comprador e em quantos anos ele vai pagar. 
# A prestação mensal não pode exceder 30% do salário ou então o empréstimo será negado.

print("-*-" *20)
texto = "Empréstimo"
print(texto.center(20))
print("-*-" *20)
print()

salario = float(input("Digite o seu salário: "))
casa = float(input("Digite o valor da casa: "))
ano = int(input("Em quanto tempo você quer pagar o empréstimo (em anos): "))

p = casa/(ano*12)

if(p>(salario*0.3)):
    print("Empréstimo negado!")
else:
    print("Empréstimo concedido!")



