#Exercício Python 083: Crie um programa onde o usuário digite uma expressão qualquer que use parênteses.
#  Seu aplicativo deverá analisar se a expressão passada está com os parênteses abertos e fechados na ordem correta.

exp = input("Digite a expressão: ")

l = []

for i in exp:
    if i == '(':
        l.append(i)
    elif i == ')':
        if len(l)>0: #se tiver (
            l.pop() #fecha um par 
        else:
            break #começou uma expressão por ) , q é errado 

if len(l)==0:
    print("Expressão válida!")
else:
    print("Expressão inválida!")

