# Exercício Python 047: Crie um programa que mostre na tela todos os números pares que estão no intervalo entre 1 e 50.

resposta = ""

for i in range(1,51,1):
    if(i%2==0):
        resposta = resposta+str(i) + " "

print(resposta)