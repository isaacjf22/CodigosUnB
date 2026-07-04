palavras = ("APRENDER", "PROGRAMAR", "LINGUAGEM", "PYTHON", "CURSO", "GRATIS", "ESTUDAR", "PRATICAR", "TRABALHAR", 
            "ARROZ", "QUADRADO")

for palavra in palavras:
    print(f"\nNa palavra {palavra} temos as vogais: ", end="") #\n força a quebrar linha
    for letra in palavra:
        if letra in "AEIOU": #se a letra for algo dessa string 
            print(letra.lower(), end=" ") #end n quebra e vai juntando 