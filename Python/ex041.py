# Exercício Python 041: A Confederação Nacional de Natação precisa de um programa que leia o ano de nascimento 
# de um atleta e mostre sua categoria, de acordo com a idade:

#     Até 9 anos: MIRIM
#     Até 14 anos: INFANTIL
#     Até 19 anos: JÚNIOR
#     Até 25 anos: SÊNIOR
#     Acima de 25 anos: MASTER

anoN = int(input("Digite o ano de nascimento do atleta: "))
anoA = int(input("Digite o ano atual: "))

ano = anoA-anoN

print(f"O atleta tem {ano} anos")
if ano>25:
    print("Atleta MASTER")
elif ano>19:
    print("Atleta SÊNIOR")
elif ano>14:
    print("Atleta JÚNIOR")
elif ano>9:
    print("Atleta INFANTIL")
else:
    print("Atleta MIRIM")

