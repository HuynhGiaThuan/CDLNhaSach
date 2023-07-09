Create database QL_NhaSach_THHCDL
go
use QL_NhaSach_THHCDL
go



create table LoaiSach(
MaLoaiSach char(10)primary key,
TenLoaiSach nvarchar(Max),
)
Go

create table TacGia(
MaTacGia char(10)primary key,
TenTacGia nvarchar(max),
NgaySinh date ,
DiaChiTacGia nvarchar(max),
GioiTinh nvarchar(6)
)
GO

create table Sach(
MaSach char(10)primary key,
TenSach nvarchar(MAx),
SoLuong int ,
Anh char(10),
GiaSanPham float,
MaLoaiSach Char(10),
MaTacGia char(10)
)
Go

create table KhachHang (
MaKh char(12)primary key,
TenKh Nvarchar(max),
NgaySinh Date,
DiaChi nvarchar(max)
)
Go

create table NhanVien(
MaNhanVien char(12)primary key,
Pwd char(20),
TenNhanVien nvarchar(max),
NgSinh Date,
DiaChi nvarchar(max),
Luong Float,
NgVaoLam date,
PhuCap float,
SoDienThoai int
)
Go
alter table NhanVien
add SoDienThoai int

create table HoaDon(
MaHoaDon char(12)primary key ,
MaNhanVien char(12),
MaSach char(10),
MaKh char(12),
ThoiGianHoaDon Time ,
NgayBan DAte,
TongTien float,
SoLuong int
)
Go








alter table Sach
Drop column Anh;

 Create table GioHang(
 MaGioHang Char(10)primary key,
 MaSach char(10),
 )
 GO


 ----khoa ngoai
 alter table Sach
 add constraint StoLS
foreign key (MaLoaiSach)
references dbo.LoaiSach


 alter table Sach
 add constraint StoTG
foreign key (MaTacGia)
references dbo.TacGia

 alter table GioHang
 add constraint GHtoS
foreign key (MaSach)
references dbo.Sach

alter table HoaDon
add constraint HDtoS
foreign key (MaSach)
references dbo.Sach


alter table HoaDon
add constraint HDtoKh
foreign key (MaKh)
references dbo.KhachHang


alter table HoaDon
add constraint HDtoNV
foreign key (MaNhanVien)
references dbo.NhanVien


--du lieu
INSERT INTO LoaiSach VALUES('TT',N'TRINH THÁM')
INSERT INTO LoaiSach VALUES('TNHI',N'THIẾU NHI')
INSERT INTO LoaiSach VALUES('SGK',N'SÁCH GIÁO KHOA')
INSERT INTO LoaiSach VALUES('CNTT',N'Công Nghệ Thông Tin')
insert into LoaiSach values('KTe',N'Kinh Tế')
insert into LoaiSach values('TR',N'Truyện')
insert into LoaiSach values('Food',N'Ẩm Thực')
insert into LoaiSach values('B',N'Báo Trí')
select * from LoaiSach


INSERT INTO TacGia VALUES('NTT',N'NGÔ TẤT TÔ','1945-04-20',N'Bắc Ninh',N'Nam')
INSERT INTO TacGia VALUES('XD',N'XUÂN DIỆU','1916-02-02',N'Bình Ðịnh',N'Nam')
INSERT INTO TacGia VALUES('NXBGD',N'NHÀ XUẤT BẢN VÀ GIÁO DỤC','1957-06-01',N'Việt Nam','')
INSERT INTO TacGia VALUES('BT',N'NHÀ XUẤT BẢN BÁO TRÍ VÀ TRUYỀN THÔNG','1957-06-01',N'Việt Nam','')
INSERT INTO TacGia VALUES('XQ',N'XUÂN Quỳnh','1942-01-01',N' tỉnh Hà Tây',N'Nữ')
INSERT INTO TacGia VALUES('XQ',N'XUÂN Quỳnh','1942-01-01',N' tỉnh Hà Tây',N'Nữ')
SELECT *FROM TacGia

Insert into Sach Values('S001',N'Hóa Học 12',12,'25000','SGK','NXBGD')
Insert into Sach Values('S002',N'Hóa Học 11',23,'12000','SGK','NXBGD')
Insert into Sach Values('S003',N'Anh Văn 12',1,'32000','SGK','NXBGD')
Insert into Sach Values('S004',N'Địa Lý',15,'11000','SGK','NXBGD')
Insert into Sach Values('S005',N'Tắt Đèn ',3,'250000','TR','NTT')
Insert into Sach Values('S006',N'Kỹ Thuật Lắp Máy',5,'34000','CNTT','NXBGD')
Insert into Sach Values('S007',N'Những Ông Trùm Tài Chính',14,'72000','KTe','NXBGD')
Insert into Sach Values('S008',N'Nhập Môn Công Nghệ Phân Mềm',19,'98000','CNTT','NXBGD')
Insert into Sach Values('S009',N'Ngữ Văn 8',35,'15000','SGK','NXBGD')
Insert into Sach Values('S010',N'Khám Phá Ẩm Thực',12,'25000','Food','BT')
Insert into Sach Values('S011',N'Cơ Sở Dữ Liệu',11,'37000','CNTT','NXBGD')
Insert into Sach Values('S012',N'Giải Tích 12',10,'12000','SGK','NXBGD')
Insert into Sach Values('S013',N'Vật Lý 11',6,'23000','SGK','NXBGD')
Insert into Sach Values('S014',N'HÌNH ẢNH VÀ SẮC ĐẸP',23,'35000','B','BT')
Insert into Sach Values('S015',N'Sóng',6,'32000','SGK','XQ')
Insert into Sach Values('S016',N'Tơ tằm',23,'21000','SGK','XQ')
select * from sach

