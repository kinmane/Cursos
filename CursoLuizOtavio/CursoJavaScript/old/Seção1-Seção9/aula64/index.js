const num1 = [1, 2, 3];
const num2 = [4, 5, 6];
const num3 = num1.concat(num2, 'Gabriel');
console.log(num3);

const a1 = [1, 2, 3];
const a2 = [4, 5, 6];
const a3 = [...a1, ...a2, 'Gabriel'];
console.log(a3);
