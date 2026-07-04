# Exercício Python 048: Faça um programa que calcule a soma entre todos os números que são múltiplos de três e impares que se encontram no intervalo de 1 até 500.

resposta = 0 
di = 0;

for i in range(1,501,1):
    if(i%3==0 and i%2!=0):
        resposta = resposta + i 
        di = di + 1

print(di)
print(resposta)