select GiaSanPham+100 as"GiaSanPham+100" from sach


 insert into KhachHang values('KH001',N'Châu Văn Tài','1980-08-23',N'Bình Long A')
 insert into KhachHang values('KH002',N'Nguyễn Thị Tuyết ','2002-05-12',N'Mã Lò ')
 insert into KhachHang values('KH003',N'Bùi Văn Hằng','1997-12-01',N'Quận 12')
 insert into KhachHang values('KH004',N'Phan Văn Hoàng','2003-05-12',N'Tân Chánh Hiệp /Q12')
 select * from KhachHang


insert into NhanVien values('001','123',N'Thuận Huỳnh','2002-11-17',N'Đông Thạnh/Hóc Môn','12000000','2021-05-12','850000','0329867771')
insert into NhanVien values('002','anlee',N'An Lê','2002-08-12',N'Cai Lậy /Tiền Giang','9000000','2022-01-23','530000','06316517')
insert into NhanVien values('003','khang123',N'Ngọc Khang','2002-10-16',N'Bà Điểm/Hóc Môn','3000000','2022-11-27','450000','056216963')
insert into NhanVien values('004','123',N'Mai Cường','2002-08-16',N'Đồng Tâm/Tiền Giang','15000000','2021-01-02','520000','0832161472')
insert into NhanVien values('005','minhwon',N'Minh Quân','2002-12-27',N'Mã Lò/Bình Tân','2000000','2022-12-08','120000','012123583')
 select * from NhanVien

 insert into HoaDon values('HD001','001','S001','KH004','18:52','2022-10-11','25000')
 insert into HoaDon values('HD002','001','S014','KH004','09:13','2022-10-12','70000')
 insert into HoaDon values('HD003','002','S013','KH003','15:32','2022-10-12','23000')
  insert into HoaDon values('HD004','002','S013','KH003',Getdate(),Getdate(),'23000')
    insert into HoaDon values('HD005','002','S013','KH003',Getdate(),Getdate(),'23000')
select * from HoaDon
select * from HoaDon  where MaHoaDon like 'HD143208756 '
select Getdate();
select TenNhanVien from NhanVien where MaNhanVien=005

--- Thủ Tục
-- Hàm Check 
 ALTER TABLE DOCGIA
 ADD CONSTRAINT CHECK_AGE CHECK (ChucVu='adminn')
 PRINT N'TU?I L?N 15'



 --thu tuc 
 -- Tên Khách Hàng Xuất Hóa Đơn
 select * from KhachHang
  select * from HoaDon
CREATE PROC TenKHxuatHD @TenKhach nvarCHAR(Max)
AS
BEGIN
	SELECT MaHoaDon,MaSach,ThoiGianHoaDon,NgayBan
	FROM HoaDon,KhachHang
	WHERE KhachHang.MaKh=HoaDon.MaKh AND @TenKhach=KhachHang.TenKh
END
---
EXECUTE TenKHxuatHD N'Châu Văn Tài'
-- Xuất ra Các Phẩm mà nhân viên đó đã bán


CREATE PROC SpNVienDaBan @MaNhanVien CHAR(12)
AS
BEGIN
	SELECT TenSach,MaHoaDon
	FROM HoaDon,NhanVien,Sach
	WHERE NhanVien.MaNhanVien=HoaDon.MaNhanVien and HoaDon.MaSach=Sach.MaSach and @MaNhanVien=NhanVien.MaNhanVien
END
---
EXECUTE SpNVienDaBan '001'


-- tổng Chi tiêu của khách hàng đó


-- tên tác  giả xuất ra thể loại sách
create proc TheLoaiSach @TenTacGia nvarchar(max)
as
begin
	select TenLoaiSach
	from LoaiSach,Sach,TacGia
	where Sach.MaLoaiSach=LoaiSach.MaLoaiSach and Sach.MaTacGia=TacGia.MaTacGia and @TenTacGia=TacGia.TenTacGia
end
execute TheLoaiSach N'XUÂN Quỳnh'

create function DiemTichLy (@TenKh nvarchar(max))
returns FLoat
as
begin

	declare @DIEM Float
	set @DIEM=(
	Select SUm((TongTien/5000))

	from HoaDon,KhachHang
	where KhachHang.MaKH=HoaDon.Makh and TenKh=@TenKh
	) 
	REturn @DIEM
end

declare @DIEMTB Float
set @DIEMTB=(Select DBO.DiemTichLy(N'Phan Văn Hoàng'))
select  @DIEMTB 
Print N'Diem Tích Lỹ la' +Convert (char(50),@DIEMTB)

--dem so luong sach ban ra ngay hom do
select * from NhanVien
select * from HoaDon
select * from Sach
select * from LoaiSach
select * from TacGia
select * from Khachhang

create proc DemSanPhamKhachMua @TenKhachHang nvarChar(MAx),@NgayMua Date
as
begin
	select TenKh, Count(MaHoaDon) AS N'Hóa Đơn Khách Mua Trong Ngày'
	from Sach,HoaDon,KhachHang
	where Sach.MaSach=HoaDon.MaSach and HoaDon.MaKh=KhachHang.MaKh and @TenKhachHang=KhachHang.TenKh and @NgayMua=HoaDon.NgayBan
	Group by TenKh
end


execute DemSanPhamKhachMua N'Nguyễn Thị Tuyết ','2022-12-11'

--ma Hoa Don Xuat Ra ten Khach HAng


--Che Do KPI NhanVien


