create database QLSinhVien
go

use QLSinhVien
go

create table SinhVien (
	id INT primary key,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	email VARCHAR(50),
	gender VARCHAR(50),
	ip_address VARCHAR(20)
);

insert into SinhVien(id, first_name, last_name, email, gender, ip_address) values (1, 'Courtnay', 'De Pero', 'cdepero0@kickstarter.com', 'Male', '246.128.9.210');
insert into SinhVien (id, first_name, last_name, email, gender, ip_address) values (2, 'Rainer', 'Phlippsen', 'rphlippsen1@mlb.com', 'Male', '85.136.1.140');
insert into SinhVien (id, first_name, last_name, email, gender, ip_address) values (3, 'Connie', 'Evert', 'cevert2@domainmarket.com', 'Male', '20.206.212.185');
insert into SinhVien (id, first_name, last_name, email, gender, ip_address) values (4, 'Doti', 'Skelhorn', 'dskelhorn3@noaa.gov', 'Female', '77.151.102.3');
insert into SinhVien (id, first_name, last_name, email, gender, ip_address) values (5, 'Kriste', 'Gendricke', 'kgendricke4@wp.com', 'Female', '138.58.51.21');