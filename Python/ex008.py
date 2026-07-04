#Exercício Python 8: Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.

m = float(input("Digite um valor em metros: "))
c = m*100
mm= m*1000

print(f"O valor {m}m em cm e mm são : {c:.0f}cm e {mm:.0f}mm")