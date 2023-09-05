# Desenvolvimento Real de Software

Um livro para apreender algumas principios e pr�ticas sobre desenvolvimento de software, os exemplos dos livros s�o em java p�rem estou neste repositorio estou praticando com C#/.Net

## Explicifico do Livro


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
