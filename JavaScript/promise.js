// const fs = require("fs");
// console.log("Before");
// fs.readFile("./f1.text", function(error, data){
//     if(error){
//         console.log(error);
//     }
//     else{
//         console.log(data);
//     }
// })
// console.log("After");

//some issues  ->callback hell
//inversion of control
//trust issues 
//nesting of callbacks -> pyramid of doom
//2015 -> promises 

console.log("before promise");
const promise = fs.promises.readFile("./f1.txt");
// promise.then(function(datat){
//     console.log("data", data);
// });
// promise.catch(function(err){
//     console.log("error", err);
// })
// console.log("after");

// advantages -> nesting trust issues, inversion of control
//promises -> cb will have priority than normal cb
// it's queue is known as microTask Queue

//disadvantage -> complex syntax


console.log("before");
(async function(){
    try{
        const data = await promise;
        console.log("data", data);
    }
    catch(err)
    {
        console.log("error", err);
    }
})();
console.log("after");