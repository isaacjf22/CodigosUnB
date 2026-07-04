# Exercício Python 18: Faça um programa que leia um ângulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse ângulo. 
import math

ang = float(input("Digite o valor de ângulo: "))

ang = math.radians(ang) #convertendo grau para rad 

print(f"SEN: {round(math.sin(ang), 4)} / COS: {round(math.cos(ang), 4)} / TAN: {round(math.tan(ang), 4)}") #as funções trabalham com rad 
#round arredonda 

#rad para graus math.degress(valor em rad)
#graus para rad math.radians(valor em garus)