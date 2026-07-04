#Exercício Python 062: Melhore o DESAFIO 061, perguntando para o usuário se ele quer mostrar mais alguns termos.
#  O programa encerrará quando ele disser que quer mostrar 0 termos.

p = int(input("Digite o primeiro termo da PA: "))
r = int(input("Digite a razão da PA: "))

c = 0 #contador
m = 10 #somando 
total = 0 #limite 
while m!=0:
    total+=m #vai somando o limite e mantendo o contador antigo 
    while c<total:
        t = p + r*c  #calculo 
        print(f"-{c+1}º Termo: {t}")
        c+=1 #o contador vai subindo 
    print("-PAUSA")
    print("Quantos termos quer mostrar a mais?")
    m = int(input("--> "))
   

