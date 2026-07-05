#Exercício Python 106: Faça um mini-sistema que utilize o Interactive Help do Python. O usuário vai digitar o comando e o manual vai aparecer. 
# Quando o usuário digitar a palavra 'FIM', o programa se encerrará.
vermelho = '\033[31m'
verde = '\033[32m'
azul = '\033[34m'
negrito = '\033[1m'
limpa = '\033[m'

def iHelp(texto):
    help(texto)


while True:
    t = input(f"{verde}Função ou Biblioteca:{limpa}").lower()
    if t=="fim":
        break
    else:
        iHelp(t)








