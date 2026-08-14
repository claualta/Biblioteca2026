-- ============================================================
-- BASE DE DATOS: Biblioteca
-- Materia: VB.NET + MariaDB - Programación Orientada a Eventos
-- Propósito: Base completa para el proyecto didáctico del curso.
--
-- Incluye:
--   * Editoriales
--   * Autores
--   * Temas
--   * Libros
--   * Relaciones Libro-Autor y Libro-Tema
--   * Ejemplares físicos / stock
--   * Portadas almacenadas como BLOB
--   * Roles y usuarios para Login
--   * Datos demo (seed)
--
-- Usuarios demo:
--   ADMIN     -> usuario: admin      contraseña: admin123
--   OPERADOR  -> usuario: operador   contraseña: operador123
--
-- Los hashes fueron generados con el mismo esquema utilizado
-- en el manual:
-- PBKDF2 + SHA256 + 100000 iteraciones + 32 bytes.
-- ============================================================

-- ------------------------------------------------------------
-- 1. CREACIÓN DE LA BASE DE DATOS
-- ------------------------------------------------------------

DROP DATABASE IF EXISTS biblioteca;

CREATE DATABASE biblioteca
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE biblioteca;

-- ------------------------------------------------------------
-- 2. TABLAS PRINCIPALES
-- ------------------------------------------------------------

CREATE TABLE editorial (
    claveeditorial INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    direccion VARCHAR(150),
    telefono VARCHAR(30)
) ENGINE=InnoDB;


CREATE TABLE autor (
    claveautor INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(120) NOT NULL
) ENGINE=InnoDB;


CREATE TABLE tema (
    clavetema INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
) ENGINE=InnoDB;


CREATE TABLE libro (
    clavelibro INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(180) NOT NULL,
    idioma VARCHAR(40),
    formato VARCHAR(40),
    edicion INT,
    claveeditorial INT NOT NULL,

    -- La portada se guardará desde VB.NET como un arreglo de bytes.
    -- Inicialmente los libros demo no contienen imagen.
    portada LONGBLOB NULL,

    CONSTRAINT fk_libro_editorial
        FOREIGN KEY (claveeditorial)
        REFERENCES editorial(claveeditorial)
) ENGINE=InnoDB;


-- Cada fila de ejemplar representa una copia física de un libro.
-- Por lo tanto:
-- STOCK = cantidad de filas de ejemplar asociadas al libro.
CREATE TABLE ejemplar (
    clavelibro INT NOT NULL,
    numeroorden INT NOT NULL,
    ubicacion VARCHAR(80),

    PRIMARY KEY (clavelibro, numeroorden),

    CONSTRAINT fk_ejemplar_libro
        FOREIGN KEY (clavelibro)
        REFERENCES libro(clavelibro)
        ON DELETE CASCADE
) ENGINE=InnoDB;


-- Relación muchos a muchos: un libro puede tener varios autores
-- y un autor puede haber escrito varios libros.
CREATE TABLE escrito_por (
    clavelibro INT NOT NULL,
    claveautor INT NOT NULL,

    PRIMARY KEY (clavelibro, claveautor),

    CONSTRAINT fk_escrito_libro
        FOREIGN KEY (clavelibro)
        REFERENCES libro(clavelibro)
        ON DELETE CASCADE,

    CONSTRAINT fk_escrito_autor
        FOREIGN KEY (claveautor)
        REFERENCES autor(claveautor)
) ENGINE=InnoDB;


-- Relación muchos a muchos: un libro puede tratar varios temas
-- y un tema puede aparecer en varios libros.
CREATE TABLE trata_sobre (
    clavelibro INT NOT NULL,
    clavetema INT NOT NULL,

    PRIMARY KEY (clavelibro, clavetema),

    CONSTRAINT fk_trata_libro
        FOREIGN KEY (clavelibro)
        REFERENCES libro(clavelibro)
        ON DELETE CASCADE,

    CONSTRAINT fk_trata_tema
        FOREIGN KEY (clavetema)
        REFERENCES tema(clavetema)
) ENGINE=InnoDB;


-- ------------------------------------------------------------
-- 3. TABLAS PARA LOGIN Y ROLES
-- ------------------------------------------------------------

CREATE TABLE rol (
    idrol INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL UNIQUE
) ENGINE=InnoDB;


CREATE TABLE usuario (
    idusuario INT AUTO_INCREMENT PRIMARY KEY,
    nombreusuario VARCHAR(50) NOT NULL UNIQUE,

    -- No se guarda la contraseña en texto plano.
    clavehash VARCHAR(100) NOT NULL,
    salt VARCHAR(100) NOT NULL,

    nombrecompleto VARCHAR(100) NOT NULL,
    idrol INT NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,

    CONSTRAINT fk_usuario_rol
        FOREIGN KEY (idrol)
        REFERENCES rol(idrol)
) ENGINE=InnoDB;


