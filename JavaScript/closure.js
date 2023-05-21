function getFirstName(firstName){
    console.log("Hi", firstName);
    return function getLastLame(lastName){
        console.log("Hello", lastName );
        return function printFullName(){
            console.log("Hi", firstName,lastName);
        }
    }
}
