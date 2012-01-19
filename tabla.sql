CREATE TABLE  `aurora`.`tecnico` (
`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`usuario` VARCHAR( 45 ) NOT NULL ,
`password` VARCHAR( 45 ) NOT NULL ,
`telefono` VARCHAR( 12 ) NOT NULL ,
`correo` VARCHAR( 100 ) NOT NULL ,
UNIQUE (
`usuario`
)
