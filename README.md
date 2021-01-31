# CrudNetCore5
CRUD con .NET Core 5.0

##### Instalar paquete nuget: 
**Microsoft.EntityFrameworkCore.SqlServer**  --> Permite usar EntityFramework
**Microsoft.EntityFrameworkCore.Tools**  --> Herramienta de diseño y configuración para EntityFramework

# Crear migración.

crea el archivo de migración con la consola de Nuget
```
add-migration MigracionInicial
```
![](https://github.com/cdhernandez5/CrudNetCore5/blob/master/wwwroot/imgMD/ConsolaNuGet.png)


# Archivo de Migración:
![](https://github.com/cdhernandez5/CrudNetCore5/blob/master/wwwroot/imgMD/ArchivoMigracion.png)
- Up --> La configuración de las tablas de acuerdo con los DbSet
- Down --> Revierte la migración.


# Comando para crear en la base de datos las tablas: 
```
update-database
```

Tutorial seguido de [aquí](https://www.youtube.com/watch?v=3mu2K5vXcxc).
