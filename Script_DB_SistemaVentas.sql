/* CREACION BASE DE DATOS */

create database sistemaventas;

use sistemaventas;

/* CREACION TABLAS DEL SISTEMA */

create table permisos(
	idPermiso int auto_increment primary key,
	permiso varchar(50) not null
);

create table estados(
	idEstado int auto_increment primary key,
	estado boolean not null,
	descripcion varchar(10) not null
);

create table proveedores(
	idProveedor int auto_increment primary key,
	nomProveedor varchar(100) not null,
	numContacto double not null,
	direccion varchar(200) not null,
	email varchar(80) not null
);

create table usuarios(
	idUsuario int auto_increment primary key,
	nomUsuario varchar(200) not null,
	usuario varchar(50) not null,
	contrasena varchar(10) not null,
	idPermiso int not null,
	idEstado int not null
);

create table productos(
	idProducto varchar(100) primary key,
	nomProducto varchar(200) not null,
	stock int,
	precio double not null,
	descripcion text,
	idProveedor int not null
);

create table ventas(
	idVenta varchar(20) primary key,
	fechaVenta datetime,
	idUsuario int,
	idProductos mediumtext,
	total double
);

/* LLAVES FORANEAS */

alter table productos add constraint fk_producto_proveedor foreign key (idProveedor) references proveedores(idProveedor);
alter table usuarios add constraint fk__usuario_permiso foreign key (idPermiso) references permisos(idPermiso);
alter table usuarios add constraint fk__usuario_estado foreign key (idEstado) references estados(idEstado);
alter table ventas add constraint fk__venta_usuario foreign key (idUsuario) references usuarios(idUsuario);

/* INSERT INICIALES */

insert into permisos values ('1', "Administrador");
insert into permisos values ('2', "Almacenista");
insert into permisos values ('3', "Vendedor");

insert into estados values ('1', '0', "Inactivo");
insert into estados values ('2', '1', "Activo");

