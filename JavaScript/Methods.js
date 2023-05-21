const arr = [1, 2, 3];


var a = arr.map(x => x * 10);
console.log(a);
console.log(arr);

var a = arr.filter(x => x%2 !== 0);
console.log(a);
console.log(arr);

var a = arr.find(x => x !== 2);
console.log(a);
console.log(arr);

var a = arr.reduce((acc, cur) => acc + cur);
console.log(a);
console.log(arr);

//remove elements from start index to end index, doesn't change the array 
var a = arr.slice(1, 2);
console.log(a);
console.log(arr);

//remove elements from start index to end index and change the array 
//additionally can add elements at given start index if provided more than 2 params 
var a = arr.splice(1, 2, 0);
console.log(a);
console.log(arr);