#Exercício Python 006: Crie um algoritmo que leia um número e mostre o seu dobro, triplo e raiz quadrada.

x = int(input())
d = x*2
t = x*3
r = int(x**0.5) #raiz quadrada em exp é 1/2 

print("Do valor {} a dupla, tripla e raiz quadrada são: {}, {} e {}".format(x,d,t,r))