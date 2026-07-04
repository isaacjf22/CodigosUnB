#Exercício Python 061: Refaça o DESAFIO 051, lendo o primeiro termo e a razão de uma PA, 
# mostrando os 10 primeiros termos da progressão usando a estrutura while.

n, r  = map(int, input("Qual é o primeiro termo e a razão para verificar a PA: ").split())

cont =0
while cont<=10:
    t = n + r*cont
    print(f"{cont+1}º termo: {t}")
    cont+=1

