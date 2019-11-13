use master;
go

drop database if exists PhoneStoreManage;
go

create database PhoneStoreManage;
go

use PhoneStoreManage;
go

drop table if exists SuaChua;
drop table if exists ChitietHoadon;
drop table if exists HoaDon;
drop table if exists CauHinh;
drop table if exists DienThoai;
drop table if exists MauDienThoai;
drop table if exists HangDienThoai;
drop table if exists NhanVien;
drop table if exists HopDong;
drop table if exists KhachHang;
drop table if exists ChucVu;
drop table if exists Account;
go

create table ChucVu
(
	MaCV int primary key not null,
	TenCV nvarchar(50),
);

create table KhachHang
(
	MaKH int primary key not null,
	TenKH nvarchar(50),
	GioiTinh nvarchar(50),
	NgaySinh date,
	SoDienThoai nvarchar(50),
	Email nvarchar(50),
	DiaChi nvarchar(50)
);

create table HopDong
(
	MaHopDong int primary key not null,
	TenLoaiHopDong nvarchar(50),
	Ngaybatdau	date,
	Ngayketthuc	date
);

create table NhanVien
(
	MaNV int primary key not null,
	TenNV nvarchar(50),
	GioiTinh nvarchar(50),
	NgaySinh date,
	SoDienThoai nvarchar(50),
	Luong int,
	Email nvarchar(50),
	DiaChi nvarchar(50),
	MaCV int not null,
	MaHopDong int not null,
	foreign key (MaHopDong) REFERENCES  HopDong(MaHopDong),
	foreign key (MaCV) references ChucVu(MaCV) 
);

create table Account
(
	Username nvarchar(50) primary key not null,
	Password nvarchar(50),
	MaNV int,
	foreign key (MaNV) references NhanVien(MaNV)
);

create table HangDienThoai
(
	MaHDT int primary key not null,
	TenHDT nvarchar(50) not null
);

create table MauDienThoai
(
	MaMDT int primary key not null,
	TenDT nvarchar(50),
	NamSX date,
	KM nvarchar(250),
	MoTa nvarchar(500),
	MaHDT int not null,
	foreign key (MaHDT) REFERENCES  HangDienThoai(MaHDT)
);

create table DienThoai
(
	MaDT int primary key not null,
	Mau nvarchar(50),
	SoLuong int,
	Gia int,
	MaMDT int not null,
	foreign key (MaMDT) references MauDienThoai(MaMDT)
);

--create table CauHinh
--(
--	--MaCH int primary key not null,
--	MaMDT int primary key not null,
--	DisResolution nvarchar(50),
--	DisSize nvarchar(50),
--	CamMain nvarchar(250),
--	Cpu nvarchar(250),
--	Ram nvarchar(50),
--	Rom nvarchar(50),  
--	Pin nvarchar(50)
--	foreign key (MaMDT) references MauDienThoai(MaMDT)
--);

create table HoaDon
(
	MaHD int primary key not null,
	MaKH int not null,
	MaNV int not null,
	NgayMua date,
	HanBH date,
	PTMuaHang nvarchar(50),
	PTThanhToan nvarchar(50),
	Tongtien int,
	foreign key (MaKH) REFERENCES  KhachHang(MaKH),
	foreign key (MaNV) REFERENCES  NhanVien(MaNV)
);

create table ChiTietHoadon
(
	MaCTHD int primary key not null,
	MaHD int not null,
	MaDT int not null,
	foreign key (MaHD) references HoaDon(MaHD),
	foreign key (MaDT) references DienThoai(MaDT),
);

create table SuaChua
(
	MaSC int primary key not null,
	TenDienThoai nvarchar(50),
	NgayNhan date,
	PhiSC int,
	PTThanhToan nvarchar(50),
	NoiDung nvarchar(250),
	MaKH int not null,
	MaNV int not null,
	MaHD int,
	foreign key (MaHD) REFERENCES HoaDon(MaHD),
	foreign key (MaKH) REFERENCES  KhachHang(MaKH),
	foreign key (MaNV) REFERENCES  NhanVien(MaNV)
);
go

---------------------------------------------------------

drop trigger if exists trg_UpdatePhones;
drop trigger if exists trg_UpdateBills;
drop proc if exists pro_SearchPhones;
drop proc if exists pro_CreateWarrantys;
--drop view if exists viw_DetailOrders;
go

create trigger trg_UpdatePhones
on ChiTietHoaDon 
for insert as
begin
	update DienThoai
	set SoLuong = SoLuong - 1
	from DienThoai
	join inserted on DienThoai.MaDT = inserted.MaDT
end
go

create trigger trg_UpdateBills
on ChiTietHoaDon
for insert as
begin
	declare @sum int;
	select @sum = sum(Gia) from DienThoai dt, HoaDon hd, ChiTietHoadon chd 
	where dt.MaDT = chd.MaDT and hd.MaHD = chd.MaHD group by hd.MaHD

    update HoaDon
    set Tongtien=@sum
	from HoaDon
	join inserted on HoaDon.MaHD = inserted.MaHD

end
go

create procedure pro_SearchPhones
@key nvarchar(50)
as
begin
	select mdt.TenDT, dt.MaDT, dt.Mau, dt.SoLuong, dt.Gia, mdt.KM from MauDienThoai mdt, DienThoai dt
	where CHARINDEX(@key,mdt.TenDT) != 0 and mdt.MaMDT = dt.MaMDT;
end
go

create procedure pro_CreateWarrantys
	@MaSC int,
	@TenDienThoai nvarchar(50),
	@NgayNhan date,
	@PhiSC int,
	@PTThanhToan nvarchar(50),
	@NoiDung nvarchar(250),
	@MaKH int,
	@MaNV int,
	@MaHD int
as
begin
	select @MaKH = hd.MaKH, @MaNV = hd.MaNV from HoaDon hd where hd.MaHD = @MaHD
	insert into SuaChua values(@MaSC, @TenDienThoai, @NgayNhan, @PhiSC, @PTThanhToan, @NoiDung, @MaKH, @MaNV, @MaHD)
end
go

--drop view if exists viw_DetailOrders;
--go

--create view viw_DetailOrders(MaCTHD, MaHD, MaDT, TenDT, Mau, Gia, Soluong)
--as
--	select chd.MaCTHD, chd.MaHD, dt.MaDT, mdt.TenDT, dt.Mau, dt.Gia, SoLuong as '0'
--	from ChiTietHoadon chd, DienThoai dt, MauDienThoai mdt 
--	where chd.MaDT = dt.MaDT and dt.MaMDT = mdt.MaMDT;
--go

--drop trigger if exists trg_UpdateDetailBills
--go

--create trigger trg_UpdateDetailBills
--on ChiTietHoaDon
--for insert as
--begin
--	declare @count int;
--	select @count = count(Gia) from  HoaDon hd, DienThoai dt, ChiTietHoadon chd 
--	where dt.MaDT = chd.MaDT and hd.MaHD = chd.MaHD group by dt.MaDT;

--	update viw_DetailOrders
--	set Soluong = @count
--	from viw_DetailOrders
--	join inserted on viw_DetailOrders.MaHD = inserted.MaHD
--end
--go
