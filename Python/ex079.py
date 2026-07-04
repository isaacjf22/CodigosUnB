#Exercício Python 079: Crie um programa onde o usuário possa digitar vários valores numéricos e cadastre-os em uma lista.
#  Caso o número já exista lá dentro, ele não será adicionado. 
# No final, serão exibidos todos os valores únicos digitados, em ordem crescente. 

l = []
while True:
    n = int(input("Digite um número: "))
    if n in l:
        print("Já existe esse número na lista!")
    else:
        print("Número adicionado com sucesso!")
        l.append(n)
    esc = input("Deseja continuar? [S/N] ").lower()
    if esc =='n':
        break   
l.sort()
print(f"A lista de valores únicos ordenada é : {l}")