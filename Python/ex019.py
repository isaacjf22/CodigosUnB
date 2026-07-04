#Exercício Python 19: Um professor quer sortear um dos seus quatro alunos para apagar o quadro. 
# Faça um programa que ajude ele, lendo o nome dos alunos e escrevendo na tela o nome do escolhido.
import random

n1,n2,n3,n4= input("Digite o nome dos alunos: ").split()

lista = [n1,n2,n3,n4]

print(f"O aluno escolhido foi o {random.choice(lista)}")