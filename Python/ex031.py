#Exercício Python 031: Desenvolva um programa que pergunte a distância de uma viagem em Km. 
# Calcule o preço da passagem, cobrando R$0,50 por Km para viagens de até 200Km e R$0,45 parta viagens mais longas.

km = float(input("Digite a distância percorria na sua viagem:  "))

if km<=200:
    custo = km*0.5 #tem q ser . 
    print(f"O preço da viagem foi R${custo:.2f}")
else:
    custo = km*0.45
    print(f"O preço da viagem foi R${custo:.2f}")

