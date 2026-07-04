#Exercício Python 094: Crie um programa que leia nome, sexo e idade de várias pessoas,
#  guardando os dados de cada pessoa em um dicionário e todos os dicionários em uma lista. No final, mostre: 
# A) Quantas pessoas foram cadastradas
# B) A média de idade
# C) Uma lista com as mulheres
# D) Uma lista de pessoas com idade acima da média

lista = []
m = [] #mulheres 
ac = [] #acima da media 
pessoa = {}

t = 0 

#entrada
while True:
    pessoa["nome"] = input("Nome: ")
    pessoa["idade"] = int(input("Idade: "))
    t += pessoa["idade"]
    pessoa["sexo"] = input("Sexo [M/F]: ").lower()
    while pessoa["sexo"] not in "mf":
        print("Inválido! Escolha M ou F")
        pessoa["sexo"] = input("Sexo [M/F]: ").lower()
    lista.append(pessoa.copy())
    char = input("Deseja continuar? [S/N]")
    while char not in "SsNn":
        print("Inválido! Escolha S ou N")
        char = input("Deseja continuar? [S/N]")
    if char in "Nn":
        break

media = t/len(lista)

for pessoa in lista: #laço de analise 
    if pessoa["sexo"]=="f":
        m.append(pessoa["nome"])
    if pessoa["idade"]>=media:
        ac.append(pessoa)

#saida
print("=+="*20)
print(f"A quantidade de pessoas registradas foram : {len(lista)}")
print(f"A média das idades foi {media:.2f}")
print(f"Mulheres na pesquisa : ", end="")
for nome in m:
    print(nome, end=', ')
print(f"\nPessoas com idade acima da média:")
for pessoa in ac:
    print(f"nome = {pessoa["nome"]}; sexo = {pessoa["sexo"].upper()}; idade = {pessoa["idade"]}")