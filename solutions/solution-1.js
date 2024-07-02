let _balance = 10;

const Balance  = () => _balance;

const Deposit = (amount) => _balance += amount;

const Withdraw = (amount) => {
    if(_balance - amount < 0) return false;
    _balance -= amount;
    return true;
}
/*
[Tests]
*/
const Test = (title, predicate)=> {
    if(predicate())console.log('✔️ ', title);
    else console.log('❌ ', title);
}

Test( "Balance Inicial", ()=> Balance() === 10);
Test( "Deposit", ()=> {
    Deposit(5);
    return Balance() === 15;
});
Test( "WithDraw 01", ()=> {
    Withdraw(10);
    return Balance() === 5;
});
Test( "WithDraw 02", ()=> {
    return !Withdraw(10);
});