// Reverse a string
// Reverse the characters in a string without using the built-in reverse() method.
// Logic: Start at the last character and move backward.

function reverseString(str) {
    let result = "";

    for (let i = str.length - 1; i >= 0; i--) {
        result += str[i];
    }

    return result;
}

console.log(reverseString("hello")); // "olleh"
