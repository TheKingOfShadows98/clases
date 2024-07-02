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