## Tipos de Variáveis

### Tipos de dados
No Java, existem algumas palavras reservadas, para a representação dos tipos de dados básicos, que
precisam ser manipulados, para a construção de programas. Estes tipos de dados são conhecidos
como tipos primitivos (Primitive Types).
Os oito tipos primitivos em Java são:
int, byte, short, long, float, double, boolean e char – esses tipos não são considerados objetos e
portanto representam valores brutos. Eles são armazenados diretamente na pilha de memória.
(Memory stack).

> Tabela de Tipos Primitivos e seus valores:

`char` - Suporta apenas um caractere;
```
char sexo = "M";
```

`String` - Suporta um ou mais caracteres e frases;
```
String nome = "Elielson";
```

`byte` - Suporta valores entre -128 a 127
```
byte idade = 32
```

`short` - Suporta valores entre -32.768 a -32.767
```
short anoNascimento = 1990;
```

`int` - Suporta valores entre -2.147.483.648 a 2.147.483.647
```
int limiteMaximoDoInt = 2.147.483.647;
```

`long` - Suporta valores entre -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
```
long celulasDoCorpo = 37000000000000L;
```
**OBS: No tipo `long` sempre ao final do valor devemos inserir a letra `L`.**

> Os tipos primitivos, que podem conter partes fracionárias podem ser representados por dois tipos:

`float` - Suporta valores entre -3,4028E + 38 a 3,4028E + 38 e com a precisão de 6 a 7 dígitos;
```
float salarioMinimo = 1302.00F;
```
**OBS: No tipo `float` sempre ao final do valor devemos inserir a letra `F`.**

`double` - Suporta valores entre -1,7976E + 308 a 1,7976E + 308 e com a precisão de 15 dígitos;
```
float megaDaVirada = 30000000.00;
```

image.png

Portanto, para representar números, na grande maioria das vezes, utilizaremos o tipo int , para
representar números inteiros ou double para representar números fracionados.

### Declaração de CONSTANTE
Compreendemos que, para declarar uma variável como uma constante, utilizamos a palavra `final`,
mas por convenção, esta variável deverá ser escrita toda em `CAIXA ALTA`.
```
final String NACIONALIDADE = "Brasileiro";
```
