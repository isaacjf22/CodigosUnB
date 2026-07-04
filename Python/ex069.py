#Exercício Python 069: Crie um programa que leia a idade e o sexo de várias pessoas. 
# A cada pessoa cadastrada, o programa deverá perguntar se o usuário quer ou não continuar. No final, mostre:
# A) quantas pessoas tem mais de 18 anos.
# B) quantos homens foram cadastrados.
# C) quantas mulheres tem menos de 20 anos. 

p18 = 0
h = 0
m20 = 0 
while True:
    i = int(input("Qual é a idade do indivíduo? -->"))
    s = input("Qual é o sexo do indivíduo, H-HOMEM ou M-MULHER? -->").lower()
    if(i>18):
        p18+=1
    if(s=='h'):
        h+=1
    if(s=='m' and i<20):
        m20+=1
    esc = input("Você quer continuar? S-Sim ou N-Não : ").lower()
    if esc=='n':
        break
print("ANÁLISE DE DADOS")
print()
print(f"Quantidade de homens: {h}")
print(f"Quantidade de mulheres menores de 20 anos: {m20}")
print(f"Quantidade de pessoas maiores que 18 anos: {p18}")
