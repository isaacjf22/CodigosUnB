# Exercício Python 043: Desenvolva uma lógica que leia o peso e a altura de uma pessoa, calcule seu Índice de 
# Massa Corporal (IMC) e mostre seu status, de acordo com a tabela abaixo:

#     IMC abaixo de 18,5: Abaixo do Peso
#     Entre 18,5 e 25: Peso Ideal
#     25 até 30: Sobrepeso
#     30 até 40: Obesidade
#     Acima de 40: Obesidade Mórbida
peso = float(input("Digite seu peso em Kg: "))
h = float(input("Digite sua altura em metros: "))

imc = peso/(h**2)

print(f"O seu IMC foi deu {imc:.2f}")

if imc>40:
    print("Seu status: OBESIDADE MÓRBIDA")
elif imc>30:
    print("Seu status: OBESIDADE")
elif imc>25:
    print("Seu status: SOBREPESO")
elif imc>18.5:
    print("Seu status: PESO IDEAL")
else:
    print("Seu status: ABAIXO DO PESO")
