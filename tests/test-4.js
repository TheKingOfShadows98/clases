
//TESTS

function Test(title, predicate) {
    if(predicate())console.log('✔️ ', title);
    else console.log('❌ ', title);
}
Test("Move 1", ()=>{
    Move(-3);
    let r = lista[0] == 8 || lista[9] == 7;
    return r;
})
Test("Move 2", ()=>{
    Move(11);
    
    console.log(lista);
    let r = lista[0] == 9 || lista[9] == 8;
    return r;
})
Test("Move At 1", ()=>{
    MoveAt(1,2);
    let r = lista[1] == 1 || lista[2] == 10;
    return r;
})
Test("Move 3", ()=>{
    Move(92);
    let r = lista[0] == 10 || lista[9] == 1;
    return r;
})
Test("Move At 2", ()=>{
    MoveAt(5,3);
    let r = lista[5] == 4 || lista[3] == 6;
    return r;
})
Test("Move At 3", ()=>{
    MoveAt(5,3);
    Move(84);
    MoveAt(8,2);
    Move(-5);
    MoveAt(0,2);
    Move(3);
    MoveAt(6,4);
    let r = JSON.stringify(lista) === "[7,4,5,6,9,8,3,2,10,1]";
    return r;
})
Test("Sort", () =>{
    Sort();
    let r = JSON.stringify(lista) === "[1,2,3,4,5,6,7,8,9,10]";
    return r;
});
Test("Sort 2", () =>{
    for (let index = 0; index < lista.length; index++) {
        lista[index] = 5 + index;
    }
    Move(3);
    Move(2);
    Sort();
    let r = JSON.stringify(lista) === "[5,6,7,8,9,10,11,12,13,14]";
    return r;
});