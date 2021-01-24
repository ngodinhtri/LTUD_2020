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
create procedure sp_themKhoa(@maKhoa char(6), @tenKhoa nvarchar(30))
as
	insert into KHOA(MAKHOA, TENKHOA) values (@maKhoa, @tenKhoa)
go
--xóa
create procedure sp_xoaKhoa(@makhoa char(6))
as
	begin
		delete from KHOA where MAKHOA = @makhoa;
	end
go
--Sửa
create procedure sp_suaKhoa(@makhoa char(6), @tenKhoa nvarchar(30))
as 
	begin
		update KHOA set TENKHOA = @tenKhoa where MAKHOA = @makhoa
	end
go
--Lấy 
create procedure sp_layKhoa(@maKhoa char(6))
as
	begin
		select * from KHOA where MAKHOA = @maKhoa
	end
go

--/ Bảng SinhVien /--
--Thêm
create procedure sp_themSV(
@maSV char(6), 
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@maKhoa char(6),
@hocBong int)
as 
	begin
		insert into SINHVIEN(MASV, HOSV, TENSV, GIOITINH, NGAYSINH, NOISINH, DIACHI, MAKHOA,HOCBONG)
		values (@maSV, @hoSV,@tenSV ,@gioiTinh ,@ngaySinh ,@noiSinh ,@diaChi ,@maKhoa ,@hocBong)
	end
go
--Xóa
create procedure sp_xoaSV(@maSV char(6))
as 
	begin
		delete from SINHVIEN where MASV = @maSV;
	end
go
--Sửa
create procedure sp_suaSV(
@maSV char(6), 
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@maKhoa char(6),
@hocBong int)
as
	begin
		update SINHVIEN set HOSV = @hoSV, TENSV = @tenSV ,GIOITINH = @gioiTinh ,NGAYSINH  = @ngaySinh ,NOISINH = @noiSinh ,DIACHI = @diaChi ,MAKHOA = @maKhoa ,HOCBONG = @hocBong where MASV = @maSV;
	end
go
--Lấy
create procedure sp_laySV (@maSV char(6))
as
	begin
		select * from SINHVIEN where MASV = @maSV;
	end
go

--/ Bảng MonHoc /--
--Thêm
create procedure sp_themMH(@maMH char(6), @tenMH nvarchar(30) , @soTiet int)
as
	begin
		insert into MONHOC (MAMH, TENMH, SOTIET) values (@maMH, @tenMH, @soTiet);
	end
go
--Xóa
create procedure sp_xoaMH(@maMH char(6))
as 
	begin
		delete from MONHOC where MAMH = @maMH;
	end
go
--Sửa
create procedure sp_suaMH(@maMH char(6), @tenMH nvarchar(30) , @soTiet int)
as
	begin
		update MONHOC set TENMH = @tenMH, SOTIET = @soTiet where MAMH = @maMH;
	end
go
--Lấy
create procedure sp_layMH (@maMH char(6))
as
	begin
		select * from MONHOC where MAMH = @maMH;
	end
go


--/ Bảng KetQua /--
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
		update KETQUA set DIEMTHI = @diemThi where MASV = @maSV and MAMH = @maMH
	end
go
--Lấy
create proc sp_layKetQua(@maSV char(6), @maMH char(6))
as
	begin
		select * from KETQUA where MASV = @maSV and MAMH = @maMH
	end 
go