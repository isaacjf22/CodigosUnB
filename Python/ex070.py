#xercício Python 070: Crie um programa que leia o nome e o preço de vários produtos.
#  O programa deverá perguntar se o usuário vai continuar ou não. No final, mostre:
# A) qual é o total gasto na compra.
# B) quantos produtos custam mais de R$1000.
# C) qual é o nome do produto mais barato. 

t = 0 
b = 10000000
mil=0
bn = ""
while True:
    n = input("Qual é o nome do produto? -->")
    v = float(input("Valor R$"))
    if(v<b):
        bn = n 
        b = v 
    if(v>1000):
        mil+=1
    t += v 
    esc = input("Você deseja adicionar mais algum produto? S-Sim ou N-Não ->").lower()
    if(esc=='n'):
        break

print(f"O produto mais barato foi : {bn}")
print(f"Quantidade de produtos maiores de R$1000 : {mil}")
print(f"O total gasto nessa compra: R${t:.2f}")

