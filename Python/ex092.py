#Exercício Python 092: Crie um programa que leia nome, 
# ano de nascimento e carteira de trabalho e cadastre-o (com idade) em um dicionário.
#  Se por acaso a CTPS for diferente de ZERO, o dicionário receberá também o ano de contratação e o salário.
#  Calcule e acrescente, além da idade, com quantos anos a pessoa vai se aposentar.
#você tem q trabalhar por 35 anos na empresa para poder aposentar 

from datetime import datetime

pessoa = {}

pessoa["nome"] = input("Nome: ")
ano = int(input("Ano de nascimento: "))
pessoa["idade"] = datetime.now().year - ano 
pessoa["ctps"] = int(input("Carteira de Trabalho (0 caso não tenha): "))

if pessoa["ctps"]!=0:
    pessoa["contratação"] = int(input("Ano de contratação: "))
    pessoa["salário"] = float(input("Salário: R$"))
    pessoa["aposentadoria"] = pessoa["idade"] + ((pessoa["contratação"]+35) - datetime.now().year)
    
for chave, dado in pessoa.items():
        print(f"{chave}: {dado}")



