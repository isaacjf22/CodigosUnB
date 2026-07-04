#Exercício Python 037: Escreva um programa em Python que leia um número inteiro qualquer e peça para 
# o usuário escolher qual será a base de conversão: 1 para binário, 2 para octal e 3 para hexadecimal.

n = int(input("Digite um número: "))
esc = int(input("Qual conversão você quer realizar? 1 BINÁRIO / 2 OCTAL / 3 HEXADECIMAL -> "))

match esc:
    case 1:
        print(f"O número {n} em binário é {bin(n)[2:]}") #vai pular o prefixo 0b indice 0 1 
    case 2:
        print(f"O número {n} em octal é {oct(n)[2:]}")
    case 3:
        print(f"O número {n} em hexadecimal é {hex(n)[2:]}")
    case _:
        print("Escolha inválida!")