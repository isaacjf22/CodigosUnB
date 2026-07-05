#Exercício Python 108: Adapte o código do desafio #107, criando uma função adicional
#  chamada moeda() que consiga mostrar os números como um valor monetário formatado.

import moeda as m 

v = float(input("Digite o preço : R$"))
print(f"A metade de R${m.forma(v)} é {m.forma(m.metade(v))}")
print(f"O dobro de R${m.forma(v)} é {m.forma(m.dobro(v))}")
print(f"Aumentando 10%, temos {m.forma(m.aumentar(v))}")
print(f"Diminuindo 10%, temos {m.forma(m.diminuir(v))}")

#desatulizado por causa do 109 