#Exercício Python 099: Faça um programa que tenha uma função chamada maior(), que receba vários parâmetros com valores inteiros.
# Seu programa tem que analisar todos os valores e dizer qual deles é o maior.
from time import sleep

def maior(*numeros):
    print("Analisando os valores passados...")
    for i,  numero in enumerate(numeros): 
        print(numero, end=" ", flush=True)
        if i==0:
            maior=numero
        if numero>maior:
            maior = numero
        sleep(1)
    print(f"Foram analisados {len(numeros)} números ao todo.")
    print(f"O maior valor informado foi {maior}.")
    print("=*="*30)

print("=*="*30)
maior(2,9,4,5,7,1)
maior(4,7,0)
maior(1,2)
maior(6)
print("Sua vez!")
l = []
while True:
    num = int(input("Digite um valor: "))
    l.append(num)
    esc = input("Deseja adicionar outro valor? [S/N] ")
    if esc in "Nn":
        break
maior(*l) #o asterisco faz que a lista quebre e vire o parametro normal 
