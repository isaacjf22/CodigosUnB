#Exercício Python 074: Crie um programa que vai gerar cinco números aleatórios e colocar em uma tupla. 
# Depois disso, mostre a listagem de números gerados e também indique o menor e o maior valor que estão na tupla.
from random import randint

t = (randint(0,20),randint(0,20),randint(0,20),randint(0,20),randint(0,20))
print("Tupla dos números sorteados")
print("=*="*10)
print(t)
print("=*="*10)
print(f"O menor número sorteado da tupla: {min(t)}")
print(f"O maior número sorteado da tupla: {max(t)}")