-- ============================================================
-- 4. DATOS DEMO - EDITORIALES
-- ============================================================

INSERT INTO editorial (nombre, direccion, telefono) VALUES
('Editorial Horizonte', 'Av. Corrientes 1450 - Buenos Aires', '11-4321-1001'),
('Ediciones del Litoral', 'San Martín 860 - Posadas', '376-442-2100'),
('Editorial Andina', 'Av. Colón 2250 - Córdoba', '351-455-3300'),
('Ediciones del Sur', 'Mitre 420 - Rosario', '341-440-1800'),
('Editorial Universitaria', 'Av. Universidad 700 - La Plata', '221-450-9000');


-- ============================================================
-- 5. DATOS DEMO - AUTORES
-- ============================================================

INSERT INTO autor (nombre) VALUES
('Jorge Luis Borges'),
('Julio Cortázar'),
('Gabriel García Márquez'),
('Miguel de Cervantes'),
('Mary Shelley'),
('Robert Louis Stevenson'),
('Arthur Conan Doyle'),
('Franz Kafka'),
('Antoine de Saint-Exupéry'),
('Edgar Allan Poe');


-- ============================================================
-- 6. DATOS DEMO - TEMAS
-- ============================================================

INSERT INTO tema (nombre) VALUES
('Literatura fantástica'),
('Cuentos'),
('Novela'),
('Aventura'),
('Misterio'),
('Ciencia ficción'),
('Filosofía'),
('Drama'),
('Policial'),
('Literatura clásica');


-- ============================================================
-- 7. DATOS DEMO - 30 LIBROS
-- ============================================================

INSERT INTO libro
    (titulo, idioma, formato, edicion, claveeditorial, portada)
VALUES
('Ficciones', 'Español', 'Tapa blanda', 3, 1, NULL),
('El Aleph', 'Español', 'Tapa blanda', 2, 2, NULL),
('Historia universal de la infamia', 'Español', 'Tapa dura', 1, 5, NULL),

('Rayuela', 'Español', 'Tapa blanda', 5, 3, NULL),
('Bestiario', 'Español', 'Tapa blanda', 2, 1, NULL),
('Final del juego', 'Español', 'Tapa dura', 1, 4, NULL),

('Cien años de soledad', 'Español', 'Tapa blanda', 8, 2, NULL),
('El coronel no tiene quien le escriba', 'Español', 'Tapa blanda', 4, 5, NULL),
('Crónica de una muerte anunciada', 'Español', 'Tapa dura', 3, 1, NULL),

('Don Quijote de la Mancha - Tomo I', 'Español', 'Tapa dura', 6, 3, NULL),
('Don Quijote de la Mancha - Tomo II', 'Español', 'Tapa dura', 6, 3, NULL),
('Novelas ejemplares', 'Español', 'Tapa blanda', 2, 4, NULL),

('Frankenstein', 'Español', 'Tapa blanda', 4, 5, NULL),
('Frankenstein', 'Inglés', 'Tapa dura', 2, 1, NULL),
('El último hombre', 'Español', 'Digital', 1, 2, NULL),

('La isla del tesoro', 'Español', 'Tapa blanda', 3, 4, NULL),
('El extraño caso del Dr. Jekyll y Mr. Hyde', 'Español', 'Tapa dura', 2, 5, NULL),
('Secuestrado', 'Español', 'Tapa blanda', 1, 3, NULL),

('Estudio en escarlata', 'Español', 'Tapa blanda', 4, 1, NULL),
('El sabueso de los Baskerville', 'Español', 'Tapa dura', 3, 2, NULL),
('Las aventuras de Sherlock Holmes', 'Español', 'Tapa blanda', 5, 5, NULL),

('La metamorfosis', 'Español', 'Tapa blanda', 6, 4, NULL),
('El proceso', 'Español', 'Tapa dura', 3, 3, NULL),
('El castillo', 'Español', 'Tapa blanda', 2, 1, NULL),

('El principito', 'Español', 'Tapa blanda', 10, 2, NULL),
('Vuelo nocturno', 'Español', 'Tapa blanda', 2, 4, NULL),
('Tierra de hombres', 'Español', 'Tapa dura', 1, 5, NULL),

('El gato negro y otros relatos', 'Español', 'Tapa blanda', 4, 3, NULL),
('Los crímenes de la calle Morgue', 'Español', 'Tapa blanda', 3, 1, NULL),
('La caída de la Casa Usher', 'Español', 'Tapa dura', 2, 2, NULL);


-- ============================================================
-- 8. RELACIONES LIBRO - AUTOR
-- ============================================================

