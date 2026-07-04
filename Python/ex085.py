#Exercício Python 085: Crie um programa onde o usuário possa digitar sete valores numéricos 
# e cadastre-os em uma lista única que mantenha separados os valores pares e ímpares. 
# No final, mostre os valores pares e ímpares em ordem crescente.

num = [[],[]] #0 par 1 impar 

for i in range(7):
    n = int(input(f"Digite o {i+1}° número: "))
    if(n%2==0):
        num[0].append(n) #aq estou dizendo que na lista 0 da lista num vai ser add 
    else:
        num[1].append(n)
for listas in num:
    listas.sort()

print(f"A lista de pares : {num[0]}")
print(f"A lista de impares : {num[1]}")


