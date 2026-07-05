#Exercício Python 101: Crie um programa que tenha uma função chamada voto() 
# que vai receber como parâmetro o ano de nascimento de uma pessoa, retornando um valor literal indicando se uma pessoa tem voto NEGADO, OPCIONAL e OBRIGATÓRIO nas eleições.
from datetime import datetime

def voto(ano):
    idade = datetime.now().year - ano 
    if (idade)>=18:
        print(f"Com {idade} anos: OBRIGATÓRIO")
    elif (idade)>=16:
        print(f"Com {idade} anos: OPCIONAL")
    else: 
        print(f"Com {idade} anos: NEGADO")
    

i = int(input("Em que ano você nasceu? "))
voto(i)
