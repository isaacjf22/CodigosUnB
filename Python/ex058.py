# Exercício Python 058: Melhore o jogo do DESAFIO 028 
# onde o computador vai "pensar" em um número entre 0 e 10. Só que agora o jogador vai tentar adivinhar até acertar, 
# mostrando no final quantos palpites foram necessários para vencer.
from random import randint


sorteio = randint(1,10)
cont = 0 
esc = 123
while(esc!=sorteio):
    cont+=1
    esc = int(input("Tente descobrir o valor que o computador pensou (1 a 10): "))
    if(esc==sorteio):
        print(f"Parabéns! Você acertou o número escolhido: {sorteio}")
        print(f"Quantidade de tentativas: {cont}")
    else:
        print("Errou, tente novamente!")
   