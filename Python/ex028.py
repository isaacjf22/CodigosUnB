#Exercício Python 028: Escreva um programa que faça o computador "pensar" em um número inteiro entre 0 e 5 e peça para o usuário tentar descobrir qual foi o número escolhido pelo computador. 
# O programa deverá escrever na tela se o usuário venceu ou perdeu

import random

sorteio = random.randint(0,5)
print(sorteio)
tentativa = int(input("Tente descobrir um valor entre 0 a 5: "))



if(tentativa==sorteio):
    print("Parabéns, você acertou!")
else:
    print(f"Infelizmente você errou! O número sorteado era {sorteio}")

