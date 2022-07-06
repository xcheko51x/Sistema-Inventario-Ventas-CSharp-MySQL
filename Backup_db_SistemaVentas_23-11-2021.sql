-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-11-2021 a las 17:30:25
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistemaventas`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarProducto` (IN `id` INT, `nomProducto` VARCHAR(200), `stock` INT, `precio` DOUBLE, `descripcion` TEXT, `idProveedor` INT)  BEGIN
UPDATE productos 
SET nomProducto=nomProducto, stock=stock, precio=precio, descripcion=descripcion, idProveedor=idProveedor
WHERE idProducto=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarProveedor` (IN `id` INT, `nomProveedor` VARCHAR(100), `numContacto` DOUBLE, `direccion` VARCHAR(200), `email` VARCHAR(80))  BEGIN
UPDATE proveedores 
SET nomProveedor=nomProveedor, numContacto=numContacto, direccion=direccion, email=email
WHERE idProveedor=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarStock` (IN `codigo` VARCHAR(100), `cantidad` INT)  BEGIN
UPDATE productos
SET stock=stock-cantidad
WHERE idProducto=codigo;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarUsuario` (IN `id` INT, `nomUsuario` VARCHAR(200), `usuario` VARCHAR(50), `contrasena` VARCHAR(10), `idPermiso` INT, `idEstado` INT)  BEGIN
UPDATE usuarios 
SET nomUsuario=nomUsuario, usuario=usuario, contrasena=contrasena, idPermiso=idPermiso, idEstado=idEstado
WHERE idUsuario=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarProducto` (IN `producto` VARCHAR(200))  BEGIN
SELECT prod.*, prov.nomProveedor
FROM productos prod
INNER JOIN proveedores prov ON prod.idProveedor=prov.idProveedor
WHERE idProducto LIKE CONCAT(producto,'%') OR nomProducto LIKE CONCAT(producto, '%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarProductoVenta` (IN `codigo` VARCHAR(200))  BEGIN
SELECT idProducto, nomProducto, stock, precio, descripcion
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarProveedor` (IN `proveedor` VARCHAR(100))  BEGIN
SELECT *
FROM proveedores
WHERE nomProveedor LIKE CONCAT(proveedor,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarUsuario` (IN `usuario` VARCHAR(200))  BEGIN
SELECT *
FROM usuarios
WHERE nomUsuario LIKE CONCAT(usuario,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarProducto` (IN `idProducto` INT, IN `nomProducto` VARCHAR(200), IN `stock` INT, IN `precio` DOUBLE, IN `descripcion` TEXT, IN `idProveedor` INT)  BEGIN
INSERT INTO productos (idProducto, nomProducto, stock, precio, descripcion, idProveedor)
VALUES (idProducto, nomProducto, stock, precio, descripcion, idProveedor);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarProveedor` (IN `nomProveedor` VARCHAR(100), `numContacto` DOUBLE, `direccion` VARCHAR(200), `email` VARCHAR(80))  BEGIN
INSERT INTO proveedores (nomProveedor, numContacto, direccion, email)
VALUES (nomProveedor, numContacto, direccion, email);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarUsuario` (IN `nomUsuario` VARCHAR(200), `usuario` VARCHAR(50), `contrasena` VARCHAR(10), `idPermiso` INT, `idEstado` INT)  BEGIN
INSERT INTO usuarios (nomUsuario, usuario, contrasena, idPermiso, idEstado)
VALUES (nomUsuario, usuario, contrasena, idPermiso, idEstado);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarVenta` (IN `idVenta` VARCHAR(20), `fechaVenta` DATETIME, `idUsuario` INT, `idProductos` MEDIUMTEXT, `total` DOUBLE)  BEGIN
INSERT INTO ventas(idVenta, fechaVenta, idUsuario, idProductos, total)
VALUES (idVenta, fechaVenta, idUsuario, idProductos, total);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LoginUsuario` (IN `user` VARCHAR(50), `pass` VARCHAR(10))  BEGIN
SELECT *
FROM usuarios
WHERE usuarios.usuario=user AND usuarios.contrasena=pass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerEstados` ()  BEGIN
SELECT * 
FROM estados;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerNombreProducto` (IN `codigo` VARCHAR(200))  BEGIN
SELECT nomProducto
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPermisos` ()  BEGIN
SELECT *
FROM permisos;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProductos` ()  BEGIN
SELECT prod.*, prov.nomProveedor
FROM productos prod
INNER JOIN proveedores prov ON prod.idProveedor=prov.idProveedor;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProveedores` ()  BEGIN
SELECT *
FROM proveedores;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerUsuarios` ()  BEGIN
SELECT *
FROM usuarios;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerVentas` (IN `fechaInicial` DATETIME, IN `fechaFinal` DATETIME)  BEGIN
SELECT ventas.*, usuarios.nomUsuario 
FROM ventas 
INNER JOIN usuarios ON ventas.idUsuario=usuarios.idUsuario
WHERE idVenta BETWEEN (fechaInicial) AND (fechaFinal);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados`
--

CREATE TABLE `estados` (
  `idEstado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  `descripcion` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estados`
--

INSERT INTO `estados` (`idEstado`, `estado`, `descripcion`) VALUES
(1, 0, 'Inactivo'),
(2, 1, 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permisos`
--

CREATE TABLE `permisos` (
  `idPermiso` int(11) NOT NULL,
  `permiso` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `permisos`
--

INSERT INTO `permisos` (`idPermiso`, `permiso`) VALUES
(1, 'Administrador'),
(2, 'Almacenista'),
(3, 'Vendedor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `idProducto` varchar(100) NOT NULL,
  `nomProducto` varchar(200) NOT NULL,
  `stock` int(11) DEFAULT NULL,
  `precio` double NOT NULL,
  `descripcion` text DEFAULT NULL,
  `idProveedor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idProducto`, `nomProducto`, `stock`, `precio`, `descripcion`, `idProveedor`) VALUES
('54353636', 'Sabritas Adobadas', 20, 14, 'Sabritas 40g sabor adobadas', 2),
('75007614', 'Coca Cola', 40, 15, 'Refresco 600ml Coca Cola Normal', 1),
('7501557140308', 'ketorolaco', 1, 80, 'ketorolaco 10mg 10 tabletas', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `idProveedor` int(11) NOT NULL,
  `nomProveedor` varchar(100) NOT NULL,
  `numContacto` double NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `email` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`idProveedor`, `nomProveedor`, `numContacto`, `direccion`, `email`) VALUES
(1, 'FEMSA', 432424242, 'Calle: Juan Num:1 Col: Centro', 'ventas1@femsa.com'),
(2, 'Sabritas', 4234456, 'Calle: Ana Num:100 Col: Centro', 'ventas5@sabritas.com'),
(3, 'Surtidor Farmacia', 34567876876, 'Calle: Obrera Num. 40 Col. Obrera', 'surfarmaciaventas@surfarmacia.com'),
(4, 'Proveedor Dulces', 43254365467567, 'Calle: Juan Gutierrez #10 Col. Sur', 'dulceria@dulceria.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL,
  `nomUsuario` varchar(200) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(10) NOT NULL,
  `idPermiso` int(11) NOT NULL,
  `idEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`idUsuario`, `nomUsuario`, `usuario`, `contrasena`, `idPermiso`, `idEstado`) VALUES
(1, 'admin', 'admin', 'admin', 1, 2),
(2, 'almacen', 'almacen', 'almacen', 2, 2),
(3, 'ventas', 'ventas', 'ventas', 3, 2),
(4, 'Laura Lopez Martinez', 'lauralm', 'lauralm', 3, 1),
(5, 'Luis Alvarez Morales', 'luisam', 'luisam', 3, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `idVenta` datetime NOT NULL,
  `fechaVenta` datetime DEFAULT NULL,
  `idUsuario` int(11) DEFAULT NULL,
  `idProductos` mediumtext DEFAULT NULL,
  `total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idVenta`, `fechaVenta`, `idUsuario`, `idProductos`, `total`) VALUES
('2021-11-13 18:51:47', '2021-11-13 18:51:47', 3, '1-75007614', 15),
('2021-11-14 18:51:47', '2021-11-14 18:51:47', 3, '1-75007614', 15),
('2021-11-15 18:51:47', '2021-11-15 18:51:47', 1, '3-75007614', 45),
('2021-11-17 15:32:44', '2021-11-17 15:32:44', 4, '2-7501557140308,1-75007614', 175),
('2021-11-19 10:45:46', '2021-11-19 10:45:46', 1, '4-75007614,5-7501557140308', 460);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`idEstado`);

--
-- Indices de la tabla `permisos`
--
ALTER TABLE `permisos`
  ADD PRIMARY KEY (`idPermiso`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`idProducto`),
  ADD KEY `fk_producto_proveedor` (`idProveedor`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`idProveedor`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUsuario`),
  ADD KEY `fk__usuario_permiso` (`idPermiso`),
  ADD KEY `fk__usuario_estado` (`idEstado`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`idVenta`),
  ADD KEY `fk__venta_usuario` (`idUsuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `estados`
--
ALTER TABLE `estados`
  MODIFY `idEstado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `permisos`
--
ALTER TABLE `permisos`
  MODIFY `idPermiso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `idProveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_producto_proveedor` FOREIGN KEY (`idProveedor`) REFERENCES `proveedores` (`idProveedor`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `fk__usuario_estado` FOREIGN KEY (`idEstado`) REFERENCES `estados` (`idEstado`),
  ADD CONSTRAINT `fk__usuario_permiso` FOREIGN KEY (`idPermiso`) REFERENCES `permisos` (`idPermiso`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `fk__venta_usuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
