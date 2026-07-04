#xercício Python 091: Crie um programa onde 4 jogadores joguem um dado e tenham resultados aleatórios.
#  Guarde esses resultados em um dicionário em Python. 
# No final, coloque esse dicionário em ordem, sabendo que o vencedor tirou o maior número no dado

from random import randint
from operator import itemgetter

jogo = {}

for i in range(0,4):
    jogada = randint(1,6)
    print(f"O jogador {i+1}: tirou {jogada} do dado!")
    jogo[f"jg{i}"]=jogada

ordenacao = sorted(jogo.items(), key=itemgetter(1), reverse=True)

print("Ranking:")

for posicao, (jogador, resultado) in enumerate(ordenacao): #key e depois valor 
    print(f"{posicao+1}° Jogador {jogador} = {resultado}")


