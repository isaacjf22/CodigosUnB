#Exercício Python 075: Desenvolva um programa que leia quatro valores pelo teclado e guarde-os em uma tupla. No final, mostre:

# A) Quantas vezes apareceu o valor 9.
# B) Em que posição foi digitado o primeiro valor 3.
# C) Quais foram os números pares.

a,b,c,d = map(int, input("Digites 4 valores que serão analisados ->").split())

t = (a,b,c,d)

c9 = 0
pares = ""
for i in t:
    if(i == 9):
        c9+=1
    if(i%2==0):
        f = str(i)
        pares+=f + " | "
print(f"Você digitou os números: {t}")
print(f"O número nove apareceu: {c9} vez(es)")
print(f"Posição do primeiro valor 3 : {t.index(3)+1}°")
print(f"Os números que são pares: {pares}")
