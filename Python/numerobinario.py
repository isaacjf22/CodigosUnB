n = int(input("De entrada num número ->"))
inicio = n 
resposta = ""

while(n>0):
    resto = str(n%2) #casting p
    resposta= resto + resposta
    n = n//2 #divisao inteira para desconsidar o decimal 

print(f"O número {inicio} em número binário é {resposta}")