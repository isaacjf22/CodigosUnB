#Exercício Python 097: Faça um programa que tenha uma função chamada escreva(),
#  que receba um texto qualquer como parâmetro e mostre uma mensagem com tamanho adaptável.

# Ex: 
# escreva('Olá, Mundo!')
# Saída:
# ~~~~~~~~~
#  Olá, Mundo!
# ~~~~~~~~~

def escreva(texto):
    c = 2
    for letra in texto:
        c+=1
    print("~"*c)
    print(f" {texto} ")
    print("~"*c)

t = input("Texto: ")
escreva(t)

