#Exercício Python 067: Faça um programa que mostre a tabuada de vários números, um de cada vez, para cada valor digitado pelo usuário.
#  O programa será interrompido quando o número solicitado for negativo. 

while True:
    n = int(input("Você quer ver tabuada de qual número? "))
    if n<=0:
        break
    for i in range(1,11,1):
        print(f"{n} X {i} = {n*i}")