INSERT INTO escrito_por (clavelibro, claveautor) VALUES
(1,1),(2,1),(3,1),
(4,2),(5,2),(6,2),
(7,3),(8,3),(9,3),
(10,4),(11,4),(12,4),
(13,5),(14,5),(15,5),
(16,6),(17,6),(18,6),
(19,7),(20,7),(21,7),
(22,8),(23,8),(24,8),
(25,9),(26,9),(27,9),
(28,10),(29,10),(30,10);


-- ============================================================
-- 9. RELACIONES LIBRO - TEMA
-- ============================================================

INSERT INTO trata_sobre (clavelibro, clavetema) VALUES
-- Borges
(1,1),(1,2),(1,7),
(2,1),(2,2),(2,7),
(3,2),(3,10),

-- Cortázar
(4,3),(4,1),(4,7),
(5,1),(5,2),
(6,2),(6,8),

-- García Márquez
(7,3),(7,1),(7,8),
(8,3),(8,8),
(9,3),(9,5),(9,8),

-- Cervantes
(10,3),(10,4),(10,10),
(11,3),(11,4),(11,10),
(12,2),(12,10),

-- Mary Shelley
(13,3),(13,6),(13,8),
(14,3),(14,6),
(15,3),(15,6),(15,7),

-- Stevenson
(16,3),(16,4),
(17,3),(17,5),(17,8),
(18,3),(18,4),

-- Conan Doyle
(19,3),(19,5),(19,9),
(20,3),(20,5),(20,9),
(21,2),(21,5),(21,9),

-- Kafka
(22,3),(22,7),(22,8),
(23,3),(23,7),(23,8),
(24,3),(24,7),

-- Saint-Exupéry
(25,3),(25,7),(25,10),
(26,3),(26,4),(26,8),
(27,3),(27,7),

-- Poe
(28,2),(28,5),(28,8),
(29,2),(29,5),(29,9),
(30,2),(30,5),(30,8);


-- ============================================================
-- 10. EJEMPLARES FÍSICOS / STOCK
-- ============================================================
-- Se cargan cantidades diferentes para que el Dashboard,
-- los filtros y los reportes tengan resultados variados.
--
-- Algunos libros tienen stock 0 deliberadamente.
-- Esto permite practicar consultas LEFT JOIN + COUNT.

INSERT INTO ejemplar (clavelibro, numeroorden, ubicacion) VALUES
-- Libro 1: stock 3
(1,1,'Estante A1'), (1,2,'Estante A1'), (1,3,'Depósito D1'),

-- Libro 2: stock 2
(2,1,'Estante A1'), (2,2,'Estante A2'),

-- Libro 3: stock 1
(3,1,'Estante A2'),

-- Libro 4: stock 4
(4,1,'Estante B1'), (4,2,'Estante B1'), (4,3,'Estante B1'), (4,4,'Depósito D1'),

-- Libro 5: stock 2
(5,1,'Estante B2'), (5,2,'Estante B2'),

-- Libro 6: stock 1
(6,1,'Estante B2'),

-- Libro 7: stock 5
(7,1,'Estante C1'), (7,2,'Estante C1'), (7,3,'Estante C1'),
(7,4,'Estante C1'), (7,5,'Depósito D2'),

-- Libro 8: stock 2
(8,1,'Estante C2'), (8,2,'Estante C2'),

-- Libro 9: stock 1
(9,1,'Estante C2'),

-- Libro 10: stock 3
(10,1,'Estante D1'), (10,2,'Estante D1'), (10,3,'Depósito D3'),

-- Libro 11: stock 2
(11,1,'Estante D1'), (11,2,'Estante D2'),

-- Libro 12: stock 1
(12,1,'Estante D2'),

-- Libro 13: stock 4
(13,1,'Estante E1'), (13,2,'Estante E1'),
(13,3,'Estante E1'), (13,4,'Depósito D3'),

-- Libro 14: stock 1
(14,1,'Estante E1'),

-- Libro 15: stock 0 (sin filas)

-- Libro 16: stock 3
(16,1,'Estante F1'), (16,2,'Estante F1'), (16,3,'Estante F2'),

-- Libro 17: stock 2
(17,1,'Estante F2'), (17,2,'Estante F2'),

-- Libro 18: stock 1
(18,1,'Estante F3'),

-- Libro 19: stock 4
(19,1,'Estante G1'), (19,2,'Estante G1'),
(19,3,'Estante G1'), (19,4,'Depósito D4'),

-- Libro 20: stock 3
(20,1,'Estante G2'), (20,2,'Estante G2'), (20,3,'Estante G2'),

-- Libro 21: stock 2
(21,1,'Estante G3'), (21,2,'Estante G3'),

-- Libro 22: stock 2
(22,1,'Estante H1'), (22,2,'Estante H1'),

