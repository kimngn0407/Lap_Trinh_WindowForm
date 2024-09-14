create database QNLYCafe
on
(
	name = 'QNLYCafe_data',
	filename = 'E:\QuanLyQuanCF\QNLYCafe.MDF'
)
log on
(
	name = 'QNLYCafe_log',		
	filename = 'E:\QuanLyQuanCF\QNLYCafe.LDF'
)
use QNLYCafe
create table TableFood
(
	id int identity primary key,
	name nvarchar(100) default N'Bàn chưa có tên',
	status nvarchar(100) default N'Trống'
)
go
create table Account
(
	UserName nvarchar(100) not null primary key,
	DisplayName nvarchar(100) not null default N'Chưa đặt tên',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0,
)
go
create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
)
go
create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0
	foreign key (idCategory) references FoodCategory(id)
)
go
create table Bill
(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date,
	idTable int not null,
	status int not null default 0,
	foreign key (idTable) references TableFood(id)
)
go
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	foreign key (idBill) references Bill(id),
	foreign key (idFood) references Food(id)
)
go

insert into Account values (N'Ngan', N'Nguyen', 123, 1);
insert into Account values (N'Ngoc', N'Tran', 123456789, 0);


select *
from Account

go

create proc USP_GetListAccountByUserName
@username nvarchar(100)
as
begin
	select * from Account where UserName = @username
end
go

exec USP_GetListAccountByUserName @username = N'Ngan'

go
create Proc USP_Login
	@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from Account where UserName = @userName and PassWord = @passWord
end
go

--thêm bàn
declare @i int = 0
while @i <= 10
begin 
	insert into TableFood values (N'Bàn ' + cast(@i as nvarchar(100)), N'Trống');
	set @i = @i + 1
end

go
create proc USP_GetTableList
as select * from TableFood;
go

update TableFood set status = N'Có người' where id = 9

exec USP_GetTableList


-- thêm category
insert into FoodCategory values (N'Hải Sản');
insert into FoodCategory values (N'Nông Sản');
insert into FoodCategory values (N'Lâm Sản');
insert into FoodCategory values (N'Nước uống');
insert into FoodCategory values (N'Giải khát');

-- thêm món ăn
insert into Food values (N'Mực một năng nướng sa tế', 1, 120000);
insert into Food values (N'Nghêu hấp sả', 1, 50000);
insert into Food values (N'Bún bò', 2, 40000);
insert into Food values (N'Gà nướng', 2, 150000);
insert into Food values (N'Heo rừng nướng muối ớt', 3, 200000);
insert into Food values (N'Cơm chiên', 3, 50000);
insert into Food values (N'Sinh tố dâu', 4, 30000);
insert into Food values (N'Nước ép táo', 4, 25000);
insert into Food values (N'CoCa', 5, 15000);
insert into Food values (N'Pepsi', 5, 20000);

--thêm bill
insert into Bill values (GETDATE(), null , 1 , 0);
insert into Bill values (GETDATE(), null , 2 , 0);
insert into Bill values (GETDATE(), GETDATE() , 2 , 1);

--thêm billinfo
insert into BillInfo values (1 , 1 , 2 );
insert into BillInfo values (1 , 3 , 4 );
insert into BillInfo values (1 , 5 , 1 );
insert into BillInfo values (2 , 1 , 2 );
insert into BillInfo values (2 , 6 , 2 );
insert into BillInfo values (3 , 5 , 2 );

select * from FoodCategory
select * from Food
select * from Bill
select * from BillInfo

select * from Bill where idTable = 2 and status = 1


select * from BillInfo where idBill = 2