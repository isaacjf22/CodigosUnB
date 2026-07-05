#Exercício Python 102: Crie um programa que tenha uma função fatorial() que receba dois parâmetros: 
# o primeiro que indique o número a calcular e outro chamado show,
#  que será um valor lógico (opcional) indicando se será mostrado ou não na tela o processo de cálculo do fatorial.
from time import sleep

def fatorial(num, show=False): #por padrão é false 
    f = 1
    if num==0:
        return 1
    for i in range(num,0,-1):
        if show:
            print(i, end='', flush=True)
            if i>1:
                print(" x ", end='', flush=True) #oq separa os numeros
            else:
                print(" = ", end='', flush=True)
        f*=i
        sleep(1)
    return f 



num = int(input("Digite um valor para verificar o fatorial: "))
resultado = fatorial(num, True) #escolha false ou true 
print(resultado)

