# REGISTRO DE TRANSFERENCIAS

Tu PM te indica que se necesitan guardar las transferencias y retiros de cada transaccion.
para eso necesitaras hacer un log que almacene, la cantidad de la transferencia, si es un retiro o si se transfiere a otra cuenta.

Para esto tienes estos datos de inicio:

```js
//Base de datos con los usuarios para este ejercicio.
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
```
Las transferencias serán de de una persona a otra, y una cantida:
Ejemplo:
```js
{'from':"Juansito", 'to': "Anita", 'amount': 3}
```

Hay Codigo ya realizado por un compañero tuyo que te puede ayudar a continuar:

```js
    let Log = []; // Almacena los registros.
    function transfer(from, to, amount){
        // Recorre cada usuario dentro de DB
        for (let index = 0; index < DB.length; index++) {
            const element = DB[index]; // obtiene el objeto Usuario
            if(element.nombre == from){
                element.balance -= amount; // retira del emisor la cantidad de dinero
            }
            if(element.nombre == to){
                element.balance += amount; // deposita al receptor la cantidad de dinero
            }
        }
        // Falta crear y añadir los registros a log
    }
```

Para que la prueba se considere completa se deben corer los test correspondientes y salir todos correctos.

Desafio Extra: Calcula el estado final de DB en base a los logs generados con una funcion.