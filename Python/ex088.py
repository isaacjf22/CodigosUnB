#Exercício Python 088: Faça um programa que ajude um jogador da MEGA SENA a criar palpites.O programa vai perguntar quantos jogos serão 
# gerados e vai sortear 6 números entre 1 e 60 para cada jogo, cadastrando tudo em uma lista composta.
from random import randint
from time import sleep

jogos = int(input("Quantos jogos serão realizados? -> "))

sorteios = []
jogo = []

for i in range(jogos): #sorteios 
    for j in range(6): #jogo
        n = randint(1,60)
        if n in jogo: #evitar repetição de número 
            while n in jogo: #enquanto pegar um numero q ja tem na lista , vai continuar fazendo o sorteio 
                n = randint(1,60)
            jogo.append(n) #quando encontrar um q n esta , ele add
        else:
            jogo.append(n)
    jogo.sort()
    sorteios.append(jogo[:])
    jogo.clear()

print("="*5, f"Sorteando {jogos} jogos", "="*5)
for i, jogo in enumerate(sorteios):
    print(f"Jogo {i+1}: {jogo}")
    sleep(1)
print()
print(sorteios)
