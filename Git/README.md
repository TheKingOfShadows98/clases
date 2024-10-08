# Tabla de contenido
- [Tabla de contenido](#tabla-de-contenido)
- [G.U.I.A](#guia)
  - [Comando principales para git.](#comando-principales-para-git)
    - [Iniciarlizar un Repositorio](#iniciarlizar-un-repositorio)
    - [Cambios y Registros](#cambios-y-registros)
    - [Ramas del Repositorio.](#ramas-del-repositorio)

# G.U.I.A

+ Git.
+ Usuario.
+ Instructivo.
+ Ayuda.

## Comando principales para git.

*[Puedes encontrar mas informacion desde la pagina oficial de Git aqui](https://git-scm.com/doc)*


### Iniciarlizar un Repositorio
- Iniciar un nuevo repositorio en la posicion de la terminal
    ```bash
    git init
    ```

- Clonar un Repositiorio en linea
    ``` bash
    git clone <enlace>
    ```

[- Volver al Inicio](#tabla-de-contenido)

### Cambios y Registros

- Añadir archivos o carpetas al seguimiento.

    ``` bash
    git add <archivo>
    ```
    En vez de usar un nombre usas un '.', adiciona todos los archivos.
    ``` bash
    git add .
    ```
- Añadir los cambios seguidos al repositorio en un registro nuevo.

    ``` bash
    git commit -m "Titulo del commit"
    ```
    *El -m permite colocar un nombre al commit, en caso contrario se habrira un editor de texto donde debes colocar el nombre.*

    procura que titulo sea descriptivo con los cambios que tiene el commit o registro.

[- Volver al Inicio](#tabla-de-contenido)

### Ramas del Repositorio.

- Adicionar una nueva rama al repositorio.

    ``` bash
    git branch "Mi nueva Rama"
    ```
- Eliminar una rama del Repositorio.

    ``` bash
    git branch -d "Mi nueva Rama"
    ```
- Cambiar a una rama del repositorio.

    ```bash
    git checkout "Rama a la que quiero cambiar"
    ```
    *Tambien se puede usar 
    ```bash
    git checkout -b "Rama" 
    ```
    para crear y cambiar a esa nueva rama.*

    ***Cambiar entre ramas va a eliminar los cambios que no hayan sido registrados al repositorio, procura guardar tus cambios con un commit antes de cambiar.***

- Une una Rama del Repositorio a la rama actual.
    ```bash
    git merge <Rama que quieres unir>
    ```
    *Esto no elimina la rama con la que se uno, solo fusiona los cambios de la otra rama a la rama actual.*

[- Volver al Inicio](#tabla-de-contenido)
