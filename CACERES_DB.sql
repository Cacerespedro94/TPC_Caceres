Create database CACERES_DB
go
use CACERES_DB
go
Create table SubCategoria(
Id int not null primary key identity (1,1),
Nombre varchar(100) not null, 
)
go
Create Table Producto( 
ID int not null identity (1,1),       
Nombre varchar(100) not null, 
Descripcion varchar(100) not null, 
IdCategoria bigint not null foreign key references Categoria(Id), 
IdSubCategoria int null foreign key references SubCategoria(Id), 
Precio money not null,    
ImagenUrl varchar (100) not null,
Cantidad int null,
)
go

Create table Categoria(
Id bigint not null primary key identity (1,1),
Nombre varchar(100) not null, 
)
go
insert into CATEGORIA values ('Celulares'),('Televisores'), ('Media'), ('Audio')
go
insert into SubCategoria values ('Pintados')
go

insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg')
insert into Producto values ('Prueba', 'Es una descripcion', 2, 1, 1000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg')
insert into Producto values ('Prueba2', 'la descripcion bla bla', 1, 1, 8000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg')
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg')
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg')