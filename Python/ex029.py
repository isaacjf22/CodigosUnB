#Exercício Python 029: Escreva um programa que leia a velocidade de um carro. Se ele ultrapassar 80Km/h, mostre uma mensagem dizendo 
# que ele foi multado. A multa vai custar R$7,00 por cada Km acima do limite.

km = float(input("Digite a velocidade do seu carro em Km/h: "))

if km>80:
    multa = (km-80)*7
    print(f"Você foi multado! Irá pagar R${multa:.2f}")
else:
    print("Você está dentro do limite!")


