# Desenvolvimento Real de Software

Um livro para apreender algumas principios e práticas sobre desenvolvimento de software, os exemplos dos livros são em java pórem estou neste repositorio estou praticando com C#/.Net

## Explicifico do Livro
+ KISS, manter curto e simples 
+ DRY, não manter código duplicado, para evitar ter quer fazer multiplas modificações no código
+ SRP, Responsabilidade Unica, uma classe deve ter apenas uma razão para mudar
+ Coesão, mensura quanto as responsabilidade da classe ou métodos esão intimamente relacionadas

## Explicifico do C#/.NET

+ Gerando relatorio de cobertura de testes com xUnit:
```bash
#gerar os dados em  xml
#já incluso no xUnit, porem para o nUnit tem que add package coverlet.msbuild 
dotnet test --collect:"XPlat Code Coverage"

#instalar ferramenta nommodo global para gerar relatorios em html
dotnet tool install -g dotnet-reportgenerator-globaltool

#Gerar relatorios em si
reportgenerator -reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
