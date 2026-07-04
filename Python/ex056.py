#Exercício Python 056: Desenvolva um programa que leia o nome, idade e sexo de 4 pessoas. 
# No final do programa, mostre: a média de idade do grupo, qual é o nome do homem mais velho e quantas mulheres têm menos de 20 anos.

Hmaior = ""
total = 0 
m20 = 0 
maiorH = 0

for i in range(4):
    nome = input("Qual é o seu nome? ")
    idade = int(input("Qual é a sua idade? "))
    sexo = input("Qual é o seu sexo? M ou F ")
    total = total + idade
    if(sexo == "M" and idade>maiorH):
        maiorH = idade
        Hmaior = nome
    if(sexo == "F" and idade<20):
        m20=m20+1
media = total/4

print(f"A média da idade do grupo é {media:.2f} anos")
print(f"O homem mais velho é {Hmaior}")
print(f"Quantidade de mulheres menor que 20 anos é/são {m20}")

