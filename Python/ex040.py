# Exercício Python 040: Crie um programa que leia duas notas de um aluno e calcule sua média, mostrando uma mensagem no final, 
# de acordo com a média atingida:

#     Média abaixo de 5.0: REPROVADO
#     Média entre 5.0 e 6.9: RECUPERAÇÃO
#     Média 7.0 ou superior: APROVADO

n1, n2 = map(float, input("Insira as notas 1 e 2, respectivamente: ").split())

media = (n1+n2)/2

if media>=7:
    print(f"Aprovado com média {media:.2f}")
elif media>=5:
    print(f"Recuperação com média {media:.2f}")
else:
    print(f"Reprovado com média {media:.2f}")