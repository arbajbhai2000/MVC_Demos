create database B22MVCAuthenticationDB
go
use B22MVCAuthenticationDB
go
create table Users
(
UserId int primary key identity,
Email varchar(500),
Password varchar(30),
IsActive bit,
CreatedDate datetime2
)
go
create table Roles
(
RoleId int primary key identity,
RoleName varchar(50)
)
go
create table UserRoles
(
UsersRoleId int primary key identity,
UserId int foreign key references Users(UserId),
RoleId int foreign key references Roles(RoleId)
)
go
insert into Roles values ('Admin'), ('Seller'), ('User')
go
select * from Roles
select * from Users 
select * from UserRoles
go
create table Product
(
ProductId int primary key identity,
Name varchar(500),
Price int,
AddedDate datetime2
)