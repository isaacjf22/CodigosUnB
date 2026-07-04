#Exercício Python 22: Crie um programa que leia o nome completo de uma pessoa e mostre:
#– O nome com todas as letras maiúsculas e minúsculas.
#– Quantas letras ao todo (sem considerar espaços).
#– Quantas letras tem o primeiro nome.

nome = input("Nome completo: ")

print(f"Nome tudo maiúsculo: {nome.upper()}")
print(f"Nome tudo minúsculo: {nome.lower()}")
print(f"Quantidade de letras sem contar espaços: {len(nome) - nome.count(' ')}") #como as dus funções retornam int , ent pode fazer operação
print(f"Quantidade de letras do primeiro nome: {nome.find(' ')}") #vai dizer a posição do primeiro espaço, ou seja, quantidade de letras do primeiro 
#nome antes do espaço
