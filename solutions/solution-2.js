
let _balance =  
{
    'dolar':10,
    'cinco':10,
    'diez':10,
    'veinte':10,
}

const Balance = () => _balance;

const Deposit = (papers) => {
    _balance.dolar += papers.dolar;
    _balance.cinco += papers.cinco;
    _balance.diez += papers.diez;
    _balance.veinte += papers.veinte;
};

const Withdraw = (amount) => {
    let billetes20 = Math.floor(amount/20);
    amount -= billetes20 * 20;
    let billetes10 = Math.floor(amount/10);
    amount -= billetes10 * 10;
    let billetes5 = Math.floor(amount/5);
    amount -= billetes5 * 5;
    let billetes1 = Math.floor(amount/1);
    amount -= billetes1 * 1;
    let result = {
        'dolar': billetes1,
        'cinco': billetes5,
        'diez': billetes10,
        'veinte': billetes20
    } 
    return result;
}

/*
[Tests]
*/
const Test = (title, predicate)=> {
    if(predicate())console.log('✔️ ', title);
    else console.log('❌ ', title);
}
Test("Balance", ()=>{
    let assert = JSON.stringify({
        'dolar':10,
        'cinco':10,
        'diez':10,
        'veinte':10,
    });
    return JSON.stringify(Balance()) === assert;
});

Test("Deposit", ()=>{
    Deposit({
        'dolar':5,
        'cinco':3,
        'diez':6,
        'veinte':8,
    });
    let assert = JSON.stringify({
        'dolar':15,
        'cinco':13,
        'diez':16,
        'veinte':18,
    });
    return JSON.stringify(Balance()) === assert;
});

Test("WithDraw", ()=>{
    let assert = JSON.stringify({
        'dolar':3,
        'cinco':0,
        'diez':1,
        'veinte':0,
    });
    let value = Withdraw(13);
    return JSON.stringify(value) === assert;
});


