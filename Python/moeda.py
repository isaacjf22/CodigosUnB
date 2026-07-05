def aumentar(valor , forma=True):
    a = valor*1.10
    if forma:
        f = forma(a)
        return f 
    return a

def diminuir(valor , forma=True):
    a = valor*0.9
    if forma:
        f = forma(a) 
        return f 
    return a

def dobro(valor , forma=True):
    a = valor*2
    if forma:
        f = forma(a)
        return f 
    return a

def metade(valor , forma=True):
    a = valor/2
    if forma:
        f = forma(a)
        return f
    return a 

#exercício 108
def forma(valor):
    a = f"R${valor:.2f}"
    return a