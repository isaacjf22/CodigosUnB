#Exercício Python 090: Faça um programa que leia nome e média de um aluno, guardando também a situação em um dicionário. 
# No final, mostre o conteúdo da estrutura na tela.

nome = (input("Nome: "))
media = float(input("Média: "))

if media>=7:
    sit = "Aprovado"
elif media>=5:
    sit = "Recuperação"
else:
    sit = "Reprovado"

aluno = {"Nome": nome, "Média": media, "Situação":sit}

for k, v in aluno.items():
    print(f"{k}: {v}")
    
