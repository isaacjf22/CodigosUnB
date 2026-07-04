#Exercício Python 065: Crie um programa que leia vários números inteiros pelo teclado.
#  No final da execução, mostre a média entre todos os valores e qual foi o maior e o menor valores lidos. 
# O programa deve perguntar ao usuário se ele quer ou não continuar a digitar valores.

maior = 0 
menor = 10000000

#media
t = 0 
q = 0 

esc = ""

while esc!='n':
    n = int(input("Digite um valor: "))
    if n>maior:
        maior = n 
    if n<menor:
        menor = n 
    t+=n
    q+=1
    print()
    esc = input("Deseja continuar adicionando números? S-Sim ou N-Não :").lower()

print(f"A média dos valores digitados {t/q:.2f}")
print(f"O maior número: {maior} / O menor número: {menor}")


