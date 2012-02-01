CREATE TABLE  `aurora`.`tecnico` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`usuario` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`telefono` VARCHAR( 12 ) NOT NULL ,
`correo` VARCHAR( 100 ) NOT NULL ,
UNIQUE (
`usuario`
));

CREATE TABLE  `aurora`.`localizacion` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`empresa` VARCHAR( 45 ) NOT NULL ,
`contacto` VARCHAR( 45 ) NOT NULL ,
`direccion` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`telefono` VARCHAR( 12 ) NOT NULL ,
`notas` TEXT NOT NULL ,
`correo` VARCHAR( 100 ) NOT NULL);

CREATE TABLE  `aurora`.`equipo` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`nombre` VARCHAR( 45 ) NOT NULL ,
`usuario` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`localizacion` INT NOT NULL);

CREATE TABLE  `aurora`.`hardware` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`nombre` VARCHAR( 45 ) NOT NULL ,
`fecha_instalacion` DATE NOT NULL ,
`notas` TEXT NOT NULL ,
`equipo` INT NOT NULL);
