#Exercício Python 081: Crie um programa que vai ler vários números e colocar em uma lista. Depois disso, mostre:
# A) Quantos números foram digitados.
# B) A lista de valores, ordenada de forma decrescente. (sem sorted)
# C) Se o valor 5 foi digitado e está ou não na lista.

l = [] #not = vazio 
while True:
    n = int(input("Digite um valor: "))
    if not l or n>l[0]: #not , nao tiver nada na vaiavel 
        l.insert(0,n)
    else:
        posi=0
        while posi<len(l): #andar por toda a lista 
            if n<l[-1]: #se for menor que o ultimo 
                l.append(n)
                break #finaliza a analise 
            elif n>=l[posi]: #verificando posicção por posição pros ifs darem certo 
                l.insert(posi,n)  
                break
            posi+=1 #caso nao ache na posicao q tava , muda pra prox pra verificar 
    esc = input("Deseja adicionar outro valor? [S/N]").lower()
    if esc == 'n':
        break

print(f"A quantidade de números digitados foi : {len(l)}")
print(f"A lista ordenada de forma decrescente é : {l}")
if 5 in l:
    print("O número 5 está presente na lista!")
else:
    print("O número 5 não está presente na lista!")
    