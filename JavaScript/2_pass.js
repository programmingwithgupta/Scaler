function modifier(a,b){
    console.log(a,b);
    a[0]= 1;
    b[1] = 2;
    a= 10;
    b= 20;
    console.log(a,b);
}

let p = [4,7,9];
let q = [3,6,8];
console.log(p,q);
modifier(p,q);
console.log(p,q);