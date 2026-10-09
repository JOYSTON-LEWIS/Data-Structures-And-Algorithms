// Two Sum
// Find the indices of two numbers that add up to a target.
// Logic: For each number, check whether its required complement has already been seen.

function twoSum(arr, target) {
    const map = new Map();

    for (let i = 0; i < arr.length; i++) {
        const complement = target - arr[i];

        if (map.has(complement)) {
            return [map.get(complement), i];
        }

        map.set(arr[i], i);
    }

    return [];
}

console.log(twoSum([2, 7, 11, 15], 9));
// [0, 1]