# Exercício Python 049: Refaça o DESAFIO 009, mostrando a tabuada de um número que o usuário escolher, só que agora utilizando um laço for.

n = int(input("Digite um número para ver sua tabuada de 1 a 10: "))

for i in range(11): #final n-1
    print(f"{n} X {i} = {n*i}")


