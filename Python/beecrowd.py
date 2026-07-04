par = 0 
impar = 0
positivo = 0
negativo = 0


for i in range(5):
    n = int(input())
    if n%2==0:
        par+=1
    else:
        impar+=1
    if n>0:
        positivo+=1
    elif n<0:
        negativo+=1

print(f"{par} valor(es) par(es)")
print(f"{impar} valor(es) impar(es)")
print(f"{positivo} valor(es) positivo(s)")
print(f"{negativo} valor(es) negativo(s)")