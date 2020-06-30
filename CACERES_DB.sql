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
Id int not null primary key identity (1,1),      
Nombre varchar(100) not null, 
Descripcion varchar(100) not null, 
IdCategoria bigint not null foreign key references Categoria(Id), 
--IdSubCategoria int null foreign key references SubCategoria(Id), 
Precio money not null,    
ImagenUrl varchar (300) not null,
--Cantidad int null,
Stock int not null,
Eliminado bit not null,
)
select * from Producto
go

Id int not null primary key identity (1,1),
Nombre varchar (100) not null,
)
select * from TipoUsuario
go
insert into TipoUsuario values ('Admin'),('Cliente')
go
create table Direccion(
Id int not null primary key identity (1,1),
Calle varchar(100) not null,
Altura int not null,
CodigoPostal varchar(50) null,
Provincia varchar(100) not null,
Localidad varchar (100) not null,
)

go

Create table Contacto(
Id int not null primary key identity (1,1),
Email varchar(100) not null,
Telefono varchar(100) not null,
)
go


Create table Cliente(
Id int not null primary key identity (1,1),
Dni bigint null,
Nombre varchar(100) not null,
Apellido varchar(100) not null,
IngresoSesion varchar(100) not null ,
Contraseña varchar(100) not null,
IdTipoUsuario int not null foreign key references TipoUsuario(Id),
IdDireccion int null foreign key references Direccion(Id),
IdContacto int null foreign key references Contacto(Id),
Eliminado bit not null,
)

go

Create table Administrador(
Id int not null primary key identity (1,1),
Nombre varchar(100) not null,
Apellido varchar(100) not null,
IngresoSesion varchar(100) not null ,
Contraseña varchar(100) not null,
IdTipoUsuario int not null foreign key references TipoUsuario(Id),
Eliminado bit not null,
)


go
--create table Proveedor(
--Id int not null primary key identity (1,1),
--Nombre varchar(100) not null,
--IdDireccion int not null foreign key references Direccion(Id),
--IdContacto int not null foreign key references Contacto(Id),
--Eliminado bit not null
--)

--go

--create table Materiales(
--Id int not null primary key identity (1,1),
--Nombre varchar(100) not null,
--Descripcion varchar(100) null,
--IdProveedor int not null foreign key references Proveedor(Id),
--Stock float not null,
--Eliminado bit not null,
--)


Create table Ventas(
Id int not null primary key identity (1,1),
IdCliente int not null foreign key references Cliente(Id),
--IdProducto int not null foreign key references Producto(Id),
Cantidad int not null,
Total money not null,
Fecha date not null
)

go

Create table Productos_Por_Ventas(
IdVenta int not null foreign key references Ventas(Id),
IdProducto int not null foreign key references Producto(Id),
CantidadUnidades int not null,
Precio money not null


primary key (IdVenta,IdProducto)
)

go

Create table Ventas_x_Usuario(
IdVenta int not null foreign key references Ventas(Id),
IdCliente int not null foreign key references Cliente(Id)

primary key (IdVenta,IdCliente)
)
go


