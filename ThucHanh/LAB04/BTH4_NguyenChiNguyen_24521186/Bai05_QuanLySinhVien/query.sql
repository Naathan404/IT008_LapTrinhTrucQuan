CREATE DATABASE QuanLySinhVien
GO
USE QuanLySinhVien
GO

CREATE TABLE STUDENT
(
	ID CHAR(8) PRIMARY KEY,
	Name NVARCHAR(50),
	Faculty NVARCHAR(50),
	AvgPoint DECIMAL(4, 2),
	CONSTRAINT CHK_AvgPoint CHECK (AvgPoint BETWEEN 0 AND 10)
)

INSERT INTO STUDENT
VALUES
('24521186', N'Nguyễn Chí Nguyên', N'Công nghệ Phần mềm', 7.0),
('24521143', N'Lê Thành Nghĩa', N'Khoa học Máy tính', 9.5),
('24520109', N'Nguyễn Ngọc Lan Anh', N'Hệ thống Thông tin', 8.8),
('24521111', N'Nguyễn Gia Hưng', N'Công nghệ Phần mềm', 9.2) 

