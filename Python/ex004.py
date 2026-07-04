palavra = input("Digite alguma coisa: ")

#função ent finalize com ()

print("É um número? " ,palavra.isnumeric())
print("É alfabético? ",palavra.isalpha()) #alpha -> alfabeto 
print("É alfanumérico? ",palavra.isalnum()) #alnum -> alfabeto e número 
print("Tem SOMENTE espaços? ",palavra.isspace()) 
print("Está tudo maiúsculo?" , palavra.isupper()) #isupper -> TUDO maiusculo 
print("Está tudo minúsculo? " , palavra.islower()) #islower -> TUDO minusculo 
print("Tem maiúsculo e minúsculo? ",palavra.istitle()) #istitle -> maiusculo e minusculo 



