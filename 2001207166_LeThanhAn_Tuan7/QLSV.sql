CREATE DATABASE QLSINHVIEN
GO

USE QLSINHVIEN
GO

CREATE TABLE KHOA 
(
MaKhoa nvarchar(10) Primary key,
TenKhoa nvarchar(50) NOT NULL
)
GO

CREATE TABLE LOP
(
MaLop nvarchar(10) Primary key,
TenLop nvarchar(50),
MaKhoa nvarchar(10)
)
GO

CREATE TABLE SINHVIEN
(
MaSinhVien int Primary key,
HoTen nvarchar(30),
NgaySinh DateTime,
MaLop nvarchar(10)
)
GO

CREATE TABLE MONHOC
(
MaMonHoc nvarchar(10) Primary key,
TenMonHoc nvarchar(50)
)
GO

CREATE TABLE DIEM
(
MaSinhVien int,
MaMonHoc nvarchar(10),
Primary key(MaSinhVien,MaMonHoc),
Diem float
)
GO

ALTER TABLE dto.LOP
ADD CONSTRAINT PK_Lop
FOREIGN KEY(MaKhoa)
REFERENCES Khoa(MaKhoa)

ALTER TABLE dbo.SINHVIEN
ADD CONSTRAINT PK_SV 
FOREIGN KEY(MALOP)
REFERENCES Lop(MaLop)  

ALTER TABLE dbo.DIEM
ADD CONSTRAINT PK_MSV
FOREIGN KEY(MaSinhVien)
REFERENCES SinhVien(MaSinhVien) 

ALTER TABLE dbo.DIEM
ADD CONSTRAINT PK_MMH 
FOREIGN KEY(MaMonHoc)
REFERENCES MonHoc(MaMonHoc) 

