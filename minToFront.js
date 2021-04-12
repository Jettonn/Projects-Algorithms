function MinToFront(array) {
  var min = array[0];
  var index = 0;
  for (let i = 0; i < array.length; i++) {
    if (array[i] < min) {
      min = array[i];
      index = i;
    }
  }

  for (let i = index; i < array.length - 1; i++) {
    var swap = array[i];
    array[i] = array[i + 1];
    array[i + 1] = swap;
  }
  array.pop();

  for (let i = array.length - 1; i >= 0; i--) {
    array[i + 1] = array[i];
  }
  array[0] = min;
  return array;
}

console.log(MinToFront([4, 2, 1, 3, 5]));
