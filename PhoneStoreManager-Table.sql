use master;
go

drop database if exists PhoneStoreManage;
go

create database PhoneStoreManage;
go

use PhoneStoreManage;
go

drop table if exists CauHinh;
drop table if exists BaoHanh;
drop table if exists ChitietHoadon;
drop table if exists HoaDon;
drop table if exists DienThoai;
drop table if exists MauDienThoai;
drop table if exists DongDienThoai;
drop table if exists HangDienThoai;
drop table if exists NhanVien;
drop table if exists HopDong;
drop table if exists KhachHang;
drop table if exists ChucVu;
drop table if exists Account;
go

create table Account
(
	Username nvarchar(50),
	Password nvarchar(50)
);

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
	DiaChi nvarchar(50),
	MaCV int not null,
	MaHopDong int not null,
	foreign key (MaHopDong) REFERENCES  HopDong(MaHopDong),
	foreign key (MaCV) references ChucVu(MaCV) 
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

create table CauHinh
(
	MaMDT int not null,
	DisResolution nvarchar(50),
	DisSize nvarchar(50),
	CamMain nvarchar(250),
	Cpu nvarchar(250),
	Ram nvarchar(50),
	Rom nvarchar(50),  
	Pin nvarchar(50)
	foreign key (MaMDT) references MauDienThoai(MaMDT)
);

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
	MaHD int not null,
	MaDT int not null,
	foreign key (MaHD) references HoaDon(MaHD),
	foreign key (MaDT) references DienThoai(MaDT),
);

create table SuaChua
(
	MaSC int primary key not null,
	NgayNhan date,
	NoiDung nvarchar(250),
	PhiSC int,
	MaHD int not null,
	foreign key (MaHD) REFERENCES HoaDon(MaHD)	
);
go

drop trigger if exists trg_UpdatePhones;
drop trigger if exists trg_UpdateBills;
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

drop proc if exists pro_SearchPhones
go
create procedure pro_SearchPhones
@key nvarchar(50)
as
begin
	select mdt.TenDT, mdt.MaMDT, dt.Mau, dt.SoLuong, dt.Gia, mdt.KM from MauDienThoai mdt, DienThoai dt
	where CHARINDEX(@key,mdt.TenDT) != 0 and mdt.MaMDT = dt.MaMDT;
end

exec pro_SearchPhones @key = "pro";

------------------------------------

select hd.MaHD, sum(Gia) as [TongTien] from DienThoai dt, HoaDon hd, ChiTietHoadon chd 
where dt.MaDT = chd.MaDT and hd.MaHD = chd.MaHD group by hd.MaHD 

select * from DienThoai;
select * from ChiTietHoadon;
select * from HoaDon;