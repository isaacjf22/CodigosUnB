#Exercício Python 17: Faça um programa que leia o comprimento do cateto oposto 
# e do cateto adjacente de um triângulo retângulo. Calcule e mostre o comprimento da hipotenusa.
import math

catetoO, catetoA = map(float, input("Digite o valor do cateto oposto e do cateto adjascente, respectivamente: ").split()) #map serve para mapiar as variaveis onde elas vão 
#respectivamente 3

hip = math.sqrt(math.pow(catetoO,2)+math.pow(catetoA,2)) #tem q botar sempre de onde vem , só se importar somente ela 

print(f"A sua hipotenusa é {hip:.2f}")