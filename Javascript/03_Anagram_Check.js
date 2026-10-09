// Anagram check
// Two strings are anagrams if they contain the same characters with the same frequencies.
// Logic: Count each character in the first string, then subtract counts using the second.

function isAnagram(str1, str2) {
    const normalize = str =>
        str.toLowerCase().replace(/\s/g, "");

    str1 = normalize(str1);
    str2 = normalize(str2);

    if (str1.length !== str2.length) {
        return false;
    }

    const frequency = {};

    for (const char of str1) {
        frequency[char] = (frequency[char] || 0) + 1;
    }

    for (const char of str2) {
        if (!frequency[char]) {
            return false;
        }

        frequency[char]--;
    }

    return true;
}

console.log(isAnagram("listen", "silent")); // true
console.log(isAnagram("hello", "world"));   // false