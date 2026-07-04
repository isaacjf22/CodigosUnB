
#Não considerar ano bissexto 
#Mês 30 dias padrão
#Ano 365 dias 

dia, mes, ano = map(int, input("Digite sua data de nascimento, dia , mês e ano respectivamente -> ").split())
diaA, mesA, anoA = map(int, input("Digite a data atual do alistamento, dia , mês e ano respectivamente -> ").split())


totalN = dia+(mes*30)+(ano*365)
totalA = diaA+(mesA*30)+(anoA*365)

d = totalA - totalN #idade da pessoa 

d18 = 6570
anosN = anoA-ano

if(d<d18):
    diaT = d18 - d #quantidade de dias que falta 

    anosF = diaT//365
    diaT = diaT%365
    mesF = diaT//30 
    diaF = diaT%30 

    print(f"Ainda não pode se alistar! Falta {anosF} anos, {mesF} meses e {diaF} dias")

else:
    print("Você pode se alistar!")


#questões desse estilo , transforme na menor unidade e vai dividindo 




