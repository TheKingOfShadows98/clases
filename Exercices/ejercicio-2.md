
 Segunda parte Adision de Billetes

 Tu PM ve bien los avances, pero ha surgido un problema y es que los usuarios quieren pagar con billetes de distintos tipos.
 Especificamente ahora quieren pagar con billetes de Uno, Cinco, Diez y Veinte dolares.

 Es por eso que tu ProductManager te indica que ahora el Cajero debe almacenar un valor para cada billete que tiene dentro y te da este codigo de ejemplo.

```js
const _balance = {
   'dolar':10, 
   'cinco':10, 
   'diez':10, 
   'veinte':10
   };
```

Adicionalmente tambien indica que tienes que cambiar la funcion de Deposit para que acepte los billetes nuevos de la siguiente forma:

```js
 Deposit({
   'dolar':1, 
   'cinco':3, 
   'diez':2, 
   'veinte':1
   });
```
Eso permite a los usuarios depositar en los billetes que desen.
Tambien al momento de Retirar los billetes queremos que el cajero pueda sacar la cantidad de dinero pero en billetes.

```js

WithDraw(25) //esto debe retornar un objeto con los billetes que sumen la cantidad

//Resultado
{
   'dolar':0, 
   'cinco':1, 
   'diez':0, 
   'veinte':1
}

```
al momento de Retirar procura entregar la mayor cantidad de billetes de mayor denominacion posibles sin pasarte de la cantidad requerida.
en caso que el ATM no tenga la cantidad suficiente para realizar el retiro debe lanzar un log de error y retornar 0 billetes.

 - Modifica balance para que retorne un objeto con la cantidad de billetes que tiene y de que tipo.

Por Ultimo cuando se solucite el balance del ATM debe retornar la cantidad de billetes que tiene almacenados.
Tambien se ha repuesto el ATM con 10 billetes de cada denominacion para las pruebas.



### **PARA COMPROBAR SI LA SOLUCION ES CORRECTA, COPIA LOS TESTS DEL EJERCICIO Y EJECUTA EL SCRIPT, SI TODOS SALEN CORRECTOS, HAZ PASADO LA PRUEBA**