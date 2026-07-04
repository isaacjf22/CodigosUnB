# Exercício Python 059: Crie um programa que leia dois valores e mostre um menu na tela:
# [ 1 ] somar
# [ 2 ] multiplicar
# [ 3 ] maior
# [ 4 ] novos números
# [ 5 ] sair do programa
# Seu programa deverá realizar a operação solicitada em cada caso.

esc = 99
x = 0
y = 0
while(esc!=5):
    print("Começa com X=0 e Y=0")
    print("[ 1 ] Somar")
    print("[ 2 ] Multiplicar")
    print("[ 3 ] Maior")
    print("[ 4 ] Novos Números")
    print("[ 5 ] Sair")
    esc = int(input("-> "))
    match esc:
        case 1:
            print(f"A soma de x = {x} e y = {y} é {x+y}")
        case 2:
            print(f"A multiplicação de x = {x} e y = {y} é {x*y}")
        case 3:
            if(x>y):
                print("O maior é o X")
            else:
                print("O maior é o Y ")
        case 4: 
            x,y = map(int, input("Quais são os valores de X e Y respectivamente: ").split())
        case 5:
            print("Saindo do programa...")
        case _: 
            print("Opção inválida!")
