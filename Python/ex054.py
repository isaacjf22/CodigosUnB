#Exercício Python 054: Crie um programa que leia o ano de nascimento de sete pessoas. 
# No final, mostre quantas pessoas ainda não atingiram a maioridade e quantas já são maiores.

menor = 0
maior = 0

anoA = int(input("Qual é o ano atual? "))

for i in range(7):
    ano = int(input(f"Digite o {i+1}º ano: "))
    n = anoA - ano 
    if(n>=18):
        maior = maior+ 1
    else:
        menor = menor +1

print(f"Os maiores são {maior} pessoas e menores são {menor} pessoas") 
    
