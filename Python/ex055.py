#Exercício Python 055: Faça um programa que leia o peso de cinco pessoas. No final, mostre qual foi o maior e o menor peso lidos.

maior = 0 
menor = 1000

for i in range(5):
    p = float(input(f"Digite o peso da {i+1}º pessoa: "))
    if(p>maior):
        maior = p
    if(p<menor):
        menor = p 

print(f"O obeso tem {maior} kg e o anoréxico tem {menor} kg")