let x;
if (typeof x === "undefined") x = 20;
console.log(x * 2);

export function creatPerson(
  firstName: string,
  lastName?: string,
): {
  firstName: string;
  lastName?: string;
} {
  return {
    firstName,
    lastName,
  };
}

export function squareOf(x: any) {
  if (typeof x === "number") return x * x;
  return null;
}

const squareOfTwo = squareOf(2);

if (squareOfTwo === null) {
  console.log("Conta Inválida.");
} else {
  console.log(squareOfTwo * 100);
}
