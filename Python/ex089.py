#Exercício Python 089: Crie um programa que leia nome e duas notas de vários alunos e guarde tudo em uma lista composta.
#  No final, mostre um boletim contendo a média de cada um e permita que o usuário possa mostrar as notas de cada aluno individualmente.

notas = []
aluno = []

while True:
    aluno.append(input("Qual é o nome do aluno? -> "))
    aluno.append(float(input("Qual é a primeira nota? -> ")))
    aluno.append(float(input("Qual é a segunda nota? -> ")))
    notas.append(aluno[:])
    aluno.clear()

    esc = input("Deseja adicionar outro aluno? [S/N] ->")
    if esc in "Nn":
        break

print()
for i,  aluno in enumerate(notas):
    print(f"{i} Aluno: {aluno[0]} | Média: {sum(aluno[1:])/len(aluno[1:]):.2f}")

while True:
    i = int(input("Deseja ver as notas de qual aluno? (999 Interrompe) -> "))
    if i == 999:
        break
    print(f"Aluno: {notas[i][0]} | Notas: {notas[i][1:]}")