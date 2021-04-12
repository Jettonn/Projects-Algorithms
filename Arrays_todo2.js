function Reverse(array) {
  for (let i = 0; i < array.length / 2; i++) {
    var swap = array[i];
    array[i] = array[array.length - 1 - i];
    array[array.length - 1 - i] = swap;
  }
  return array;
}

// console.log(Reverse([1, 2, 3, 4, 5, 6]));

function Rotate(array, shiftBy) {
  let i = 0;
  while (i < Math.abs(shiftBy)) {
    if (shiftBy < 0) {
      for (let j = 0; j < array.length - 1; j++) {
        var swap = array[j];
        array[j] = array[j + 1];
        array[j + 1] = swap;
      }
      i++;
    } else {
      for (let j = 0; j < array.length - 1; j++) {
        var swap = array[array.length - 1];
        array[array.length - 1] = array[j];
        array[j] = swap;
      }
      i++;
    }
  }
  return array;
}

// console.log(Rotate([1, 2, 3, 4, 5, 6], -1));

function FilterRange(array, min, max) {
  for (let i = 0; i < array.length; i++) {
    if (array[i] < min || array[i] > max) {
      for (let j = i; j < array.length - 1; j++) {
        var swap = array[j];
        array[j] = array[j + 1];
        array[j + 1] = swap;
      }
      array.pop();
    }
  }
  return array;
}
// console.log(FilterRange([1, 2, 3, 4, 5, 6], 2, 5));

function Concat(array1, array2) {
  var concatedArray = [];
  for (let i = 0; i < array1.length + array2.length; i++) {
    if (i < array1.length) {
      concatedArray[i] = array1[i];
    } else {
      concatedArray[i] = array2[i - array1.length];
    }
  }
  return concatedArray;
}

// console.log(Concat(["a", "b", "c"], [1, 2, 3, 4]));
