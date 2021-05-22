create Database sample
Go
use [sample]
Go
create table tblperson
(
id int NOT NUll Primary Key,
name varchar(20) NOT NULL,
email varchar(20)  NOT NULL,
genderid int 
);
create table tblgender
(
id int NOT NULL Primary Key,
gender varchar(20) NOT NULL
);
[Creating Foreign key]
Alter table tblperson Add Constraint FK_tblperson_genderid
Foreign Key(genderid) references tblgender(id)
[Inserting Values]
insert into tblgender values(1,'male');
insert into tblgender values(2,'female');
insert into tblgender values(3,'unknown');
insert into tblperson values(1,'a','a@.com',1);
insert into tblperson values(2,'b','b@.com',2);
insert into tblperson values(3,'c','c@.com',2);
insert into tblperson values(4,'d','d@.com',3);
insert into tblperson values(5,'e','e@.com',1);
insert into tblperson values(6,'f','f@.com',3);
[Displaying tables]
select * from tblperson;
select * from tblgender;
[Default Constraint]
Alter table tblperson Add Constraint Df_genderid_tblperson 
Default 3 for genderid
insert into tblperson(id,name,email) values(7,'g','g@.com');
[Check Constraint]
Alter Table tblperson
Add Constraint ck_age_tblperson
CHECK(age>0 AND age<150);
insert into tblperson values(8,'h','h@.com',2,-89);
[Identity Column]
create table identitytable
(
id int Identity(1,1) Primary Key Not NULL,
name varchar(20) NOT NULL
);
select * from identitytable;
insert into identitytable values('a');
insert into identitytable values('b');
Set Identity_Insert identitytable OFF;
insert into identitytable values('c');
Delete from identitytable;
DBCC CHECKIDENT(identitytable,reseed,0);
select SCOPE_IDENTITY();
select @@IDENTITY;
[Unique key Constraint]
Alter table tblperson
Add Constraint uk_tblperson_email
Unique(email);
insert into tblperson values(8,'h','g@.com',2,null);

