# Listas!

| *DIFICULTAD ['D','I','F','I','C','I','L']*



Te gustan las listas?, espero que si, porque este ejercicio sera un entrenamiento de operar con listas y ordenamiento.

Empecemos con lo primero, tendras una lista de enteros del 1 al 10 ordenados de menor a mayor.

```js
const lista = [1,2,3,4,5,6,7,8,9,10];
```
luego de esto deberas hacer un metodo llamado Move() que permita mover los numeros una cantidad X hacia la derecha si X es positivo y a la izquierda si es negativo.

```js
const lista = [1,2,3,4,5,6,7,8,9,10];

Move(3) // Retorna [8,9,10,1,2,3,4,5,6,7];
Move(-2) // Retorna [10,1,2,3,4,5,6,7,8,9];
```
*Las pruebas tendran numeros aleatoreos entre -20 y 20, siempre enteros.*

Ya teniendo el movimiento completo de la lista que pasa si lo desordenamos?
Haz una funcion llamada MoveAt() que pida dos valores entre 0 y 9, estos valores son 2 posiciones del arreglo. haz que cambie los numeros que son indicados.

```js
const lista = [1,2,3,4,5,6,7,8,9,10];
MoveAt(2,4); // Retorna [1,2,5,4,3,6,7,8,9,10]; Cambio el 3 por el 5 y vicebersa.
MoveAt(8,3); // Retorna [1,2,5,9,3,6,7,8,4,10]; Cambio el 9 por el 4 y vicebersa.
```
Esto permite ordenar y desordenar a comveniencia dando espacio a cosas mas curiosas y divertidas.

Ok, ya esto es un lio tremendo, por estar moviendo la lista y cambiando numeros de posicion la Lista se ah desordenado completamente.
necesitamos una funcion Sort() que permita ordenar la lista a como necesitamos.
No sabras como esta ordenada la lista en este momento del ejercicio, incluso en una parte de las pruebas los datos cambiaron y ahora no son los numeros iniciales, pero si son consecutivos, mayores que 0 y enteros. 

```js
const lista = [?,?,?,?,?,?,?,?,?,?]; // No Sabes como estan los numeros en este momentos solo que son 10 numeros no repetidos y son consecutivos
Sort() // Retorna [1,2,3,4,5,6,7,8,9,10] Ordena los numeros de menor a mayor
```
*Nota Este ultimo ejercicio de sort va a ser complicado, de hecho hay varios metodos de ordenacion asique preparate y no te preocupes si te toma mucho tiempo.*

*Nota la lista es un const siempre, por tanto no podras asignar completamente la lista de regreso, y los metodos afectan a la lista y no retornan una nueva lista*

Si logras hacer estos ejercicos estas ya no eres un novato en listas y puedes ejecutar funciones complejas.
Felicidades y Mucha suerte con el ejercicio.

### **PARA COMPROBAR SI LA SOLUCION ES CORRECTA, COPIA LOS TESTS DEL EJERCICIO Y EJECUTA EL SCRIPT, SI TODOS MUESTRAN UN ✔ EN CONSOLA, HAZ PASADO LA PRUEBA**