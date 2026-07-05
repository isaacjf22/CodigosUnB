#Exercício Python 105: Faça um programa que tenha uma função notas() que pode receber várias notas de alunos 
# e vai retornar um dicionário com as seguintes informações:

    # Quantidade de notas
    # A maior nota
    # A menor nota
    # A média da turma
    # A situação (opcional)

def notas(*num, sit=False):
    resultado = {}
    resultado["total"] = len(num)
    resultado["maior"] = max(num)
    resultado["menor"] = min(num)
    resultado["media"] = (sum(num)/len(num))

    if sit:
        if resultado["media"]>=7:
            resultado["situacao"] = "boa"
        elif resultado["media"]>=5:
            resultado["situacao"] = "razoavel"
        else:
            resultado["situacao"] = "ruim"

    return resultado

resp = notas(5.5,2.5,1.5,sit=True) #nesse caso com parametro variavel, precisa especificar a stiuação com alguma variavel 
print(resp)
