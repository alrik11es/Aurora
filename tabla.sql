CREATE TABLE IF NOT EXISTS `config_ip` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(25) NOT NULL,
  `equipo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

CREATE TABLE IF NOT EXISTS `config_pass` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `equipo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

CREATE TABLE IF NOT EXISTS `config_varios` (
  `id` int(11) NOT NULL,
  `clave` varchar(255) NOT NULL,
  `valor` text NOT NULL,
  `equipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS  `tecnico` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`usuario` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`telefono` VARCHAR( 12 ) NOT NULL ,
`correo` VARCHAR( 100 ) NOT NULL ,
UNIQUE (
`usuario`
));

CREATE TABLE IF NOT EXISTS  `localizacion` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`empresa` VARCHAR( 45 ) NOT NULL ,
`contacto` VARCHAR( 45 ) NOT NULL ,
`direccion` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`telefono` VARCHAR( 12 ) NOT NULL ,
`notas` TEXT NOT NULL ,
`correo` VARCHAR( 100 ) NOT NULL);

CREATE TABLE IF NOT EXISTS  `equipo` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`nombre` VARCHAR( 45 ) NOT NULL ,
`fecha_instalacion` DATETIME NOT NULL ,
`tipo` INTEGER NOT NULL ,
`so` INTEGER NOT NULL ,
`notas` TEXT NOT NULL ,
`localizacion` INT NOT NULL);

CREATE TABLE IF NOT EXISTS  `hardware` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`nombre` VARCHAR( 45 ) NOT NULL ,
`fecha_instalacion` DATE NOT NULL ,
`notas` TEXT NOT NULL ,
`equipo` INT NOT NULL);
