#Exercício Python 066: Crie um programa que leia números inteiros pelo teclado.
#  O programa só vai parar quando o usuário digitar o valor 999, que é a condição de parada. 
# No final, mostre quantos números foram digitados e qual foi a soma entre elas (desconsiderando o flag).
#PRECISA UTILIZAR O BREAK 


t = 0
s = 0 
while True:
    n = int(input("Digite um valor: "))
    if n == 999:
        break
    t+=1
    s+=n

print(f"A soma = {s}")
print(f"A quantidade de números digitados = {t}")
