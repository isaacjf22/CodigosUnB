#Exercício Python 109: Modifique as funções que form criadas no desafio 107 para que elas aceitem um parâmetro a mais,
#  informando se o valor retornado 
# por elas vai ser ou não formatado pela função moeda(), desenvolvida no desafio 108

import moeda as m 
#escolha entre True ou False a formatação 
v = float(input("Digite o preço : R$"))
print(f"A metade de R${m.forma(v)} é {m.metade(v,False)}")
print(f"O dobro de R${m.forma(v)} é {m.dobro(v,False)}")
print(f"Aumentando 10%, temos {m.aumentar(v,False)}")
print(f"Diminuindo 10%, temos {m.diminuir(v,False)}")

