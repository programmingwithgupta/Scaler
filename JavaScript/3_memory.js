// code inside js is executed in 2 separate steps
// 1 phase : memory allocation -> hoisting
            //1. function statements -> memory is allocated
            //2. var -> undefined 
// 2 phase -> code is executed 



// function real(){
//     console.log("I am real one");
// }

// function real(){
//     console.log("No, I am real one");
// }

// real();
// function real(){
//     console.log("You both are wasted");
// }

console.log(a);  // undefined 
var a;  

//TDZ -> temporal dead zone in which you can access variable  using let and const 
//let is in TDZ before initialization
console.log(a);  // error 
let a;





