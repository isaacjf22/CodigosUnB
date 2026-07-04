#Exercício Python 072: Crie um programa que tenha uma tupla totalmente preenchida com uma contagem por extenso, de zero até vinte. 
# Seu programa deverá ler um número pelo teclado (entre 0 e 20) e mostrá-lo por extenso.

num = ("Zero", "Um", "Dois", "Três", "Quatro", "Cinco","Seis","Sete","Oito","Nove","Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis"
       ,"Dezessete","Dezoito","Dezenove","Vinte")

n = int(input("Digite um número entre 0 a 20 para ver sua forma extensa -> "))
while(n<0 or n>20):
    n = int(input("Tente novamente, -> "))

print(f"O número {n} em extenso é : {num[n]}")
