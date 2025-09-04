Algoritmo "Calculo IMC"

Var
NomePaciente, Classe, ObjetivoPaciente : caractere
Peso, Altura, IMC : real
Objetivo : inteiro

Inicio
EscrevaL("Bem vindo ao Sistema de Calculo IMC!")
EscrevaL("Primeiramente, digite o nome do paciente:")
Leia (NomePaciente)
EscrevaL("Agora, insira o peso ( em kilogramas) do paciente:")
Leia(Peso)
EscrevaL("Agora, insira a altura ( em metros) do paciente:")
Leia (Altura)

Imc <- Peso / (Altura ^2)

EscrevaL ("Qual o objetivo do(a) ", NomePaciente)
EscrevaL("1- Perder peso")
EscrevaL("2- Manter peso")
EscrevaL("3- Ganhar massa muscular")
EscrevaL("4- Melhorar condicionamento físico")
Leia(Objetivo)

Escolha(Objetivo)
caso 1
ObjetivoPaciente <- "1- Perder peso"
caso 2
ObjetivoPaciente <- "2- Manter Peso"
caso 3
ObjetivoPaciente <- "3- Ganhar massa muscular"
caso 4
ObjetivoPaciente <- "4- Melhorar condicionamento Fisico"
outrocaso
Escreva("Erro! Opção Inválida")
Fimalgoritmo
fimescolha


Se (Imc < 18.5) Então
Classe <- "Abaixo do Peso"
Senao
Se (Imc < 25) e ( Imc >= 18.5) Então
Classe <- "Peso Normal"
Senao
Se (Imc < 30) e (Imc >= 25) Então
Classe <- "Sobre Peso"
Senao
Se (Imc < 35) e ( Imc >= 30) Então
Classe <- "Obesidade Grau I"
Senao
Se (Imc < 40) e ( Imc >= 35) Então
Classe <- "Obesidade Grau II"
Senao
Classe <- "Obesidade Grau III"
FimSe
FimSe
FimSe
FimSe
FimSe

EscrevaL("Dados do Paciente:")
EscrevaL("Paciente:", NomePaciente)
EscrevaL("Objetivo:", ObjetivoPaciente)
EscrevaL("Imc:", Imc)
EscrevaL("Classificação:",Classe)

Se(Imc >= 25)Entao
EscrevaL("Recomenda-se procurar orientação nutricional e praticar atividade física para manter a saúde em dia")
fimse


EscrevaL("Desenvolvido por Kauã Fragozo, estudante de Análise e Desenvolvimento de Sistemas!")
EscrevaL("Obrigado por ultilzar meu algoritimo")


Fimalgoritmo