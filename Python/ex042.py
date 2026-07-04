# Refaça o DESAFIO 035 dos triângulos, acrescentando o recurso de mostrar que tipo de triângulo será formado:

#     EQUILÁTERO: todos os lados iguais
#     ISÓSCELES: dois lados iguais, um diferente
#     ESCALENO: todos os lados diferentes

def ehTriangulo(a, b, c):
    if(a<b+c) and (b<a+c) and (c<a+b): #as três condições precisa ser cumpridas 
        return True
    else:
        return False 

a, b, c = map(float, input("Digite os valores dos lados do triângulo: ").split()) 

v = ehTriangulo(a,b,c)

if(v==True):
    if(a==b) and (a==c):
        print("É um triângulo equilátero")
    elif(a==b and a!=c) or (a==c and a!=b):
        print("É um triãngulo isóceles")
    else:
        print("É um triângulo escaleno")
else:
    print("Os valores não formam um triângulo!")


