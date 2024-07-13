
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

function getMaxAmount(){
    let n = 20  * _balance.veinte;
    n += 10 * _balance.diez;
    n += 5 * _balance.cinco;
    n += 1 * _balance.dolar;
    return n;
}

const Withdraw = (amount) => {
    
    let errorObject = {
        'dolar': 0,
        'cinco': 0,
        'diez': 0,
        'veinte': 0
    };

    if(amount > getMaxAmount()) return errorObject;

    let billetes20 = Math.min(Math.floor(amount/20), _balance.veinte);
    amount -= billetes20 * 20;

    let billetes10 = Math.min(Math.floor(amount/10), _balance.diez);
    amount -= billetes10 * 10;

    let billetes5 = Math.min(Math.floor(amount/5), _balance.cinco);
    amount -= billetes5 * 5;
    
    let billetes1 = Math.min(Math.floor(amount/1), _balance.cinco) ;
    amount -= billetes1 * 1;

    if(amount > 0) return errorObject;

    let result = {
        'dolar': billetes1,
        'cinco': billetes5,
        'diez': billetes10,
        'veinte': billetes20
    }

    _balance.veinte -= billetes20;
    _balance.diez -= billetes10;
    _balance.cinco -= billetes5;
    _balance.dolar -= billetes1;

    return result;
}

