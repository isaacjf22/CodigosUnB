#Exercício Python 078: Faça um programa que leia 5 valores numéricos e guarde-os em uma lista. 
# No final, mostre qual foi o maior e o menor valor digitado e as suas respectivas posições na lista. 

num = []

maior = 0
menor = 10000
posicaoMaior = ""
posicaoMenor = ""
for i in range(5):
    num.append(int(input(f"Digite o número da posição {i} -> ")))
    if num[i]>maior:
        maior = num[i]
    if num[i]<menor:
        menor = num[i]

for i in range(len(num)): #analisar as posições 
    if num[i] == maior: 
        posicaoMaior += str(i) + " "
    if num[i] == menor:
        posicaoMenor += str(i) + " "

print(f"A lista digitada foi {num}")
print(f"O maior número foi {maior} e ele estava nas posições: {posicaoMaior}")
print(f"O maior número foi {menor} e ele estava nas posições: {posicaoMenor}")


