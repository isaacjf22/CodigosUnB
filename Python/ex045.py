# Exercício Python 045: Crie um programa que faça o computador jogar Jokenpô com você.

from random import randint #gerar o aleatorio 
from time import sleep #pausa o console em segundos 

def sorteioC():
    valor = randint(0,2)+1
    return valor

def verificar(j, c): #
    if(j==1 and c==3) or (j==2 and c==1) or (j==3 and c==2):
        print("O jogador vence!")
        return True
    elif(j==c):
        print("Empate! Jogue novamente")
        return False 
    else:
        print("O computador vence!")
        return True

    



ganhou = False 

while(ganhou==False):
    print("Qual jogada vai realizar?")
    print("[1] PEDRA")
    print("[2] PAPEL")
    print("[3] TESOURA")
    print()
    escolha = int(input("->"))
    compp = sorteioC()
    print()
    print("JO")
    sleep(1)
    print("KEN")
    sleep(1)
    print("PO")
    sleep(1)
    print()

    match escolha:
        case 1:
            print("Jogador usou PEDRA.")
        case 2:
            print("Jogador usou PAPEL.")
        case 3:
            print("Jogador usou TESOURA.")

    match compp:
        case 1:
            print("Computador usou PEDRA.")
        case 2:
            print("Computador usou PAPEL.")
        case 3:
            print("Computador usou TESOURA.")

    print()
    ganhou = verificar(escolha,compp)

print()
print("Obrigado por jogar!")