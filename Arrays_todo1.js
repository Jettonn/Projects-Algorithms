function PushFront(array, value) {
  for (let i = array.length - 1; i >= 0; i--) {
    array[i + 1] = array[i];
  }
  array[0] = value;
  return array;
}

// console.log(PushFront([1, 2, 3, 4], 0));

function PopFront(array) {
  for (let i = 0; i < array.length - 1; i++) {
    var swap = array[i];
    array[i] = array[i + 1];
    array[i + 1] = swap;
  }
  return array.pop();
}

// console.log(PopFront([1, 2, 3, 4]));

function InsertAt(array, index, value) {
  for (let i = array.length; i > index; i--) {
    array[i] = array[i - 1];
  }
  array[index] = value;
  return array;
}
// console.log(InsertAt([1, 2, 3, 4],2,5));

function RemoveAt(array, index) {
  for (let i = index; i < array.length - 1; i++) {
    var swap = array[i];
    array[i] = array[i + 1];
    array[i + 1] = swap;
  }
  return array.pop();
}
// console.log(RemoveAt([1, 2, 3, 4],2));

function SwapPairs(array) {
  for (let i = 1; i < array.length; i += 2) {
    var swap = array[i];
    array[i] = array[i - 1];
    array[i - 1] = swap;
  }
  return array;
}
// console.log(SwapPairs([1,2,3,4]));
// console.log(SwapPairs(["Brendan",true,42]));

function RemoveDuplicates(array) {
  var noDuplicatesArray = [];
  for (let i = 0; i < array.length - 1; i++) {
    if (array[i] != array[i + 1]) {
      noDuplicatesArray.push(array[i]);
    }
  }
  noDuplicatesArray.push(array[array.length - 1]);
  return noDuplicatesArray;
}

// console.log(
//   RemoveDuplicates(["Jeton", "Jeton", "Matt", "Matt", "Nancy", "Nancy", "Carl"])
// );
