// class Employee{
// 	id : number
// 	name : string
// };

// var employees = [];

// var emp = {id: 2, name: "Bhawna"};

// employees.splice(0,0,emp);

// var emp2 = {id: 1, name: "Arpit"};
// employees.splice(0,0,emp2);

const skills = ["c#", "Angular", "Javascript", "Sql"];
 
skills.splice(2, 0, "BI", "R");
console.log(skills);
 let a =    [1,2,3,4];
let b =   [5,6,7,8];

a.concat(b);


var res= [...a, ...b];
console.log(res);