# Desenvolvimento Real de Software

Um livro para apreender algumas principios e pr�ticas sobre desenvolvimento de software, os exemplos dos livros s�o em java p�rem estou neste repositorio estou praticando com C#/.Net

## Explicifico do Livro
+ KISS, manter curto e simples 
+ DRY, n�o manter c�digo duplicado, para evitar ter quer fazer multiplas modifica��es no c�digo
+ SRP, Responsabilidade Unica, uma classe deve ter apenas uma raz�o para mudar
+ Coes�o, mensura quanto as responsabilidade da classe ou m�todos es�o intimamente relacionadas

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
