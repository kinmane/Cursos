package Exemplos;

public class FuncoesString {

	public static void main(String[] args) {

		String original = "abcde FGHIJ ABC abc DEFG   ";
		System.out.println("Original: -" + original + "-");

		String toLower = original.toLowerCase();
		System.out.println("toLower: -" + toLower + "-");

		String toUpper = original.toUpperCase();
		System.out.println("toUpper: -" + toUpper + "-");

		String trim = original.trim();
		System.out.println("trim: -" + trim + "-");

		String subString = original.substring(2);
		System.out.println("subString(2): -" + subString + "-");

		String subString2 = original.substring(2, 9);
		System.out.println("subString(2-9): -" + subString2 + "-");

		String replace = original.replace('a', 'x');
		System.out.println("replace: -" + replace + "-");

		String replace2 = original.replace("abc", "xy");
		System.out.println("replace2: -" + replace2 + "-");

		int indexOf = original.indexOf("bc");
		System.out.println("indexOf(bc): -" + indexOf + "-");

		int lastIndexOf = original.lastIndexOf("bc");
		System.out.println("lastIndexOf(bc): -" + lastIndexOf + "-");

		String split = "potato apple lemon";
		System.out.println(split);
		String[] vetor = split.split(" ");
		System.out.println("vetor index[0]: " + vetor[0]);
		System.out.println("vetor index[1]: " + vetor[1]);
		System.out.println("vetor index[2]: " + vetor[2]);

	}

}
