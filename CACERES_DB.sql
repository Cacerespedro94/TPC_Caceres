use master
Create database CACERES_DB
go
use CACERES_DB
go
Create table Categoria(
Id bigint not null primary key identity (1,1),
Nombre varchar(100) not null,
Eliminado bit not null,
)

go

Create table SubCategoria(
Id int not null primary key identity (1,1),
Nombre varchar(100) not null,
Eliminado bit not null,
)

go

Create Table Producto( 
ID int not null identity,       
Nombre varchar(100) not null, 
Descripcion varchar(100) not null, 
IdCategoria bigint not null foreign key references Categoria(Id), 
IdSubCategoria int null foreign key references SubCategoria(Id), 
Precio money not null,    
ImagenUrl varchar (300) not null,
Cantidad int null,
Stock int not null,
Eliminado bit not null,
)

go

Create table TipoUsuario(
Id int not null primary key identity (1,1),
Nombre varchar (100) not null,
)
select * from cliente
go
insert into TipoUsuario values ('Admin'),('Cliente')
go
create table Direccion(
Id int not null primary key identity (1,1),
Calle varchar(100) not null,
Altura int not null,
CodigoPostal varchar(50),
Provincia varchar(100),
Localidad varchar (100),
)

go

Create table Contacto(
Id int not null primary key identity (1,1),
Email varchar(100) not null,
Telefono varchar(100) not null,
)

go
exec spListarDireccion

Create table Cliente(
Id int not null primary key identity (1,1),
Dni bigint not null,
Nombre varchar(100) not null,
Apellido varchar(100) not null,
IngresoSesion varchar(100) not null ,
Contraseña varchar(100) not null,
IdTipoUsuario int not null foreign key references TipoUsuario(Id),
IdDireccion int not null foreign key references Direccion(Id),
IdContacto int not null foreign key references Contacto(Id),
Eliminado bit not null,
)

go

insert into CATEGORIA values ('Celulares',0),('Televisores',0), ('Media',0), ('Audio',0)
go
insert into SubCategoria values ('Pintados',0)
go

insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Prueba', 'Es una descripcion', 2, 1, 1000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Prueba2', 'la descripcion bla bla', 1, 1, 8000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)

go

--SP LISTAR
create procedure spListarProductos --PRODUCTO
as

select a.id, a.Nombre, a.Descripcion, C.Nombre as DescCat, C.Id as IdCat, S.Nombre as NombreCat,S.Id as IdSub, a.ImagenUrl, a.Precio, a.Eliminado from Producto as A inner join Categoria as C on C.Id = a.IdCategoria inner join SubCategoria as S on S.Id = a.IdSubCategoria where a.Eliminado != 1

go

create procedure spListarCategoria --CATEGORIA
as

select c.id, c.nombre,c.eliminado from Categoria as c where c.Eliminado != 1

go

create procedure spListarSubCategoria --SUBCATEGORIA
as

select s.id, s.nombre,s.eliminado from SubCategoria as s where s.Eliminado != 1

go

create procedure spListarCliente -- CLIENTE
as
Select c.Id, C.Dni, C.Nombre, C.Apellido, C.IngresoSesion, C.Contraseña,
	   t.Id as TipoClienteId, t.Nombre as TipoClienteNombre, D.Id as DireccionID, D.Calle, D.Altura, D.CodigoPostal, D.Provincia, D.Localidad,con.Id as ContactoID,con.Email, con.Telefono,Eliminado
from Cliente as C
inner join TipoUsuario as t on t.Id = C.IdTipoUsuario
inner join Direccion as d on d.Id = C.IdDireccion
inner join Contacto as con on con.Id = C.IdContacto
where C.eliminado not like 1

go

create procedure  spListarDireccion -- DIRECCION
as
select D.Id,D.Calle, D.Altura, D.CodigoPostal, D.Provincia,D.Localidad
from Direccion as d

go
select * from Cliente

create procedure spListarContacto -- CONTACTO
as
select c.Id, c.Email, c.Telefono
from contacto as c

go
--SP AGREGAR

create procedure spAgregar --PRODUCTO

@Nombre varchar(100), 
@Descripcion varchar(100), 
@IdCategoria bigint, 
@IdSubCategoria int, 
@Precio money,    
@ImagenUrl varchar (300)
as 
Insert into Producto values (@Nombre, @Descripcion, @IdCategoria, @IdSubCategoria, @Precio, @ImagenUrl,0,0,0)
go
select * from Direccion
create procedure spAgregarCategoria --CATEGORIA

