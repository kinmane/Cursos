## Operadores
Símbolos especiais, que tem um significado próprio para a linguagem e estão associados a determinadas operações.

Geralmente, as primeiras palavras que ouvimos em um curso de programação são: um programa é um conjunto de instruções lógicas que, quando executadas, produzem algum resultado. Com isso em mente, ao começar a criar as primeiras linhas de código, logo você notará que é comum receber dados do usuário, prover alguma lógica para processá-los e então apresentar o resultado desse processamento.

### Classificação do operadores

#### Atribuição

**Representado pelo símbolo de igualdade "=".**
O operador de atribuição é utilizado para definir o valor inicial ou sobrescrever o valor de uma variável. em Java, definimos um tipo, nome e opcionalmente atribuímos um valor à variável através do operador de atribuição. Exemplos abaixo:

`//classe Operadores.java`

```
    String nome = "Elielson";
    int idade = 32;
    double peso = 74.0;
    char sexo = 'M';
    boolean doadorOrgao = true;
    Date dataNascimento = new Date();
```

#### Aritméticos
O operador aritmético, é utilizado para realizar operações matemáticas entre valores numéricos, podendo se tornar ou não uma expressão mais complexa.
Os operadores aritméticos são:
```
    + (adição),

    - (subtração),

    * (multiplicação),

    / (divisão),

    % (módulo),
```


`//classe Operadores.java`

```
double soma = 10.5 + 15.7;
int subtração = 113 - 25;
int multiplicacao = 20 * 7;
int divisao = 15 / 3;
int modulo = 18 % 3;
double resultado = (10 * 7) + (20/4);
```
**ATENÇÃO! O operador de adição (+), quando utilizado em variáveis do tipo texto, realizará a “concatenação de textos”.**

`//classe Operadores.java`

```String nomeCompleto = "LINGUAGEM" + "JAVA";```

#### Unários
Esses operadores, são aplicados juntamente com um outro operador aritmético. Eles realizam alguns trabalhos básicos como incrementar, decrementar, inverter valores numéricos e booleanos.
    *(+) Operador unário de valor positivo* – números são positivos sem esse operador explicitamente;

    *(-) Operador unário de valor negativo* – nega um número ou expressão aritmética;

    *(++) Operador unário de incremento de valor* – incrementa o valor em 1 unidade;

    *(--) Operador unário de decremento de valor* – decrementa o valor em 1 unidade;

    *(!) Operador unário lógico de negação* – nega o valor de uma expressão booleana.

*Muito cuidado com ordem de precedência, dos operadores unários!*

#### Ternário
O operador de condição ternária é uma forma resumida para definir uma condição e escolher por um dentre dois valores. Você deve pensar numa condição ternária, como se fosse uma condição IF normal, porém, de uma forma em que toda a sua estrutura estará escrita numa única linha.
O operador ternário é representado pelos símbolos `"?"` e `":"` utilizados na seguinte estrutura de sintaxe:

<Expressão Condicional>`` ?``<Caso condição seja true>``: ``<Caso condição seja false>

#### Relacionais
Os operadores relacionais, avaliam a relação entre duas variáveis ou expressões. Neste caso, mais precisamente, definem se o operando à esquerda é igual, diferente, menor, menor ou igual, maior, maior ou igual ao da direita, retornando um valor booleano como resultado.

*== Quando desejamos verificar se uma variável é IGUAL A outra.*

*!= Quando desejamos verificar se uma variável é DIFERENTE da outra.*

*> Quando desejamos verificar se uma variável é MAIOR QUE a outra.*

*>= Quando desejamos verificar se uma variável é MAIOR OU IGUAL a outra.*

*< Quando desejamos verificar se uma variável é MENOR QUE outra.*

*<= Quando desejamos verificar se uma variável é MENOR OU IGUAL a outra.*


###### Comparações avançadas
Quando se refere a comparação de conteúdos na linguagem, devemos ter um certo domínio, de como o Java trata o armazenamento destes valores na memória.

**Quando estiver mais familiarizado com a linguagem, recomendamos se aprofundar no conceito de espaço em memória `Stack` versus `Heap`.**

#### Lógicos
Os operadores lógicos, representam o recurso que nos permite criar expressões lógicas maiores, a partir da junção de duas ou mais expressões.

*&& Operador Lógico "E"*

*|| Operador Lógico "OU"*
