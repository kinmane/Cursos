## Métodos

__Todas as ações das aplicações são consideradas métodos.__

Sintaxe de declaração de uma nova classe:
```
public void myMetodo() {
   // Corpo do método
};
```
###### Caso o método não retorne nenhum valor, ele será representado pela palavra-chave void, porém caso ela tenha retorno deve-se inserir o tipo do mesmo, como: String, boolean, int ...

*Critério de nomeação de Métodos:*
Esses critérios não são obrigatórios, mas é recomendável que sejam seguidos, pois essas convenções facilitam a vida dos programadores ao trabalharem em códigos de forma colaborativa. Ao seguir estas convenções, tornamos o código mais legível para nós e também para outras pessoas. 


*Para métodos, os critérios são:*
+ Deve ser nomeado como verbo;
+ Seguir o padrão camelCase (Todas as letras minúsculas com a exceção da primeira letra da segunda palavra).

*Exemplos sugeridos para nomenclatura de métodos:*
```
somar(int n1, int n2){}

abrirConexao(){}

concluirProcessamento() {}

calcularImprimir(){} // há algo de errado neste método, ele deveria ter uma única finalidade
```
###### ATENÇÃO! Não existe em Java o conceito de métodos globais. Todos os métodos devem SEMPRE ser definidos dentro de uma classe.
