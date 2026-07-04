#Exercício Python 064: Crie um programa que leia vários números inteiros pelo teclado. 
# O programa só vai parar quando o usuário digitar o valor 999, que é a condição de parada. 
# No final, mostre quantos números foram digitados e qual foi a soma entre eles (desconsiderando o flag).

n = int(input("Digite um valor para analisar: "))
soma=0
while(n!=999):
    soma+=n
    i = int(input("Digite um valor para analisar: "))
    n = i
print(f"Programa finalizado! Soma dos números digitados: {soma}")