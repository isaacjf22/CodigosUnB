# #Exercício Python 084: Faça um programa que leia nome e peso de várias pessoas, guardando tudo em uma lista. No final, mostre:
# A) Quantas pessoas foram cadastradas.
# B) Uma listagem com as pessoas mais pesadas.
# C) Uma listagem com as pessoas mais leves.

p = 0 
geral = []
dado = []

maior = 0 
menor = 10000
while True:
    dado.append(input("Digite o nome do indivíduo: "))
    peso = float(input("Digite o peso desse indivíduo em KG: "))
    if peso>maior:
        maior = peso
    if peso<menor:
        menor = peso
    dado.append(peso)
    geral.append(dado[:])
    dado.clear()
    esc = input("Deseja adicionar outro indivíduo?").lower()
    if esc=='n':
        break

maiores = ""
menores = ""
for pessoa in geral: #0 nome 1 peso 
    if pessoa[1]==maior:
        maiores+=pessoa[0]+' '
    if pessoa[1]==menor:
        menores+=pessoa[0]+' '

print(f"A quantidade de pessoas registradas: {len(geral)}")
print(f"As pessoas com o maior peso de {maior} kg são : {maiores}")
print(f"As pessoas com o menor peso de {menor} kg são : {menores}")
