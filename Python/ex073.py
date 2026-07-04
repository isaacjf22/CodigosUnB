#Exercício Python 073: Crie uma tupla preenchida com os 20 primeiros colocados da Tabela do Campeonato Brasileiro de Futebol, 
# na ordem de colocação. Depois mostre:
# a) Os 5 primeiros times.
# b) Os últimos 4 colocados.
# c) Times em ordem alfabética. 
# d) Em que posição está o time da Chapecoense.

br = ("Corinthians", "Palmeiras", "Santos", "Grêmio", "Cruzeiro", "Flamengo", "Vasco", "Chapecoense", "Atlético", "Botafogo", "Atlético-PR", 
      "Bahia", "São Paulo", "Fluminense", "Sport Recife", "Vitória", "Coritiba", "Avaí", "Ponte Preta", "Atlético-GO" ) # 0 a 19 

print(f"Lista de times do Brasileirão: {br}")
print("=*="*20)
print(f"Os cincos primeiros colocados: {br[0:6]}") #sempre considera o ultimo 
print("=*="*20)
print(f"Os quatro últimos colocados: {br[16:]}")
print("=*="*20)
print(f"Times em ordem alfabética: {sorted(br)}")
print("=*="*20)
f = (br.index("Chapecoense")) 
print(f"O Chapecoense está na {f+1}º posição")

