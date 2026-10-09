// Fibonacci sequence
// Each number is the sum of the previous two numbers.
// Logic: Update the two previous numbers in every iteration.

function fibonacci(n) {
    const result = [];
    let a = 0;
    let b = 1;

    for (let i = 0; i < n; i++) {
        result.push(a);

        const next = a + b;
        a = b;
        b = next;
    }

    return result;
}

console.log(fibonacci(7));
// [0, 1, 1, 2, 3, 5, 8]