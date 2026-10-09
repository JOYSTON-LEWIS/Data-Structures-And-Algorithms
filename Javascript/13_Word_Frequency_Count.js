// Word frequency count
// Logic: Normalize the text, split it into words, and count each occurrence.

function wordFrequency(sentence) {
    const words = sentence
        .toLowerCase()
        .match(/\b[\w']+\b/g) || [];

    const frequency = {};

    for (const word of words) {
        frequency[word] = (frequency[word] || 0) + 1;
    }

    return frequency;
}

console.log(wordFrequency("JavaScript is great and JavaScript is fun"));
// { javascript: 2, is: 2, great: 1, and: 1, fun: 1 }