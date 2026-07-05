#Exercício Python 107: Crie um módulo chamado moeda.py que tenha as funções incorporadas
#  aumentar(), diminuir(), dobro() e metade(). Faça também um programa que importe esse módulo e use algumas dessas funções.

import moeda as m 

v = float(input("Digite o preço : R$"))
print(f"A metade de R${v} é R${m.metade(v)}")
print(f"O dobro de R${v} é R${m.dobro(v)}")
print(f"Aumentando 10%, temos R${m.aumentar(v)}")
print(f"Diminuindo 10%, temos R${m.diminuir(v)}")

#desatualizado por causa do 109