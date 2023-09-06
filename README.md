# Desenvolvimento Real de Software

Um livro para apreender algumas principios e pr�ticas sobre desenvolvimento de software, os exemplos dos livros s�o em java p�rem estou neste repositorio estou praticando com C#/.Net

## Explicifico do Livro
+ KISS, manter curto e simples 
+ DRY, n�o manter c�digo duplicado, para evitar ter quer fazer multiplas modifica��es no c�digo
+ SRP, Responsabilidade Unica, uma classe deve ter apenas uma raz�o para mudar
+ Coes�o, mensura quanto as responsabilidade da classe ou m�todos es�o intimamente relacionadas

Tipo de coes�o | como funciona | pro | contras
---|---|---|
Funcional | Geralmente um metodo que chama outro | facil de entender | pode levar as classes exageradamamente simplistas
Informacional | Trabalham nos mesmos dados ou objetos de dominio | F�cil de manter | Pode levar a depend�ncias desnecess�rias
Sequencia | Agrupa metodo que s�o utilizados em  sequencia um do outro | F�cil de localizar opera��es relacionadas | Encoraja a viola��o do SRP
L�gica | Se agrupam por uma mesma natureza ou objetivo porem com varias deriva��es | Oferece certo tipo de categoriza��o de alto nivel | Encoraja a viola��o do SRP
Utilit�ria | Agrupa uma serie de metodos que podem ser utilizadso por varios clientes  | simples de implementar | mais dificil de racionalizar a responsabilidade da classe
Temporal | Relativas ao tempo, com ser chamada na inicializa��o e finaliza��o de operado��es | N\D | mais dificil de entender e utilizar opera��es individuais


## Explicifico do C#/.NET
+ Gerando relatorio de cobertura de testes com xUnit:
```bash
#gerar os dados em  xml
#j� incluso no xUnit, porem para o nUnit tem que add package coverlet.msbuild 
dotnet test --collect:"XPlat Code Coverage"

#instalar ferramenta nommodo global para gerar relatorios em html
dotnet tool install -g dotnet-reportgenerator-globaltool

#Gerar relatorios em si
reportgenerator -reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
