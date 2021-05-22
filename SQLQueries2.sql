[Select]
select * from tblperson;
select Distinct genderid from tblperson;
select [name] from tblperson where genderid=3; 
select [name] from tblperson where genderid<>3; 
select * from tblperson where age IN(14,24,20);
select * from tblperson where age Between 10 AND 20;
select * from tblperson where email like 'a%';
select * from tblperson where email like '%@%';
select * from tblperson where email like '_@%';
select * from tblperson where name like '[def]%';
select * from tblperson order by name DESC;
select top 2* from tblperson;

[Group by]
select SUM(age) from tblperson;
select MAX(age) from tblperson;
select MIN(age) from tblperson;
select genderid,sum(age) as agesum 
from tblperson group by genderid ;
select genderid,sum(age) as agesum,count(*) as total
from tblperson group by genderid ;
select email,genderid,sum(age) as agesum,count(*) as total
from tblperson group by genderid,email Having email Like '[abc]%';

create table table1
(
id int primary key not null,
name varchar(20) NOT NUll,
gender varchar(20) NOT NULL,
salary varchar(20) NOT NULL,
departmentid int Constraint FK_departmentid_table1 Foreign key(departmentid) references table2(id)
);
create table table2
(
id int primary key not null,
departmentname varchar(20) not null,
[location] varchar(20) not null,
departmenthead varchar(10) not null
);

insert into table1 values(1,'tom','male','10000',1);
insert into table1 values(2,'ravi','male','4000',3);
insert into table1 values(3,'ricky','female','2000',2);
insert into table1 values(4,'cena','male','7000',1);
insert into table1 values(5,'brock','female','8000',2);
insert into table1 values(6,'big','male','3000',2);
insert into table1 values(7,'john','male','8000',3);
insert into table1 values(8,'jimmy','female','9000',1);
insert into table1 values(9,'tena','female','1000',2);
insert into table1 values(10,'mena','female','1900',null);
insert into table2 values(1,'it','london','rick');
insert into table2 values(2,'payroll','delhi','chastle');
insert into table2 values(3,'hr','newyork','rimmy');
insert into table2 values(4,'otherdepartment','sydney','centrss');
select * from table1;
select * from table2;

[joins]
select name,gender,salary,departmentname from table1 inner JOin table2 on table1.departmentid=table2.id;
select name,gender,salary,departmentname from table1 left JOin table2 on table1.departmentid=table2.id;
select name,gender,salary,departmentname from table1 right JOin table2 on table1.departmentid=table2.id;
select name,gender,salary,departmentname from table1 full JOin table2 on table1.departmentid=table2.id;
select name,gender,salary,departmentname from table1 cross JOin table2;
