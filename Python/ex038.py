#Exercício Python 038: Escreva um programa que leia dois números inteiros e compare-os. mostrando na tela uma mensagem:
    # O primeiro valor é maior
    # O segundo valor é maior
    # Não existe valor maior, os dois são iguais

n1, n2 = map(int, input("Digite dois números para comparar : ").split())

if n1>n2:
    print(f"O 1º digitado {n1} é maior que o 2º {n2}")
elif n1<n2:
    print(f"O 1º digitado {n1} é menor que o 2º {n2}")
else:
    print("Os dois números são iguais!")

