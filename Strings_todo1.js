function RemoveBlanks(word) {
  words = word.split(" ");
  return words.join("");
}

// console.log(RemoveBlanks(" Pl ayTha tF u nkyM usi c "));

function GetDigits(word) {
  var num = word.replace(/\D/g, "");
  return parseInt(num);
}
// console.log(GetDigits("0s1a3y5w7h9a2t4?6!8?0"));

function Acronyms(word) {
  words = word.trim().split(" ");
  var acronyms = "";
  for (let i = 0; i < words.length; i++) {
    // console.log(words[i][0]);
    acronyms += words[i][0];
  }
  return acronyms.toUpperCase();
}
// console.log(Acronyms(" there's no free lunch - gotta pay yer way. "));

function CountNonSpaces(word) {
  words = word.split(" ");
  return words.join("").length;
}
// console.log(CountNonSpaces("Honey pie, you are driving me crazy"));

function RemoveShorterStrings(array, value) {
  for (let i = 0; i <= array.length - 1; i++) {
    // console.log(array[i], array[i].length);
    if (array[i].length < value) {
      array.splice(i, 1);
    }
  }
  return array;
}
// console.log(
//   RemoveShorterStrings(["Jeton", "Dog", "Nancy", "Carl", "Happy", "Cat"], 4)
// );
