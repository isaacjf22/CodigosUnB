#Exercício Python 20: O mesmo professor do desafio 19 quer sortear a ordem de apresentação de trabalhos dos alunos. 
# Faça um programa que leia o nome dos quatro alunos e mostre a ordem sorteada.
import random

n1,n2,n3,n4 = input("Nome dos alunos: ").split()

nomes = [n1,n2,n3,n4]

random.shuffle(nomes)

print("Ordem de apresentação")
print(nomes)