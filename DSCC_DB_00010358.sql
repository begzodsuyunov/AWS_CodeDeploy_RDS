create database dscccw
go
use dscccw

go

create table Teacher ( 
	TeacherID int not null,
	TeacherName varchar (100) NOT NULL,
	Phone varchar(100) not null,
	
	constraint pk_TeacherID primary key (TeacherID)
)
go
create table Course (
	CourseId int NOT NULl,
	CourseName varchar(100) NOT NULL,
	TeacherID int not null,
	constraint pk_course_id primary key (CourseId),

	constraint fk_course_teacher
	foreign key (TeacherID) references Teacher(TeacherID)

)
go
create table Student (
	StudentID int NOT null IDENTITY,
	FirstName varchar (25) NOT NULL,
	LastName varchar (25) not null,
	Email varchar (50) not null,
	Age int not null,
	Phone varchar (100) not null,
	CourseId int not null,

	constraint pk_student_id primary key (StudentID),
	
	constraint fk_course_student
	foreign key (CourseId) references Course(CourseId)

)
go




insert into Teacher(TeacherID, TeacherName, Phone) values (1, 'Khurshid', '+9987333777, +9888668888')
go
insert into Teacher(TeacherID, TeacherName, Phone) values (2, 'Alisher',  '+9987733777, +9888558888')
go
insert into Teacher(TeacherID, TeacherName, Phone) values (3, 'Saida', '+9987733777, +9888668888')
go



insert into Course (CourseId, CourseName, TeacherID) values (30, 'English', 1)  
go										
insert into Course (CourseId, CourseName, TeacherID) values (50, 'Math', 2) 
go										
insert into Course (CourseId, CourseName, TeacherID) values (40, 'Physics', 3)  

go

go
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ('Ali', 'Nosirov', 'ali@gmail.com', 22, '+998991234567', 40)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Anvar', 'Suyunov', 'anvar@gmail.com', 23, '+998991234567', 50)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Alisher', 'Ahmadov', 'alisher@gmail.com', 16, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Anna', 'Brown', 'anna@gmail.com', 22, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Akmal', 'Karimov', 'akkarimov@gmail.com', 21, '+998991234567', 40)
go
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ('Akram', 'Nosirov', 'aknosirov@gmail.com', 22, '+998991234567', 40)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Ansar', 'Suyunov', 'ansuyunov@gmail.com', 23, '+998991234567', 50)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Azamat', 'Yusupov', 'azyusupov@gmail.com', 16, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Aziz', 'Abdullayev', 'azizab@gmail.com', 22, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Bahadur', 'Ibragimov', 'bahibragimov@gmail.com', 21, '+998991234567', 40)
go
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ('Bilol', 'Rakhimov', 'bilrak@gmail.com', 22, '+998991234567', 40)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Farhod', 'Karimov', 'farkarimov@gmail.com', 23, '+998991234567', 50)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Farrukh', 'Umarov', 'farumarov@gmail.com', 16, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Gabriel', 'Brown', 'gabbrown@gmail.com', 22, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Ibroxim', 'Usmanov', 'ibusmanov@gmail.com', 21, '+998991234567', 40)
go
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ('Izzat', 'Sultanov', 'izzatsul@gmail.com', 22, '+998991234567', 40)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Jafar', 'Sharipov', 'jafsharipov@gmail.com', 23, '+998991234567', 50)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Jaloliddin', 'Yuldashyev', 'jalyuul@gmail.com', 16, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'James', 'Brown', 'jambrown@gmail.com', 22, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Jamshid', 'Tursunov', 'jamtursunov@gmail.com', 21, '+998991234567', 40)
go
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ('Jasur', 'Nosirov', 'jasnosirov@gmail.com', 22, '+998991234567', 40)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Makhmud', 'Suyunov', 'maksuyunov@gmail.com', 23, '+998991234567', 50)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Mansur', 'Ismailov', 'manismailov@gmail.com', 16, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Mohsin', 'Saidov', 'mohsaidov@gmail.com', 22, '+998991234567', 30)
go														
insert into Student (FirstName,LastName,Email, Age, Phone, CourseId) values ( 'Muzaffar', 'Azimov', 'muazimov@gmail.com', 21, '+998991234567', 40)
go
