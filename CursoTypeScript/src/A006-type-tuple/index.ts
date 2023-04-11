// Tuple
const dadosCliente1: readonly [number, string] = [1, "Gabriel"];
const dadosCliente2: [number, string, string] = [1, "Gabriel", "Souza"];
const dadosCliente3: [number, string, string?] = [1, "Gabriel"];
const dadosCliente4: [number, string, ...string[]] = [1, "Gabriel", "Souza"];

// dadosCliente1[0] = 100;
// dadosCliente1[1] = "Carlos";

console.log(dadosCliente1);
console.log(dadosCliente2);
console.log(dadosCliente3);
console.log(dadosCliente4);

// Readinly array
const array1: readonly string[] = ["Luiz", "Otávio"];
const array2: ReadonlyArray<string> = ["Luiz", "Otávio"];

console.log(array1);
console.log(array2);
