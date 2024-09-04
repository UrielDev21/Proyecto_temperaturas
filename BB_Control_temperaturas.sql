create table usuarios
(
    id_usuario int primary key AUTO_INCREMENT, 
    nombre varchar(255), 
    apellido varchar(255),
    nivel int, 
    nickname varchar(255), 
    pass varchar(255)
); 

alter table usuarios 
modify nivel varchar(255); 

create table sensores
(
    id_sensor int primary key AUTO_INCREMENT, 
    num_sensor int, 
    temperatura decimal(5, 2), 
    fecha_hora timestamp default current_timestamp,
    estado boolean
); 


describe usuarios; 
describe sensores; 

--Procedimiento almacenado para validar el login --

DROP procedure if exists p_validar; 
create procedure p_validar
(
	in _nickname varchar(255),
	in _pass varchar(255)
)
begin 

	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE nickname = _nickname AND pass = _pass INTO x;
	if X > 0 then
		SELECT 'Correcto' AS rs, (SELECT nivel FROM usuarios WHERE nickname = _nickname) AS nivel;
	ELSE
		SELECT 'Error' AS rs, 0 AS nivel;
	END if;
END;


--Procedimiento almacenado para ingresar usuarios --

drop procedure if exists p_insertar_usuarios; 
create procedure p_insertar_usuarios
(
    in _nombre varchar(255), 
    in _apellido varchar(255),
    in _nivel varchar(255),
    in _nickname varchar(255), 
    in _pass varchar(255)
)
begin 
    insert into usuarios (nombre, apellido, nivel,  nickname, pass) values 
    (_nombre, _apellido, _nivel, _nickname, _pass); 
end; 

-- Procedimiento almacenado para modificar usuarios --

create procedure p_modificar_usuarios
(
    in _id_usuario int, 
    in _nombre varchar(255), 
    in _apellido varchar(255), 
    in _nivel varchar(255), 
    in _nickname varchar(255), 
    in _pass varchar(255)
)
begin 
    update usuarios set id_usuario = _id_usuario, nombre = _nombre, apellido = _apellido, nivel = _nivel, nickname = _nickname, pass = _pass
    where id_usuario = _id_usuario; 
end; 

create procedure p_eliminar_usuarios
(
    in _id_usuario int
)
begin 
    delete from usuarios
    where id_usuario = _id_usuario; 
end; 


describe usuarios; 

call p_insertar_usuarios('Juan', 'Perez', '2', 'juanillo13', sha1('1234')); 
call p_insertar_usuarios('Pedro', 'Hernandez', '1', 'pedrillo18', sha1('1234')); 
call p_eliminar_usuarios(3); 

call p_validar('juanillo12', sha1('1234')); 

select * from usuarios; 

-- Vista para usuarios --
create view v_usuarios as 
select id_usuario, nombre, apellido, nivel, nickname from usuarios; 

select * from v_usuarios where nombre like '%Juan%'; mu