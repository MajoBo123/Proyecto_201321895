CREATE DATABASE BD_201321895;
USE BD_201321895;

-- CREAR TABLA GENERO
CREATE TABLE Genero(
	id_genero INT NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	PRIMARY KEY(id_genero)
);


-- CREAR TABLA EDITORIAL
CREATE TABLE Editorial(
	id_editorial INT  NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
    PRIMARY KEY(id_editorial)
);


-- CREAR TABLA USUARIO
CREATE TABLE Usuario(
	id_usuario INT NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	usuario VARCHAR(50) NOT NULL,
	tipo_usr VARCHAR(50) NOT NULL,
	nacimiento DATE NOT NULL,
	contrasenia VARCHAR(50) NOT NULL
	PRIMARY KEY(id_usuario)
);


-- CREAR TABLA LIBRO
CREATE TABLE Libro(
	id_libro INT NOT NULL IDENTITY(1,1),
	id_editorial INT NOT NULL,
	genero INT NOT NULL,
	titulo VARCHAR(50) NOT NULL,
	autor VARCHAR(50) NOT NULL,
	cantidad INT NOT NULL,

	PRIMARY KEY(id_libro),
	CONSTRAINT fk_id_editorial FOREIGN KEY(id_editorial)
		REFERENCES Editorial(id_editorial) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_id_genero FOREIGN KEY(genero)
		REFERENCES Genero(id_genero) ON UPDATE CASCADE ON DELETE CASCADE
);


-- CREAR TABLA PRESTAMO
CREATE TABLE Prestamo(
	id_prestamo INT NOT NULL IDENTITY(1,1),
	id_usuario INT NOT NULL,
	id_libro INT NOT NULL,
	estatus BIT NOT NULL,
	PRIMARY KEY(id_prestamo),
	
	CONSTRAINT fk_id_usuario FOREIGN KEY(id_usuario)
		REFERENCES Usuario(id_usuario) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT fk_id_libro FOREIGN KEY(id_libro)
		REFERENCES Libro(id_libro) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE BITACORA (
	ID_BITACORA INTEGER IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FECHA DATETIME,
	USUARIO VARCHAR(50) NOT NULL,
	DIRECCION_IP VARCHAR(50) NOT NULL,
	ACCION VARCHAR(254)
);

-- INSERTANDO LOS GENEROS DE LIBROS
INSERT INTO Genero(nombre)
VALUES('Aventuras');
INSERT INTO Genero(nombre)
VALUES('Ciencia Ficcion');
INSERT INTO Genero(nombre)
VALUES('Policiaco');
INSERT INTO Genero(nombre)
VALUES('Terror y misterio');
INSERT INTO Genero(nombre)
VALUES('Romantica');
INSERT INTO Genero(nombre)
VALUES('Humor');

-- INSERTANDO EDITORIALES
INSERT INTO Editorial(nombre,direccion)
VALUES('Alianza','Guatema zona 1');
INSERT INTO Editorial(nombre,direccion)
VALUES('Ariel','Guatemala zona 3');
INSERT INTO Editorial(nombre,direccion)
VALUES('Catedra','Guatemala zona 4');
INSERT INTO Editorial(nombre,direccion)
VALUES('Tirant Lo Blanch','Guatemala zona 10');
INSERT INTO Editorial(nombre,direccion)
VALUES('Akal','Guatemala zona 9');

-- INSERTANDO USUARIO
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Maria','Borrayo','user1','1','11-17-1994','1234');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Manuel','Rey','user2','2','06-03-2000','5678');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Angel','Sanchez','user3','2','06-03-2000','qwer');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Maria','Blanco','user4','2','03-09-1999','asdf');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Julia','Polo','user5','2','04-10-1989','zxcv');
INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('Kimberly','Castellanos','user6','2','03-07-2002','yuti');

-- INSERTANDO LIBRO
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(1,1,'Dos años de vacaciones','Julio Verner',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(3,1,'Las aventuras de Tom Sawyer','Mark Twain',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,2,'El señor de los anillos','JRR Tolkien',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,2,'Harry Potter y el caliz de fuego','JK Rowling',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(2,3,'Los crímenes de la calle Morgue','Edgar Allan Poe',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(4,3,'El misterio de Marie Rogêt','Edgar Allan Poe',50);
INSERT INTO Libro(id_editorial,genero,titulo,autor,cantidad)
VALUES(4,6,'El proyecto esposa','Graeme Simsion',50);


-- INSERTANDO PRESTAMO
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,1,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,2,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,3,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,4,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,5,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(2,6,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,3,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,4,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,5,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(4,6,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(3,2,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(3,1,0);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(1,1,1);
INSERT INTO Prestamo(id_usuario,id_libro,estatus)
VALUES(5,4,0);


select * from Usuario;
/*
SELECT ed.nombre, COUNT(li.titulo) AS cantidad
FROM Editorial ed
JOIN Libro Li
ON ed.id_editorial = li.id_editorial
GROUP BY ed.nombre

SELECT li.titulo, COUNT(pr.id_usuario)
FROM Prestamo pr
INNER JOIN Libro li
ON pr.id_libro = li.id_libro
GROUP BY li.titulo




SELECT us.nombre, us.apellido, COUNT(pr.id_prestamo)
FROM Prestamo pr
INNER JOIN Libro li
ON pr.id_libro = li.id_libro
INNER JOIN Usuario us
ON us.id_usuario = pr.id_usuario/*