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
