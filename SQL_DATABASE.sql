create database tura;

use tura;

create table turazo(
id int primary key identity(1, 1),
vezeteknev varchar (30),
keresztnev varchar (30),
varos varchar (50),
telefon varchar(11));

create table utvonal(
id int primary key identity(1, 1),
turazoId int foreign key references turazo(id),
honnan varchar(50),
hova varchar(50),
km int);

insert into turazo (vezeteknev, keresztnev, varos, telefon) values
('József','Karcsi','Velence','06705558458'),
('Bakker','Imre','Budapest','06705043333'),
('Alaf','Mukker','Sopron','06205546677'),
('Bandas','Mand','Sopron','06708889999'),
('Tompa','Mihaly','Debrecen','06303506070');

insert into utvonal (turazoid, honnan, hova, km) values
('1', 'Velence', 'Budapest', '200'),
('2', 'Budapest', 'Sopron', '210'),
('3', 'Sopron', 'Velence', '60'),
('4', 'Sopron', 'Velence', '60'),
('5', 'Debrecen', 'Sopron', '350');



/*Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=tura;

Integrated Security=True;
Connect Timeout=30;
Encrypt=False;
TrustServerCertificate=False;
ApplicationIntent=ReadWrite;
MultiSubnetFailover=False/*/
