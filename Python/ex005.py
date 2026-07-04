#Exercício Python 5: Faça um programa que leia um número Inteiro e mostre na tela o seu sucessor e seu antecessor.

x = int(input("Digite um valor: "))
ant = x-1
suc = x+1

print(f"O antecessor e sucessor do {x} são: {ant} e {suc}")