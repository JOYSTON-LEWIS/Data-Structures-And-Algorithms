// Factorial
// The factorial of n is the product of all positive integers up to n. By definition, 0! = 1.
// Logic: Multiply the result by every integer from 2 through n.

function factorial(n) {
    if (n < 0 || !Number.isInteger(n)) {
        throw new Error("Enter a non-negative integer");
    }

    let result = 1;

    for (let i = 2; i <= n; i++) {
        result *= i;
    }

    return result;
}

console.log(factorial(5)); // 120
console.log(factorial(0)); // 1