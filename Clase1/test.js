
class Test{
    test(title, predicate){
        if(predicate()) console.log('✔️' , title);
    else console.log('❌' , title);
    }
}
export default Test;