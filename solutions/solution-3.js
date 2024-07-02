const DB = [
    {
    "nombre": 'Carlitos',
    "balance": 100
    },
    {
    "nombre": 'Anita',
    "balance": 100
    },
    {
    "nombre": 'Juansito',
    "balance": 100
    }
]

let log = []

function transfer(from, to, amount){
        
        for (let index = 0; index < DB.length; index++) {
            const element = DB[index];
            if(element.nombre == from){
                element.balance -= amount;
            }
            if(element.nombre == to){
                element.balance += amount;
            }
        }
        /// SOLUCION
        let entry = {'from': from, 'to': to, 'amount': amount}
        log.push(entry);
        /// 
}

//TESTS

function Test(title, predicate) {
    if(predicate())console.log('✔️ ', title);
    else console.log('❌ ', title);
}

Test("prueba 1", ()=>{
    transfer('Carlitos','Anita', 3);
    let espect = JSON.stringify({'from':"Carlitos", 'to': "Anita", 'amount': 3})
    return JSON.stringify(log[0]) == espect;
});

Test("prueba 2", ()=>{
    log = [];
    transfer('Carlitos','Anita', 3);
    transfer('Juansito','Carlitos', 10);
    let espect = JSON.stringify({'from':"Juansito", 'to': "Carlitos", 'amount': 10})
    
    let bool = JSON.stringify(log[1]) == espect;
    return bool && log.length === 2;
});

Test("prueba 3", ()=>{
    log = [];
    transfer('Carlitos','Anita', 3);
    transfer('Juansito','Carlitos', 10);
    transfer('Anita','Juansito', 25);
    let espect = JSON.stringify({'from':"Anita", 'to': "Juansito", 'amount': 25})
    let bool = JSON.stringify(log[2]) == espect;
    return bool && log.length === 3;
});


