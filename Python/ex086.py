#Exercício Python 086: Crie um programa que declare uma matriz de dimensão 3x3 e preencha com valores lidos pelo teclado. 
# No final, mostre a matriz na tela, com a formatação correta.

lista = [[[],[],[]],[[],[],[]],[[],[],[]]]

linhas = int(input("Linhas: "))
colunas = int(input("Colunas: "))

#criação de matriz n definida 
a = [[]*colunas for l in range(linhas)] #primeiro tamanho da lista de dentro , segundo a quantidade de listas 

for i, linha in enumerate(lista):
    for j, coluna in enumerate(linha):
        coluna.append(int(input(f"Adicione um elemento a matriz [{i},{j}]: ")))

for linha in lista:
    for coluna in linha:
        print(coluna, end=' ')
    print()

print(a)