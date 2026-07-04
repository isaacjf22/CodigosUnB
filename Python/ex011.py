#Exercício Python 11: Faça um programa que leia a largura e a altura de uma parede em metros, calcule a sua área e a quantidade de tinta 
# necessária para pintá-la, sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.

l = float(input("Qual é a largura da parede? "))
a = float(input("Qual é a altura da parede? "))

area = a*l

tinta = area/2 

print(f"A quantidade de tinta para pintar a parede é {tinta} litros")
