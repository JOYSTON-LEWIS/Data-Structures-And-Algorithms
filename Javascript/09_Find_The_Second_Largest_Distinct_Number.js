// Find the second-largest distinct number
// Logic: Maintain the largest and second-largest distinct values in one pass.

function secondLargest(arr) {
    let largest = -Infinity;
    let second = -Infinity;

    for (const num of arr) {
        if (num > largest) {
            second = largest;
            largest = num;
        } else if (num > second && num < largest) {
            second = num;
        }
    }

    return second === -Infinity ? null : second;
}

console.log(secondLargest([10, 5, 20, 8])); // 10
console.log(secondLargest([5, 5, 3]));      // 3
console.log(secondLargest([5, 5]));         // null