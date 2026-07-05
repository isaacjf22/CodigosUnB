#Exercício Python 104: Crie um programa que tenha a função leiaInt(), 
# que vai funcionar de forma semelhante 'a função input() do Python, só que fazendo a validação para aceitar apenas um valor numérico.
# Ex: n = leiaInt('Digite um n: ')

def leiaInt(mensagem):
    while True: 
        i = input(mensagem)
        if i.isnumeric():
            return int(i)
        else:
            print("ERROR! COLOQUE UM VALOR VÁLIDO!")
       


r = leiaInt("Digite um valor: ")
print(f"Você acabou de digitar o número {r}")  