insert into usuarios values ('1', "admin", "admin","admin", '1', '1');
insert into usuarios values ('2', "almacen", "almacen", "almacen", '2', '1');
insert into usuarios values ('3', "ventas", "ventas", "ventas", '3', '1');
insert into usuarios values ('4', "Laura Lopez Martinez, "lauralm", "lauralm", '3', '1');
insert into usuarios values ('5', "Luis Alvarez Morales, "luisam", "luisam", '3', '2');

insert into proveedores values ('', "Refrescos Garcia", '432424242', "Calle: Juan Num:1 Col: Centro", "ventas1@refrescosgarcia.com");
insert into proveedores values ('', "Sabritas", '4234456', "Calle: Ana Num:100 Col: Centro", "ventas5@sabritas.com");
insert into proveedores values ('', "Surtidor Farmacia", 'Surtidor Farmacia', "Calle: Obrera Num. 40 Col. Obrera", "surfarmaciaventas@surfarmacia.com");
insert into proveedores values ('', "Proveedor Dulces", '43254365467567', "Calle: Juan Gutierrez Num:10 Col. Sur", "dulceria@dulceria.com");

insert into productos values('75007614', "Refresco de Limon", '50', '10.50', "Refresco 600ml sabor limon",'1');
insert into productos values('7501557140308', "ketorolaco", '1', '80', "ketorolaco 10mg 10 tabletas",'3');

INSERT INTO ventas values (`idVenta`, `fechaVenta`, `idUsuario`, `idProductos`, `total`) VALUES
('2021-11-13 18:51:47', '2021-11-13 18:51:47', 3, '1-75007614', 15),
('2021-11-14 18:51:47', '2021-11-14 18:51:47', 3, '1-75007614', 15),
('2021-11-15 18:51:47', '2021-11-15 18:51:47', 1, '3-75007614', 45),
('2021-11-17 15:32:44', '2021-11-17 15:32:44', 4, '2-7501557140308,1-75007614', 175),
('2021-11-19 10:45:46', '2021-11-19 10:45:46', 1, '4-75007614,5-7501557140308', 460);

/* PROCEDIMIENTOS ALMACENADOS */

/* ESTADOS */
DELIMITER $$
CREATE PROCEDURE ObtenerEstados()
BEGIN
SELECT * 
FROM estados;
END $$


/* PERMISOS */
DELIMITER $$
CREATE PROCEDURE ObtenerPermisos()
BEGIN
SELECT *
FROM permisos;
END $$

/* USUARIOS */
DELIMITER $$
CREATE PROCEDURE ObtenerUsuarios()
BEGIN
SELECT *
FROM usuarios;
END

DELIMITER $$
CREATE PROCEDURE BuscarUsuario(IN usuario varchar(200))
BEGIN
SELECT *
FROM usuarios
WHERE nomUsuario LIKE CONCAT(usuario,'%');
END

DELIMITER $$
CREATE PROCEDURE InsertarUsuario(IN nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
INSERT INTO usuarios (nomUsuario, usuario, contrasena, idPermiso, idEstado)
VALUES (nomUsuario, usuario, contrasena, idPermiso, idEstado);
END

DELIMITER $$
CREATE PROCEDURE ActualizarUsuario(IN id int, nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
UPDATE usuarios 
SET nomUsuario=nomUsuario, usuario=usuario, contrasena=contrasena, idPermiso=idPermiso, idEstado=idEstado
WHERE idUsuario=id;
END

/* PROVEEDORES */
DELIMITER $$
CREATE PROCEDURE ObtenerProveedores()
BEGIN
SELECT *
FROM proveedores;
END

DELIMITER $$
CREATE PROCEDURE BuscarProveedor(IN proveedor varchar(100))
BEGIN
SELECT *
FROM proveedores
WHERE nomProveedor LIKE CONCAT(proveedor,'%');
END

DELIMITER $$
CREATE PROCEDURE InsertarProveedor(IN nomProveedor varchar(100), numContacto double, direccion varchar(200), email varchar(80))
BEGIN
INSERT INTO proveedores (nomProveedor, numContacto, direccion, email)
VALUES (nomProveedor, numContacto, direccion, email);
END

DELIMITER $$
CREATE PROCEDURE ActualizarProveedor(IN id int, nomProveedor varchar(100), numContacto double, direccion varchar(200), email varchar(80))
BEGIN
UPDATE proveedores 
SET nomProveedor=nomProveedor, numContacto=numContacto, direccion=direccion, email=email
WHERE idProveedor=id;
END

/* PRODUCTOS */
DELIMITER $$
CREATE PROCEDURE ObtenerProductos()
BEGIN
SELECT prod.*, prov.nomProveedor
FROM productos prod
INNER JOIN proveedores prov ON prod.idProveedor=prov.idProveedor;
END

DELIMITER $$
CREATE PROCEDURE InsertarProducto(IN idProducto int, nomProducto varchar(200), stock int, precio double, descripcion text, idProveedor int)
BEGIN
INSERT INTO productos (idProducto, nomProducto, stock, precio, descripcion, idProveedor)
VALUES (idProducto, nomProducto, stock, precio, descripcion, idProveedor);
END

DELIMITER $$
CREATE PROCEDURE ActualizarProducto(IN id int, nomProducto varchar(200), stock int, precio double, descripcion text, idProveedor int)
BEGIN
UPDATE productos 
SET nomProducto=nomProducto, stock=stock, precio=precio, descripcion=descripcion, idProveedor=idProveedor
WHERE idProducto=id;
END

DELIMITER $$
CREATE PROCEDURE BuscarProducto(IN producto varchar(200))
BEGIN
SELECT prod.*, prov.nomProveedor
FROM productos prod
INNER JOIN proveedores prov ON prod.idProveedor=prov.idProveedor
WHERE idProducto LIKE CONCAT(producto,'%') OR nomProducto LIKE CONCAT(producto, '%');
END

DELIMITER $$
CREATE PROCEDURE BuscarProductoVenta(IN codigo varchar(200))
BEGIN
SELECT idProducto, nomProducto, stock, precio, descripcion
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END

DELIMITER $$
CREATE PROCEDURE ObtenerNombreProducto(IN codigo varchar(200))
BEGIN
SELECT idProducto, nomProducto, descripcion
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END

/* VENTAS */
DELIMITER $$
CREATE PROCEDURE InsertarVenta(IN idVenta varchar(20), fechaVenta datetime, idUsuario int, idProductos mediumtext, total double)
BEGIN
INSERT INTO ventas(idVenta, fechaVenta, idUsuario, idProductos, total)
VALUES (idVenta, fechaVenta, idUsuario, idProductos, total);
END

DELIMITER $$
CREATE PROCEDURE ActualizarStock(IN codigo varchar(100), cantidad int)
BEGIN
UPDATE productos
SET stock=stock-cantidad
WHERE idProducto=codigo;
END

/* REPORTES */
DELIMITER $$
CREATE PROCEDURE ObtenerVentas(IN fechaInicial varchar(20), fechaFinal varchar(20))
BEGIN
SELECT ventas.*, usuarios.nomUsuario 
FROM ventas 
INNER JOIN usuarios ON ventas.idUsuario=usuarios.idUsuario
WHERE idVenta BETWEEN (fechaInicial) AND (fechaFinal);
END



/* PROCEDIMIENTO ALMACENADO LOGIN */
DELIMITER $$
CREATE PROCEDURE LoginUsuario(IN user varchar(50), pass varchar(10))
BEGIN
SELECT *
FROM usuarios
WHERE usuarios.usuario=user AND usuarios.contrasena=pass;
END