insert into CATEGORIA values ('Celulares',0),('Televisores',0), ('Media',0), ('Audio',0)
go
insert into SubCategoria values ('Pintados',0)
go
select * from Producto
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0)
insert into Producto values ('Prueba', 'Es una descripcion', 2, 1, 1000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Prueba2', 'la descripcion bla bla', 1, 1, 8000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)
insert into Producto values ('Arituclo Nombre', 'la descripcion bla bla', 4, 1, 15000, 'https://www.marketingdirecto.com/wp-content/uploads/2020/04/repartir-productos.jpg',0,0,0)

go


--SP LISTAR
create procedure spListarProductos --PRODUCTO
as

select a.id, a.Nombre, a.Descripcion, C.Nombre as DescCat, C.Id as IdCat,  a.ImagenUrl, a.Precio, a.Eliminado from Producto as A inner join Categoria as C on C.Id = a.IdCategoria

go

create procedure spListarCategoria --CATEGORIA
as

select c.id, c.nombre,c.eliminado from Categoria as c where c.Eliminado != 1

go

create procedure spListarSubCategoria --SUBCATEGORIA
as

select s.id, s.nombre,s.eliminado from SubCategoria as s where s.Eliminado != 1

go

create  procedure spListarCliente -- CLIENTE
as
Select c.Id, C.Dni, C.Nombre, C.Apellido, C.IngresoSesion, C.Contraseña,
	   t.Id as TipoClienteId, t.Nombre as TipoClienteNombre, D.Id as DireccionID, D.Calle, D.Altura, D.CodigoPostal, D.Provincia, D.Localidad,con.Id as ContactoID,con.Email, con.Telefono,Eliminado
from Cliente as C
inner join TipoUsuario as t on t.Id = C.IdTipoUsuario
left join Direccion as d on d.Id = C.IdDireccion
left join Contacto as con on con.Id = C.IdContacto
where C.eliminado not like 1
select * from Cliente

go


Create procedure spListarAdministrador --ADMINISTRADOR
as
Select A.Id, A.Nombre, A.Apellido, A.IngresoSesion, a.Contraseña, T.Id

from Administrador as A
inner join TipoUsuario as T on t.Id = a.IdTipoUsuario
where A.Eliminado not like 1


go
create procedure  spListarDireccion -- DIRECCION
as
select D.Id,D.Calle, D.Altura, D.CodigoPostal, D.Provincia,D.Localidad
from Direccion as d

go
create procedure spListarVentas
as
Select * from Ventas
go
create procedure spListarContacto -- CONTACTO
as
select c.Id, c.Email, c.Telefono
from contacto as c

go
--create procedure spListarProveedor -- PROVEEDOR
--as
--select p.Id, p.Nombre, d.Id as IdDireccion, d.Calle, d.Altura, d.CodigoPostal, d.Localidad, d.Provincia, Cont.Id as IdContacto, Cont.Email, Cont.Telefono, P.Eliminado
--from Proveedor as p
--inner join Direccion as D on p.IdDireccion = D.Id
--inner join Contacto as Cont on p.IdContacto = Cont.Id
--Where p.Eliminado !=1

--go


--Create procedure spListarMaterial -- MATERIAL
--as 
--select M.Id, M.Nombre, m.Descripcion, m.Stock, P.Id as IDPROVEEDOR, p.Nombre, m.Eliminado 
--from Materiales as M
--inner join Proveedor as P on p.Id = M.IdProveedor
--where M.eliminado = 0

--go

--SP AGREGAR

create procedure spAgregar --PRODUCTO

@Nombre varchar(100), 
@Descripcion varchar(100), 
@IdCategoria bigint, 
@Precio money,    
@ImagenUrl varchar (300)
as 
Insert into Producto  (Nombre,Descripcion,IdCategoria,Precio,ImagenUrl,Stock,Eliminado)
		values(@Nombre, @Descripcion, @IdCategoria, @Precio, @ImagenUrl,0,0)
go




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

--@Dni bigint,
@Nombre varchar(100),
@Apellido varchar(100),
@IngresoSesion varchar(100),
@Contraseña varchar(100),
@IdTipoUsuario int

--@IdDireccion int,
--@IdContacto int
as

insert into Cliente (Nombre,Apellido,IngresoSesion,Contraseña,IdTipoUsuario,Eliminado)
values (@Nombre, @Apellido,@IngresoSesion,@Contraseña,@IdTipoUsuario,0)

go

Create procedure spAgregarAdministrador --ADMINISTRADOR

@Nombre varchar(100),
@Apellido varchar(100),
@IngresoSesion varchar(100),
@Contraseña varchar(100),
@IdTipoUsuario int,
@Eliminado bit
as 
insert into Administrador(Nombre, Apellido,IngresoSesion,Contraseña,IdTipoUsuario,Eliminado)
values (@Nombre,@Apellido,@IngresoSesion,@Contraseña,@IdTipoUsuario,0)

go

--exec spAgregarAdministrador 'Pedro', 'Caceres', 'Cacerespedro@gmail.com','0176',1,0


create procedure spAgregarVenta
@IdCliente int,
@Cantidad int ,
@Total money,
@Fecha date
as

insert into Ventas(IdCliente,Cantidad,Total,Fecha)
values (@IdCliente, @Cantidad,@Total,@Fecha)

go

create procedure spAgregarProductos_Por_Ventas
@IdVenta int,
@IdProducto int,
@CantidadUnidades int,
@Precio money

as
insert into Productos_Por_Ventas(IdVenta,IdProducto,CantidadUnidades,Precio)
values (@IdVenta, @IdProducto,@CantidadUnidades,@Precio)

go

Create procedure spVentas_x_Usuario
@IdCliente int,
@IdVenta int
as
insert into Ventas_x_Usuario(IdCliente,IdVenta)
values (@IdCliente,@IdVenta)
go

go
create procedure spAgregarDireccion --DIRECCION

@Calle varchar(100),
@Altura int,
@CodigoPostal varchar(50),
@Provincia varchar(100),
@Localidad varchar (100)
as
Select * from Productos_Por_Ventas
insert into Direccion values (@Calle, @Altura, @CodigoPostal, @Provincia, @Localidad) 
go

select * from Ventas
go
select * from Productos_Por_Ventas
go
select * from Ventas_x_Usuario


create procedure spAgregarContacto -- CONTACTO
@Email varchar(100),
@Telefono varchar(100)
as 
insert into contacto values (@Email,@Telefono)

go

Create Procedure spAgregarProveedor -- PROVEEDOR

@Nombre varchar(100),
@IdDireccion int,
@IdContacto int

as

insert into Proveedor values (@Nombre, @IdDireccion, @IdContacto,0)
go

Create procedure spAgregarMaterial -- MATERIAL

@Nombre varchar(100),
@Descripcion varchar(100),
@IdProveedor int,
@Stock float
as

insert into Materiales values (@Nombre, @Descripcion, @IdProveedor, @Stock, 0)

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

Create procedure spEliminarMaterial -- MATERIAL

@ID int

as

Update Materiales Set Eliminado = 1 where ID =  @ID

go
Create procedure spEliminarProveedor --Proveedor
@ID int

as

Update Proveedor Set Eliminado = 1 where ID =  @ID

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
update Cliente set Dni = @Dni, Apellido = @Apellido, Nombre =  @Nombre , IngresoSesion =  @IngresoSesion,
Contraseña = @Contraseña, IdDireccion = @IdDireccion
where ID = @ID

go


Create Procedure spModificarProveedor -- PROVEEDOR
@ID int,
@Nombre varchar(100),
@IdDireccion int,
@IdContacto int

as

update Proveedor set Nombre = @Nombre, IdDireccion = @IdDireccion, IdContacto = @IdContacto where Id= @ID
go

Create procedure spModificarMaterial -- MATERIAL
@ID int,
@Nombre varchar(100),
@Descripcion varchar(100),
@IdProveedor int,
@Stock float
as

Update Materiales set Nombre = @Nombre, Descripcion = @Descripcion, IdProveedor = @IdProveedor, Stock = @Stock where Id = @Id

go

select * from contacto

select * from cliente

select * from Direccion


go


Create procedure spListarVentasCliente


@IdVenta int

as


select P.Nombre, p.Precio, v.Fecha, v.Id as Venta, PxV.CantidadUnidades

from producto as p
inner join  Productos_Por_Ventas as PxV on PxV.IdProducto = p.Id
inner join Ventas as V on v.Id = PxV.IdVenta


Where v.Id = @IdVenta
go



--create  procedure spListarCompras

--@IdCliente int

--as
--Select v.Id, sum(p.Precio * v.Cantidad) as Subtotal, v.Fecha, sum(v.Cantidad) as Cantidad
--from Cliente as C
--inner join Ventas_x_Usuario as VxU on VxU.IdCliente = c.Id
--inner join Productos_Por_Ventas as PxV on Pxv.IdVenta = VxU.IdVenta
--inner join Producto as P on P.Id = PxV.IdProducto
--inner join Ventas as v on v.IdProducto =P.Id

--where c.Id = @IdCliente
--group by v.Id,v.Fecha

--go

create procedure spListarCompras

@IdCliente int

as
Select distinct v.Id, v.Total, v.Fecha, v.Cantidad
from Ventas as V
inner join Ventas_x_Usuario as VxU on Vxu.IdVenta = v.Id
inner join Cliente as c on c.Id = VxU.IdCliente
inner join Productos_Por_Ventas as PxV on PxV.IdVenta = v.Id
inner join Producto as P on P.Id = PxV.IdProducto 


where v.IdCliente = @IdCliente

go

create procedure spListarVentasAdministrador
as
select distinct v.Id, c.Apellido,c.nombre, v.total, v.Cantidad, v.fecha
from Ventas as V
inner join Ventas_x_Usuario as VxU on Vxu.IdVenta = v.Id
inner join Cliente as c on c.Id = VxU.IdCliente
inner join Productos_Por_Ventas as PxV on PxV.IdVenta = v.Id
inner join Producto as P on P.Id = PxV.IdProducto 
go

exec spListarVentasAdministrador