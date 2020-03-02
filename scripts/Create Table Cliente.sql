create table Cliente(
Id			integer			identity(1,1),
Nome		varchar(100)	not null,
Email		varchar(64)		not null unique,
primary key(Id))