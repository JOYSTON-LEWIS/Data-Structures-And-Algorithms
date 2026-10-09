// Prime number check
// A prime number is greater than 1 and has exactly two positive divisors: 1 and itself.
// Logic: Check divisors only up to the square root of n.

function isPrime(n) {
    if (n <= 1) return false;

    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (n % i === 0) {
            return false;
        }
    }

    return true;
}

console.log(isPrime(7));  // true
console.log(isPrime(10)); // false
console.log(isPrime(1));  // false