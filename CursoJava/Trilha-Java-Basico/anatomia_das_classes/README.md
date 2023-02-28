## Anatomia das classes

Sintaxe de declaração de uma nova classe:
```
public class MyClass {
   // Corpo da class
};
```

+ 99,9% das nossas classes iniciarão com public class;

+ Toda classe precisa de nome, exemplo MinhaClasse;

+ O nome do arquivo deve ser idêntico ao nome da classe pública;

+ Após o nome, definir o corpo { } , onde iremos compor nossas classes com atributos e
métodos.

```
public class MyClass {
   // Corpo da class

   public static void main(String[] args) {
      // Corpo do metodo principal
   };
};
```

É de suma importância que agora você consiga se localizar dentro do conjunto de chaves { }
existentes em sua classe.

+ Dentro de uma aplicação, recomenda-se que somente uma classe possua o método main,
responsável por iniciar todo o nosso programa.

+ O método main recebe seu nome main, sempre terá a visibilidade public, será difinido como
static, não retornará nenhum valor com void e receberá um parâmetro do tipo array de
caracteres: String[].

