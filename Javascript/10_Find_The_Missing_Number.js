// Find the missing number
// Assumption: The array contains distinct numbers from 1 to n, with exactly one missing.
// Logic: Expected sum minus actual sum gives the missing number.

function missingNumber(arr, n) {
    const expected = (n * (n + 1)) / 2;

    const actual = arr.reduce(
        (sum, num) => sum + num, 0
    );

    return expected - actual;
}

console.log(missingNumber([1, 2, 4, 5], 5));
// 3