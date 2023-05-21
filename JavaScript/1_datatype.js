// JS is dyanamic typed language 

//int a will throw error
var a;
console.log("Value inside a is ", a);
//default in js in always undefined 

function fn()
{

}

let rval= fn();
console.log("Value inside rVal is ", rval); // return undefined 


let cap ={
    name: "Steve",
    age: 35
}

console.log(cap.name);
console.log(cap.age);
console.log(cap.key); // return undefined 

//JS a lang
//primitive type => atomic types => number, string, boolean, undefined, null, Symbol and  BigInt

//numbers are 64 bit floating value 
    console.log(5/2); // 2.5 
var c= 3.1+2.9;
console.log(c); // return 6 not 6.0 because JS round off the value 
console.log(c.toFixed(2)); // return 6.00

console.log({a:"hello"}+1);  // return [object Object]1

//NAN -> not a number 
console.log(undefined+1);  //NAN


//Symbol used to declare primitive that has unique value 
let s = Symbol();
let s2 = Symbol();
console.log(s==s2);

let obj = {
    name: "Steve",
    id: 25678
}

obj.LastName = "Rogers";
obj.id = 12345;
console.log(obj);

var key = Symbol("id");
obj[key] = 123456;
console.log(obj);



var bar = null;

console.log(typeof bar === "object");  // returns true