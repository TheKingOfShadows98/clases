# ATM PARTE 1

| *DIFICULTAD MEDIA*

Te han contratado para programar el software para el funcionamiento de un ATM, para esto tu PM ha decidido separar el software en partes.

Necesitamos que el ATM guarde la informacion de cuanto dinero contiene dentro, crea una variable que almacene el dinero que tiene expresado en dolares enteros.

Luego necesitamos una funcion que acceda a es valor llamada 'Balance', esta no debe pedir parametros.

Aparte de esto necesitamos una funcion que ingrese dinero al ATM llamada 'Deposit', esta debe pedir por parametro un valor numerico y sumar el valor a la cantidad de dinero en el ATM. *Esta funcion solo recivira numeros en los tests*

Por ultimo una funcion que permita el retiro de dinero del ATM llamada 'Withdraw', esta debe pedir por parametro el valor que se requiere retirar, y debe devolver un valor Bool de si se logro hacer el retiro o el dinero en el ATM es insuficiente, ademas de actualizar la cantida en el ATM con el retiro correspondiente.


**Para crear una funcion en JS se puede realizar de estas maneras**

```js
const myFunction = (params)=>{
    //do something
}

function myFunction (params)=>{
    // do something
}
```

### **PARA COMPROBAR SI LA SOLUCION ES CORRECTA, COPIA LOS TESTS DEL EJERCICIO Y EJECUTA EL SCRIPT, SI TODOS MUESTRAN UN ✔ EN CONSOLA, HAZ PASADO LA PRUEBA**