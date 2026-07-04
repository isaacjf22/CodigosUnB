#Exercício Python 077: Crie um programa que tenha uma tupla com várias palavras (não usar acentos). 
# Depois disso, você deve mostrar, para cada palavra, quais são as suas vogais

palavras = ("APRENDER", "PROGRAMAR", "LINGUAGEM", "PYTHON", "CURSO", "GRATIS", "ESTUDAR", "PRATICAR", "TRABALHAR", 
            "ARROZ", "QUADRADO")
print(palavras)
print()
for palavra in palavras:
    a = False
    e = False
    i = False
    o = False
    u = False 
    for letra in palavra:
        if(letra=='A'):
            a = True
        elif(letra=='E'):
            e = True
        elif(letra=='I'):
            i = True
        elif(letra=='O'):
            o = True
        elif(letra=='U'):
            u = True
    vogais = ""
    if(a==True):
        vogais+='a '
    if(e==True):
        vogais+='e '
    if(i==True):
        vogais+='i ' 
    if(o==True):
        vogais+='o '
    if(u==True):
        vogais+='u '
    print(f"Na palavra {palavra} temos {vogais}")
