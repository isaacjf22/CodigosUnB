#Exercício Python 032: Faça um programa que leia um ano qualquer e mostre se ele é bissexto.

ano = int(input("Digite o ano para verificar se é bissexto : "))

#condições para ser bissexto : TEM q ser div por 4 e n terminar com 00 ou se terminar com 00 tem q ser div por 400 

# if ano%4==0:
#     if ano%100==0: #termina com 00 
#         if(ano%400==0):
#             print("É bissexto")
#         else:
#             print("Não é bissexto")
#     else:
#         print("É bissexto")
# else:
#     print("Não é bissexto")


if (ano%4==0 and ano%100!=0) or (ano%100==0 and ano%400==0):
    print("É bissexto")
else:
    print("Não é bissexto")     

