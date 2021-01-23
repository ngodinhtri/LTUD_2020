/*TẠO DATABASE*/
create database QLSV
go
use QLSV
go

set dateformat dmy;
go

/*TẠO BẢNG*/
-- bảng khoa
create table KHOA (MAKHOA char(6) primary key not null,TENKHOA nvarchar(30))
go
--bảng sinh viên
create table SINHVIEN (
MASV char(6) primary key not null,
HOSV nvarchar(30) not null,
TENSV nvarchar(15) not null,
GIOITINH char(3), NGAYSINH date,
NOISINH nvarchar(50),
DIACHI nvarchar(50),
QUAN nvarchar(10),
MAKHOA char(6),
constraint fk_SINHVIEN_MAKHOA foreign key (MAKHOA) references KHOA(MAKHOA),
HOCBONG int)
go
--bảng môn học
create table MONHOC (MAMH char(6) primary key not null, TENMH nvarchar(30) not null, SOTIET int)
go
--bảng kết quả
create table KETQUA (MASV char(6) not null, MAMH char(6) not null, DIEMTHI int,
constraint fk_KETQUA_MASV foreign key (MASV) references SINHVIEN(MASV),
constraint fk_KETQUA_MAMH foreign key (MAMH) references MONHOC(MAMH),
primary key(MASV, MAMH))
go

/*Tạo StoreProcedure*/
--/bảng khoa/--
--Thêm
create procedure sp_themKhoa(@makhoa char(6), @tenkhoa nvarchar(30))
as
	insert into KHOA(MAKHOA,TENKHOA) values (@makhoa, @tenkhoa)
go
--Xóa
create procedure sp_xoaKhoa(@makhoa char(6))
as 
	begin
		delete from KHOA where MAKHOA = @makhoa
	end
go
--Sửa
create procedure sp_suaKhoa(@makhoa char(6), @tenKhoa nvarchar(30))
as
	begin
		update KHOA set MAKHOA = @makhoa, TENKHOA = @tenKhoa where MAKHOA = @makhoa
	end
go
--lấy
create procedure [dbo].[sp_layKhoa]
@makhoa char(6)
as
	begin
		select * from KHOA where MAKHOA = @makhoa
	end
go

--/bảng MonHoc/--
--Thêm
create procedure sp_themMonHoc(@maMH char(6), @tenMH nvarchar(30), @soTiet int)
as
	insert into MONHOC(MAMH,TENMH,SOTIET) values (@maMH, @tenMH,@soTiet)
go
--Xóa
create procedure sp_xoaMonHoc(@maMH char(6))
as 
	begin
		delete from MONHOC where MAMH = @maMH
	end
go
--Sửa
create procedure sp_SuaMonHoc(@maMH char(6), @tenMH nvarchar(30), @soTiet int)
as
	begin
		update MONHOC set MAMH = @maMH, TENMH = @tenMH, SOTIET = @soTiet where MAMH = @maMH
	end
go
--lấy
create procedure [dbo].[sp_layMonHoc]
@maMonHoc char(6)
as
	begin
		select * from MONHOC where MAMH = @maMonHoc
	end
go

--/bảng Sinh Viên/--
--Thêm
create proc [dbo].[sp_ThemSV]
@maSV char(6), @hoSV nvarchar(30), @tenSV nvarchar(15), @gioiTinh char(3),
@ngaySinh date, @noiSinh nvarchar(50), @diaChi nvarchar(50), @quan nvarchar(10), @maKhoa char(6), @hocBong int
as
	insert into SINHVIEN(MASV, HOSV, TENSV, GIOITINH, NGAYSINH,NOISINH,DIACHI,QUAN, MAKHOA,HOCBONG)
	values (@maSV,@hoSV,@tenSV,@gioiTinh,@ngaySinh,@noiSinh,@diaChi,@quan,@maKhoa,@hocBong)
go
--Xóa
create proc [dbo].[sp_xoaSV]
@maSV char(6)
as
	begin
		delete from SINHVIEN where MASV = @maSV
	end
go
--Sửa
create proc [dbo].[sp_SuaSV]
@maSV char(6), @hoSV nvarchar(30), @tenSV nvarchar(15), @gioiTinh char(3),
@ngaySinh date, @noiSinh nvarchar(50), @diaChi nvarchar(50), @quan nvarchar(10), @maKhoa char(6), @hocBong int
as
	begin
		update SINHVIEN set MASV = @maSV, HOSV = @hoSV, TENSV = @tenSV, GIOITINH = @gioiTinh, NGAYSINH = @ngaySinh,
		NOISINH = @noiSinh, DIACHI = @diaChi, QUAN = @quan, MAKHOA = @maKhoa, HOCBONG = @hocBong
	end
go
--Lấy
create proc [dbo].[sp_laySinhVien]
@maSv char(6)
as 
	begin
		select * from SINHVIEN where MASV = @maSv
	end
go

--/bảng Kết Quả/--
--Thêm
create proc sp_themKetQua(@maSV char(6), @maMH char(6), @diemThi int)
as
	insert into KETQUA(MASV, MAMH, DIEMTHI) values (@maSV, @maMH, @diemThi)
go
--Xóa
create proc sp_xoaKetQua(@maSV char(6), @maMH char(6))
as
	begin 
		delete from KETQUA where MASV = @maSV and MAMH = @maMH
	end
go
--Sửa
create proc sp_suaKetQua(@maSV char(6), @maMH char(6), @diemThi int)
as
	begin
		update KETQUA set MASV = @maSV, MAMH = @maMH, DIEMTHI = @diemThi where MASV = @maSV and MAMH = @maMH
	end
go
--Lấy
create proc sp_LayKetQua(@maSV char(6), @maMH char(6))
as
	begin
		select * from KETQUA where MASV = @maSV and MAMH = @maMH
	end 
go