-- Libro 23: stock 1
(23,1,'Estante H2'),

-- Libro 24: stock 0 (sin filas)

-- Libro 25: stock 5
(25,1,'Estante I1'), (25,2,'Estante I1'), (25,3,'Estante I1'),
(25,4,'Estante I2'), (25,5,'Depósito D5'),

-- Libro 26: stock 2
(26,1,'Estante I2'), (26,2,'Estante I2'),

-- Libro 27: stock 1
(27,1,'Estante I3'),

-- Libro 28: stock 3
(28,1,'Estante J1'), (28,2,'Estante J1'), (28,3,'Estante J1'),

-- Libro 29: stock 2
(29,1,'Estante J2'), (29,2,'Estante J2'),

-- Libro 30: stock 0 (sin filas)
(30,1,'Estante J3');

-- La fila anterior deja al libro 30 con stock 1.
-- Para conservar ejemplos con stock cero, los libros 15 y 24
-- permanecen sin ejemplares.


-- ============================================================
-- 11. ROLES Y USUARIOS DEMO
-- ============================================================

INSERT INTO rol (nombre) VALUES
('ADMIN'),
('OPERADOR');


-- Usuario ADMIN
-- Usuario: admin
-- Contraseña: admin123
INSERT INTO usuario
    (nombreusuario, clavehash, salt, nombrecompleto, idrol, activo)
VALUES
    ('admin',
     'RxvV6GUtSRUe8Ei1PO8QneNVuJ9855Ik6vN7bojhnWk=',
     'LlZHaHCvXUbSKOX2rxBBdA==',
     'Administrador del Sistema',
     1,
     TRUE);


-- Usuario OPERADOR
-- Usuario: operador
-- Contraseña: operador123
INSERT INTO usuario
    (nombreusuario, clavehash, salt, nombrecompleto, idrol, activo)
VALUES
    ('operador',
     'kVWTOlQjOVJ+9Weagu/2i3iakr1U5ZYT2n90/NTonVE=',
     'wjx3dZTT/2he/mdUTP8hxg==',
     'Operador de Biblioteca',
     2,
     TRUE);


-- ============================================================
-- 12. CONSULTAS DE COMPROBACIÓN
-- ============================================================

-- Debe devolver 5.
SELECT COUNT(*) AS cantidad_editoriales
FROM editorial;

-- Debe devolver 10.
SELECT COUNT(*) AS cantidad_autores
FROM autor;

-- Debe devolver 30.
SELECT COUNT(*) AS cantidad_libros
FROM libro;

-- Lista de libros mostrando editorial y stock.
SELECT
    l.clavelibro,
    l.titulo,
    e.nombre AS editorial,
    COUNT(ej.numeroorden) AS stock
FROM libro l
INNER JOIN editorial e
    ON e.claveeditorial = l.claveeditorial
LEFT JOIN ejemplar ej
    ON ej.clavelibro = l.clavelibro
GROUP BY
    l.clavelibro,
    l.titulo,
    e.nombre
ORDER BY l.titulo;


-- Libros sin ejemplares físicos.
SELECT
    l.clavelibro,
    l.titulo
FROM libro l
LEFT JOIN ejemplar ej
    ON ej.clavelibro = l.clavelibro
GROUP BY
    l.clavelibro,
    l.titulo
HAVING COUNT(ej.numeroorden) = 0;


-- Libros con sus autores.
SELECT
    l.titulo,
    GROUP_CONCAT(
        DISTINCT a.nombre
        ORDER BY a.nombre
        SEPARATOR ', '
    ) AS autores
FROM libro l
LEFT JOIN escrito_por ep
    ON ep.clavelibro = l.clavelibro
LEFT JOIN autor a
    ON a.claveautor = ep.claveautor
GROUP BY
    l.clavelibro,
    l.titulo
ORDER BY l.titulo;


-- Libros con sus temas.
SELECT
    l.titulo,
    GROUP_CONCAT(
        DISTINCT t.nombre
        ORDER BY t.nombre
        SEPARATOR ', '
    ) AS temas
FROM libro l
LEFT JOIN trata_sobre ts
    ON ts.clavelibro = l.clavelibro
LEFT JOIN tema t
    ON t.clavetema = ts.clavetema
GROUP BY
    l.clavelibro,
    l.titulo
ORDER BY l.titulo;


-- Usuarios disponibles para probar el Login.
SELECT
    u.idusuario,
    u.nombreusuario,
    u.nombrecompleto,
    r.nombre AS rol,
    u.activo
FROM usuario u
INNER JOIN rol r
    ON r.idrol = u.idrol
ORDER BY u.idusuario;


-- ============================================================
-- FIN DEL SCRIPT
-- ============================================================
