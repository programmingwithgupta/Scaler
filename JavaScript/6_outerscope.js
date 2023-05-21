var varname = 10 ;

function b(){
    console.log(varname); 
}
function fn(){
    var varname= 20;
    b();
    console.log(varname);
}
fn();