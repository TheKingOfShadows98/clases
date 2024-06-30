/*
 Te han contratado para programar el software para el funcionamiento de un ATM, para esto tu PM ha decidido separar el software en partes.

 Primera parte.

 Describe una funcion 'Deposit' que permita el ingreso de dinero en forma numerica.
 Describe una funcion 'Balance' que retorle la cantidad de dinero que tiene el ATM dentro.
 Describe una funcion 'Withdraw' que retire el dinero que desee el usuario, si el dinero es insuficiente, retorne false, sino, retorne true.
 El ATM empezará con 10 dolares en su balance.
*/ 

let _balance = 10;

const Balance = () => _balance;

const Deposit = (amount) => _balance += amount;

const Withdraw = (amount) => {
    if(_balance - amount < 0) return false;
    _balance -= amount;
        return true;
}

if(Balance() === 10) console.log('✔️ Balance Inicial​');
else console.log('❌ Balance Inicial');

Deposit(5)
if(Balance() === 15) console.log('✔️ Deposit');
else console.log('❌ Deposit');

Withdraw(10)
if(Balance() === 5) console.log('✔️ WithDraw');
else console.log('❌ WithDraw');

if(!Withdraw(10)) console.log('✔️ WithDraw out of Bounds');
else console.log('❌ WithDraw out of Bounds');