@Nombre varchar(100)
as 
Insert into Categoria values(@Nombre,0)
go

create procedure spAgregarSubCategoria --SUBCATEGORIA

@Nombre varchar(100)
as 
Insert into SubCategoria values(@Nombre,0)
go

Create procedure spAgregarCliente --CLIENTE

@Dni bigint,
@Nombre varchar(100),
@Apellido varchar(100),
@IngresoSesion varchar(100),
@Contraseña varchar(100),
@IdTipoUsuario int,
@IdDireccion int,
@IdContacto int
as

insert into Cliente values (@Dni,@Nombre, @Apellido,@IngresoSesion,@Contraseña,@IdTipoUsuario,@IdDireccion,@IdContacto,0)

go

go

create procedure spAgregarDireccion --DIRECCION

@Calle varchar(100),
@Altura int,
@CodigoPostal varchar(50),
@Provincia varchar(100),
@Localidad varchar (100)
as

insert into Direccion values (@Calle, @Altura, @CodigoPostal, @Provincia, @Localidad) 
go

create procedure spAgregarContacto -- CONTACTO
@Email varchar(100),
@Telefono varchar(100)
as 
insert into contacto values (@Email,@Telefono)

go

--SP ELIMINAR 
create procedure spEliminar --PRODUCTO

@ID int
as
Update Producto Set Eliminado = 1 where ID =  @ID
go

create procedure spEliminarCategoria --CATEGORIA

@ID int
as
Update Categoria Set Eliminado = 1 where ID =  @ID
go

create procedure spEliminarSubCategoria --SUBCATEGORIA

@ID int
as
Update Categoria Set Eliminado = 1 where ID =  @ID

go

Create procedure spEliminarCliente --CLIENTE

@ID int

as

Update Cliente Set Eliminado = 1 where ID =  @ID

go

--SP MODIFICAR
create procedure spModificar --PRODUCTO

@ID int,
@Nombre varchar(100), 
@Descripcion varchar(100), 
@IdCategoria bigint, 
@IdSubCategoria int, 
@Precio money,    
@ImagenUrl varchar (300)
as

Update Producto  Set Nombre = @Nombre, Descripcion = @Descripcion, IdCategoria = @IdCategoria,
				IdSubCategoria = @IdSubCategoria, Precio = @Precio, ImagenUrl = @ImagenUrl where ID =  @ID

go

create procedure spModificarCategoria --CATEGORIA

@ID int,
@Nombre varchar(100)
as
Update Categoria Set Nombre = @Nombre where ID = @ID

go

create procedure spSubCategoria --SUBCATEGORIA

@ID int,
@Nombre varchar(100)
as
Update SubCategoria Set Nombre = @Nombre where ID = @ID

go

Create procedure spModificarCliente --CLIENTE
@ID int,
@Dni bigint,
@Nombre varchar(100),
@Apellido varchar(100),
@IngresoSesion varchar(100),
@Contraseña varchar(100),
@IdTipoUsuario int,
@IdDireccion int,
@IdContacto int
as
update Cliente set Dni = @Dni, Apellido = @Apellido

go
select * from contacto

select * from cliente

select * from Direccion

--exec spModificar  16,'FACU', 'Descripcion', 1, 1, 5000, "https://www.english-efl.com/wp-content/uploads/2019/12/test.jpg"

--exec spAgregar 'Nombre', 'Descripcion', 1, 1, 5000, "https://www.english-efl.com/wp-content/uploads/2019/12/test.jpg"


--select a.id, a.Nombre, a.Descripcion, C.Nombre as DescCat, C.Id as IdCat, S.Nombre as NombreCat,S.Id as IdSub, a.ImagenUrl, a.Precio from Producto as A inner join Categoria as C on C.Id = a.IdCategoria inner join SubCategoria as S on S.Id = a.IdSubCategoria

--select a.id, a.Nombre, a.Descripcion, C.Nombre as DescCat, C.Id as IdCat, S.Nombre as NombreCat,S.Id as IdSub, a.ImagenUrl, a.Precio, a.Eliminado from Producto as A inner join Categoria as C on C.Id = a.IdCategoria inner join SubCategoria as S on S.Id = a.IdSubCategoria

exec spListarDireccio