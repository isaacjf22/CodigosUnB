#Exercício Python 080: Crie um programa onde o usuário possa digitar cinco valores numéricos e cadastre-os em uma lista, 
# já na posição correta de inserção (sem usar o sort()). No final, mostre a lista ordenada na tela.

lista = []
listaB = []

for i in range(5):
    n = int(input("Digite um valor: "))
    listaB.append(n)
    if i==0 or n>lista[-1]: #se for o primeiro indice ou maior que o ultimo , add na lista 
        #primeiro indice tem q adicionar de qq forma 
        lista.append(n)
        print("Número adicionado no final!")
    else: #vai ser preciso uma analise para ser definida a posição 
        posi = 0
        while posi<len(lista): #passa por toda a lista 
            if n <= lista[posi]: #se o numero encontrar outro numero maior ou igual a ele , ele é inserido antes desse encontro 
                #meio que vai passando todos os numeros menor que o N, para definir a posição dele como maior 
                lista.insert(posi,n)
                print(f"Número adicionado na posição {posi}")
                break #n precisa mais da analise pois ja achou o primeiro maior= a N
            posi+=1
    
print(f"Os valores digitados sem organização: {listaB}")
print(f"Os valores digitados organizados em ordem crescente: {lista}")
