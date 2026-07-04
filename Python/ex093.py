#Exercício Python 093: Crie um programa que gerencie o aproveitamento de um jogador de futebol.
#  O programa vai ler o nome do jogador e quantas partidas ele jogou. Depois vai ler a quantidade de gols feitos em cada partida.
#  No final, tudo isso será guardado em um dicionário, incluindo o total de gols feitos durante o campeonato.

jogador = {}

jogador["nome"] = input("Nome do jogador: ")

partidas = int(input(f"Quantas partidas o jogador {jogador['nome']} participou?"))

p = []
t = 0
for i in range(partidas):
    g = int(input(f"Quantos gols foram marcados na {i+1}° partida? -> "))
    t+=g
    p.append(g)

jogador["gols"] = p[:] #copia da lista 
jogador["total"] = t

print("=+=" * 30)
print(jogador)
print("=+=" * 30)
for key, value in jogador.items():
    print(f"O campo {key} tem o valor {value}")
print("=+=" * 30)
print(f"O jogador {jogador['nome']} jogou {partidas} partidas.")
for i, valor in enumerate(jogador["gols"]):
    print(f"   => Na partida {i+1}, fez {valor} gols")
print(f"Foi um total de {jogador['total']} gols.")