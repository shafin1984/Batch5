create database StudentDb

USE [StudentDb]
GO
/****** Object:  Table [dbo].[students]    Script Date: 6/11/2019 6:50:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Age] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([ID], [Name], [Age]) VALUES (1, N'A', 20)
INSERT [dbo].[students] ([ID], [Name], [Age]) VALUES (2, N'B', 21)
SET IDENTITY_INSERT [dbo].[students] OFF


select * from students

drop table students

create table students
(
ID INT IDENTITY (1,1),
RollNo INT,
Name varchar (200),
Age INT,
Address varchar (500),
DistrictID INT
)

drop table students

create table district
(
 ID INT IDENTITY (1,1),
 Name varchar (100)
)


create table departments
(
 ID INT IDENTITY (1,1),
 Name varchar (100)
)
create table subjects
(
 ID INT IDENTITY (1,1),
 Name varchar (100),
 Code varchar (100)
)
create table marks
(
 ID INT IDENTITY (1,1),
 studentId INT,
 departmentId INT,
 subjectId INT,
 mark INT
)

drop table marks

insert into departments (Name) values ('ECE')
insert into departments (Name) values ('ICE')
select * from marks
insert into district(Name) values ('Dhaka')
insert into district(Name) values ('Sylhet')

insert into students values (1,'A',20,'Mirpur',1)
insert into students values (2,'B',22,'Banani',2)
insert into students values (3,'C',24,'Gulshan',1)
insert into students values (4,'D',26,'Mirpur',2)
insert into students values (5,'E',28,'Gulshan',1)
insert into students values (6,'F',30,'Mirpur',2)

insert into subjects values ('Database','ICE101')
insert into subjects values ('DotNet','ICE201')

insert into marks values (1,2,1,90)
insert into marks values (1,2,2,91)
insert into marks values (2,1,1,92)
insert into marks values (2,1,2,93)
insert into marks values (3,2,1,94)
insert into marks values (3,2,2,95)

insert into marks values (4,2,1,90)
insert into marks values (4,2,2,91)
insert into marks values (5,1,1,92)
insert into marks values (5,1,2,93)
insert into marks values (6,2,1,94)
insert into marks values (6,2,2,95)

select RollNo, s.Name, Age, Address, DistrictID, d.Name as District from students as s
left outer join district as d on d.ID=s.DistrictID 

select ID, 