#Exercício Python 068: Faça um programa que jogue par ou ímpar com o computador. 
# O jogo só será interrompido quando o jogador perder, mostrando o total de vitórias consecutivas que ele conquistou no final do jogo
from random import randint

print("="*20)
print("JOGO DO PAR OU IMPAR")
print("="*20)
v = 0 #quantidade de vitorias 
while True:
    n = int(input("Digite um valor de 0 a 10: "))
    c = randint(0,10)
    esc = input("Impar[I] ou Par[P]? -->").lower()
    soma = n+c
    print(f"A soma foi {soma}")
    if (esc=='i' and soma%2!=0) or (esc=='p' and soma%2==0):
        print("Você venceu! Vamos jogar denovo...")
        v+=1
    else:
        print("Você perdeu!")
        break
print(f"Você ganhou {v} vez(es)")

