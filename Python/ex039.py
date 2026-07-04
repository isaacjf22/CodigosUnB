# Exercício Python 039: Faça um programa que leia o ano de nascimento de um jovem e informe, de acordo com a sua idade,
# se ele ainda vai se alistar ao serviço militar, se é a hora exata de se alistar ou se já passou do tempo do alistamento. 
# Seu programa também deverá mostrar o tempo que falta ou que passou do prazo.

anoN = int(input("Digite seu ano de nascimento: "))
anoA = int(input("Digite o ano atual: "))

ano = anoA - anoN 

print(f"Quem nasceu em {anoN} tem {ano} anos em {anoA}")

if ano > 18:
    print(f"Vocẽ já deveria ter se alistado há {ano-18} anos")    
elif ano < 18:
    print(f"Você ainda não pode se alistar, falta {18-ano} anos")    
else:
    print("Você está no ano do alistamento!")

print(f"O ano do seu alistamento {anoN+18}")