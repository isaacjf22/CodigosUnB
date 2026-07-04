#Exercício Python 053: Crie um programa que leia uma frase qualquer e diga se ela é um palíndromo, desconsiderando os espaços.

frase = input("Digite para verificar se é palíndromo: ").lower().replace(" ","") #colocar tudo minusculo e desconsiderar espaço 

invertida1 = ""

invertida2 = frase[::-1] #o colchetes faz mudar a ordem sozinho da frase 

for i in range(len(frase)-1,-1,-1): #o ultimo nao entra no caso -1 
    invertida1 = invertida1 + frase[i] #criando a palavra invertida 

print("Teste 1")
print(invertida1)
if(frase==invertida1):
    print("É palíndromo!")
else:
    print("Não é palíndromo!")

print("Teste 2")
print(invertida2)
if(frase==invertida2):
    print("É palíndromo!")
else:
    print("Não é palíndromo!")






