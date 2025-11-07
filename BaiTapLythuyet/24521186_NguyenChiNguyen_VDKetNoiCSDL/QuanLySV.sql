create database QLSV
go

use QLSV

create table TSinhVien
(
	MaSo int primary key,
	HoTen nchar(50) not null,
	NgaySinh date,
	GioiTinh nchar(10),
	DiaChi nchar(50),
	DienThoai int -- 1000000000
)
