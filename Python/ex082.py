#Exercício Python 082: Crie um programa que vai ler vários números e colocar em uma lista. 
# Depois disso, crie duas listas extras que vão conter 
# apenas os valores pares e os valores ímpares digitados, respectivamente. Ao final, mostre o conteúdo das três listas geradas.

l = []

while True:
    l.append(int(input("Digite um valor: ")))
    esc = input("Deseja continuar? [S/N]").lower()
    if esc=='n':
        break

p = []
i = []

for numero in l:
    if numero%2==0: #par
        p.append(numero)
    else: #impar
        i.append(numero)

print(f"Lista geral: {l}")
print(f"Lista com somente números pares: {p}")
print(f"Lista com somente números ímpares: {i}")