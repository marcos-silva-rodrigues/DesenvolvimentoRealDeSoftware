# Desenvolvimento Real de Software

Um livro para apreender algumas principios e práticas sobre desenvolvimento de software, os exemplos dos livros são em java pórem estou neste repositorio estou praticando com C#/.Net

## Explicifico do Livro
+ KISS, manter curto e simples 
+ DRY, não manter código duplicado, para evitar ter quer fazer multiplas modificações no código
+ SRP, Responsabilidade Unica, uma classe deve ter apenas uma razão para mudar
+ Coesão, mensura quanto as responsabilidade da classe ou métodos esão intimamente relacionadas

Tipo de coesão | como funciona | pro | contras
---|---|---|
Funcional | Geralmente um metodo que chama outro | facil de entender | pode levar as classes exageradamamente simplistas
Informacional | Trabalham nos mesmos dados ou objetos de dominio | Fácil de manter | Pode levar a dependências desnecessárias
Sequencia | Agrupa metodo que são utilizados em  sequencia um do outro | Fácil de localizar operações relacionadas | Encoraja a violação do SRP
Lógica | Se agrupam por uma mesma natureza ou objetivo porem com varias derivações | Oferece certo tipo de categorização de alto nivel | Encoraja a violação do SRP
Utilitária | Agrupa uma serie de metodos que podem ser utilizadso por varios clientes  | simples de implementar | mais dificil de racionalizar a responsabilidade da classe
Temporal | Relativas ao tempo, com ser chamada na inicialização e finalização de operadoções | N\D | mais dificil de entender e utilizar operações individuais

+ Exceções verificadas, são aquelas nas caso oferecemos umma maneira de se recuperar
+ Exceções não verificadas, podem ser geradas a qualquer momento da execução
+ Padrão Notification, classe de dominio so para capturar erros, assim podemos controlar/diminiur a quantidade de fluxos alternativos que mossa aplicação terá quer percorrer, podendo ainda lançar um feedback sobre todos os erros cometidos

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
