create database Final_Algoritmos

create table Usuarios (
Users varchar (40) primary key,
Pass varchar (8) )

insert into Usuarios values ('Alex', '123')
insert into Usuarios values ('Administrador', '123')




create table Cursos(
CodCurso varchar (8) constraint PK_Cursos primary key not null,
Nombre varchar (30) not null,
Turno varchar (30) not null,
)

insert into Cursos values ('CU100', 'Lenguaje','Mañana')
insert into Cursos values ('CU101', 'Algebra Lineal', 'Tarde')
insert into Cursos values ('CU102', 'Matematica I','Mañana')
insert into Cursos values ('CU103', 'Matematica II', 'Tarde')
insert into Cursos values ('CU104', 'Calculo Vectorial','Mañana')
insert into Cursos values ('CU105', 'Historia del Arte', 'Tarde')
insert into Cursos values ('CU106', 'Fundamentos de Programacion','Mañana')
insert into Cursos values ('CU107', 'Algoritmos Avanzados', 'Tarde')
insert into Cursos values ('CU110', 'Lenguaje II', 'Tarde')
insert into Cursos values ('CU111', 'Diseño Logico','Mañana')
insert into Cursos values ('CU112', 'Contabilidad', 'Tarde')
insert into Cursos values ('CU113', 'Ofimatica para Ingenieros I', 'Tarde')
insert into Cursos values ('CU114', 'Ofimatica para Ingenieros II', 'Tarde')
insert into Cursos values ('CU108', 'Dibujo Asistido', 'Tarde')
insert into Cursos values ('CU115', 'Desarrollo de Sistemas I', 'Tarde')
insert into Cursos values ('CU116', 'Desarrollo de Sistemas II', 'Tarde')

create table Alumnos (
CodAlumno varchar (8) constraint PK_CodAlumno primary key  not null,
Nombres varchar (25),
Apellidos varchar (40),
CodCurso varchar (8) constraint FK1_CodCurso foreign key references Cursos (CodCurso) not null
 )

insert into Alumnos values ('AL10', 'Richard Augusto','Barrantes Lingan','CU101') 
insert into Alumnos values ('AL15', 'Jose Luis','Lopez Oropeza','CU101') 
insert into Alumnos values ('AL20', 'Americo Lucio','Inga Lopez','CU102') 
insert into Alumnos values ('AL25', 'Amelia Rita','Socrates Panadal','CU102') 
insert into Alumnos values ('AL30', 'Luisa Berta','Gonzales Alva','CU102') 
insert into Alumnos values ('AL35', 'Claudio Pedro','Maritin Luceo','CU102') 
insert into Alumnos values ('AL40', 'Martin','Arizaga Quispe','CU102') 
insert into Alumnos values ('AL45', 'Claudio Gustavo','Reyes Odria','CU102') 
 

select * from Cursos

DELETE FROM Cursos WHERE Nombre='Autocad'

create table Profesores (
CodProfesor varchar (8) constraint PK_CodProfesor not null,
Nombres varchar (25) not null,
Apellidos varchar (25)not null,
Direccion varchar (49)  not null,
Telefono varchar (9) not null,
EMail varchar (49) not null,
CodCurso varchar (8) constraint FK_CodCurso foreign key references Cursos (CodCurso) not null )

insert into Profesores values ('PR11', 'Luis Carlos','Avalos Polo','Av. Mirones 123 - San Miguel','989765182','Thechix@live.com','CU100') 
insert into Profesores values ('PR15', 'Alonso Richard','Huamachano Bazan','Av. San Luis 321 - San Luis','909619232','Fregados@live.com','CU101') 
insert into Profesores values ('PR17', 'Paolo Luis','Guerrero Meza','Av. La Mar 323 - San Martin de Porres','909619321','Friday23@hotmail.com','CU102') 














