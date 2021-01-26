/* TẠO DATABASE QUẢN LÝ SINH VIÊN */
create database QLSV
go
use QLSV
go

set dateformat dmy;
go

/* TẠO BẢNG */
--Bảng Khoa
create table KHOA (MAKHOA char(6) primary key not null, TENKHOA nvarchar(30))
go
--Bảng SinhVien
create table SINHVIEN (
MASV char(6) primary key not null,
HOSV nvarchar(30) not null,
TENSV nvarchar(15) not null,
GIOITINH char(3),
NGAYSINH date,
NOISINH nvarchar(50),
DIACHI nvarchar(50),
MAKHOA char(6),
HOCBONG int,
constraint fk_SINHVIEN_KHOA foreign key (MAKHOA) references KHOA (MAKHOA))
go
--Bảng MonHoc
create table MONHOC(MAMH char(6) primary key not null, TENMH nvarchar(30) not null, SOTIET int)
go
--Bảng KetQua
create table KETQUA (MASV char(6) not null, MAMH char(6) not null, DIEMTHI int,
constraint fk_KETQUA_SINHVIEN foreign key (MASV) references SINHVIEN (MASV),
constraint fk_KETQUA_MONHOC foreign key (MAMH) references MONHOC (MAMH),
primary key(MASV,MAMH))
go

/* TẠO STOREDPROCEDURE*/
--/ Bảng Khoa /--
--Thêm
create procedure sp_ThemKhoa(@maKhoa char(6), @tenKhoa nvarchar(30))
as
	begin 
		insert into KHOA (MAKHOA, TENKHOA) values (@maKhoa, @tenKhoa)
	end
go
--Xóa 
create procedure sp_XoaKhoa(@maKhoa char(6))
as
	begin 
		delete from KHOA where MAKHOA = @maKhoa
	end
go
--Sửa
create procedure sp_SuaKhoa(@maKhoa char(6), @tenKhoa nvarchar(30))
as
	begin 
		update KHOA set  TENKHOA = @tenKhoa where MAKHOA = @maKhoa
	end
go


--/Bảng SinhVien/--
--Thêm
create procedure sp_ThemSinhVien(
@maSV char(6),
@ho nvarchar(30),
@ten nvarchar(15),
@gt char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@maKhoa char(6),
@hocBong int)
as
	begin 
		insert into SINHVIEN(MASV, HOSV, TENSV, GIOITINH, NGAYSINH, NOISINH, DIACHI, MAKHOA,HOCBONG)
		values (@maSV,@ho ,@ten ,@gt ,@ngaySinh ,@noiSinh,@diaChi,@maKhoa ,@hocBong)
	end
go
--Xóa
create procedure sp_XoaSinhVien(@maSV char(6))
as
	begin 
		delete from SINHVIEN where MASV = @maSV
	end
go
--Sửa
create procedure sp_SuaSinhVien(
@maSV char(6),
@ho nvarchar(30),
@ten nvarchar(15),
@gt char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@maKhoa char(6),
@hocBong int)
as
	begin 
		 update SINHVIEN set HOSV = @ho ,TENSV = @ten ,GIOITINH = @gt ,NGAYSINH = @ngaySinh ,NOISINH = @noiSinh,DIACHI = @diaChi,MAKHOA = @maKhoa ,HOCBONG = @hocBong
		 where MASV = @maSV
	end
go