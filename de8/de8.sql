create database QLcafe
use QLcafe

create table Dathang
(
MaDH nvarchar(10),
SoBan nvarchar(20),
DoUong nvarchar(50),
soluong int,
gia int,
ngay date
)

insert into Dathang values ('001',N'Bàn 1', N'Nước ép cam', 2, 30000,'01-08-2023')
insert into Dathang values ('002',N'Bàn 3', N'cafe', 4, 50000,'12-05-2023')
insert into Dathang values ('003',N'Bàn 2', N'Sữa chua đánh đá', 1, 25000,'02-12-2023')
insert into Dathang values ('002',N'Bàn 4', N'cafe', 2, 50000,'12-05-2023')

select * from Dathang where DoUong like N'Nước ép cam'

select * from Dathang where ngay between '12-05-2023' and '12-12-2023'and DoUong like N'cafe'