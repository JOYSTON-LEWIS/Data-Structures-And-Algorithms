// Palindrome check
// A palindrome reads the same forward and backward.
// Logic: Compare characters at opposite ends, moving toward the middle.

function isPalindrome(str) {
    str = str.toLowerCase();

    let left = 0;
    let right = str.length - 1;

    while (left < right) {
        if (str[left] !== str[right]) {
            return false;
        }

        left++;
        right--;
    }

    return true;
}

console.log(isPalindrome("Madam")); // true
console.log(isPalindrome("Hello")); // false