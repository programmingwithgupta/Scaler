var num = 10;

console.log(num);

function fun(){
    console.log(num);
    var num = 20;
    num++;
    console.log(num);
    if(num){
        var num = 30;
        num++;
        console.log(num);
    }
    console.log(num);
}

fun();

console.log(num);


//------------------------------

var num = 10;

console.log(num);

function fun(){
    //console.log(num);
    let num = 20;
    num++;
    console.log(num);
    if(num){
        let num = 30;
        num++;
        console.log(num);
    }
    console.log(num);
}

fun();

console.log(num);