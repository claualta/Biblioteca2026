# Desarrollo VB.NET + MariaDB - POE

## Preparacion entorno de desarrollo

1. Descargar e Instalar Visual Studio 2022 o 2026 Community https://visualstudio.microsoft.com/es/

2. Descargar e instalar MariaDB 11.8.8 https://mariadb.org/download/


## Aplicacion de ejemplo

1. Clonar repositorio `git clone https://github.com/claualta/Biblioteca2026.git`

2. Agregar la BD al servidor MariaDB desde `Biblioteca2026/database/Biblioteca_MariaDB_Completa_Seed.sql`

3. Abrir VS Community -> Abrir Proyecto 
	
	
## Crear proyecto propio

1. Abrir Visual Studio y seleccionar *Crear un proyecto*

2. Filtrar por *Visual Basic* - *Windows* - *Escritorio*

3. Seleccionar *Aplicacion de Windows Forms (WinForms) de .NET*

4. Instalar MySQLConnector
	a. Click derecho sobre la *Solucion...*
	b. Administrar paquetes NuGet
	c. Examinar
	d. Buscar *MySQLConnector*
	e. Seleccionar el proyecto
	f. Instalar
	
5. Para control de versiones con GIT de un proyecto VB.NET
   se debe generar en la carpeta del proyecto el archivo `.gitignore` con:

```
.vs/
bin/
obj/
packages/
*.user, *.suo
```





