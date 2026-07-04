#Exercício Python 057: Faça um programa que leia o sexo de uma pessoa, mas só aceite os valores 'M' ou 'F'. 
# Caso esteja errado, peça a digitação novamente até ter um valor correto.

esc=''
while(esc!='m' and esc!='f'):
    esc = input("Digite o seu sexo : M ou F ").lower() #força tudo ficar minusculo 


