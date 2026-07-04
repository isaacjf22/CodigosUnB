#Exercício Python 087: Aprimore o desafio anterior, mostrando no final: 
# A) A soma de todos os valores pares digitados.
# B) A soma dos valores da terceira coluna.
# C) O maior valor da segunda linha.

lista = [[0,0,0],[0,0,0],[0,0,0]]

somaP = 0 
somaC3 = 0
maiorL2 = 0 

for i, linha in enumerate(lista):
    for j, coluna in enumerate(linha):
        lista[i][j] = int(input(f"Adicione um elemento a matriz [{i+1},{j+1}]: "))
        n = lista[i][j]
        if n%2==0:
            somaP+=n
        if j==2:
            somaC3+=n
        if i==1 and n>maiorL2:
            maiorL2=n

for linha in lista:
    for coluna in linha:
        print(coluna, end=' ')
    print()

print(f"A soma dos pares da matriz : {somaP}")
print(f"A soma dos números da coluna 3: {somaC3}")
print(f"O maior da segunda linha é {maiorL2}")
        
    
