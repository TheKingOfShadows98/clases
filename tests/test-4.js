function Test(title, predicate) {
    if(predicate())console.log('✔️ ', title);
    else console.log('❌ ', title);
}

Test("prueba 1", ()=>{
    transfer('Carlitos','Anita', 3);
    let espect = JSON.stringify({'from':"Carlitos", 'to': "Anita", 'amount': 3})
    return JSON.stringify(log[-1]) == espect;
});

Test("prueba 2", ()=>{
    log = [];
    transfer('Carlitos','Anita', 3);
    transfer('Juansito','Carlitos', 10);
    let espect = JSON.stringify({'from':"Juansito", 'to': "Carlitos", 'amount': 10})
    let bool = JSON.stringify(log[-1]) == espect;
    return bool && log.length === 2;
});

Test("prueba 2", ()=>{
    log = [];
    transfer('Carlitos','Anita', 3);
    transfer('Juansito','Carlitos', 10);
    transfer('Anita','Juansito', 25);
    let espect = JSON.stringify({'from':"Anita", 'to': "Juansito", 'amount': 25})
    let bool = JSON.stringify(log[-1]) == espect;
    return bool && log.length === 3;
});






