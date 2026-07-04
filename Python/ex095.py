#Exercício Python 095: Aprimore o desafio 93 para que ele funcione com vários jogadores, 
# incluindo um sistema de visualização de detalhes do aproveitamento de cada jogador


#sempre se atentar ao nome da chave quando for fazer referencia 

jogadores = []
jogador = {}

while True: 
    jogador["nome"] = input("Nome do jogador: ")
    partidas = int(input("Quantas partidas ele jogou? -> "))
    g = []
    total = 0
    for i in range(partidas):
        gol = int(input(f"Quantos gols ele fez na {i+1}° partida? -> "))
        g.append(gol) 
        total += gol 
    jogador["gols"] = g[:]
    jogador["total"] = total
    print()
    jogadores.append(jogador.copy()) #add o dicionario dentro da lista 
    while True:
        esc = input("Deseja continuar? [S/N] ")
        if esc not in "SsNn":
            print("Inválido! Digite uma opção válida!")
        else:
            break
    if esc in "Nn":
        break      
print("=+=" *25)
print("cod      nome      gols     total")
print("--------------------------------")
for posicao, jogador in enumerate(jogadores):
    print(f"{posicao+1}      {jogador["nome"]}      {jogador["gols"]}     {jogador["total"]}")
print("--------------------------------")
while True: 
    n = int(input("Mostrar dados de qual jogador? (999 para parar) -> ")) - 1
    if n==998:
        break
    #digitou 5 , vira n = 4
    #lista com 4 jogadores vira 0 1 2 3 , len = 4 , logo n pode ser igual ao len e maior que ele , pois n existe indice 4 e acima dele 
    while n>=len(jogadores) or n<0:
        print("Jogador inválido! Escolha os que existem.")
        n = int(input("Mostrar dados de qual jogador? (999 para parar) -> ")) - 1
    print(f"--- LEVANTAMENTO DO JOGADOR {jogadores[n]["nome"]}")
    for partida, gols in enumerate(jogadores[n]["gols"]):
        print(f"    No jogo {partida+1} fez {gols} gols")

print("ENCERRADO")

