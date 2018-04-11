﻿Create database QLNH2
use QLNH2

Create table TAIKHOAN 
(
MA INT iDENTITY PRIMARY KEY,
TEN NVARCHAR(100) NOT NULL,
TENDANGNHAP NVARCHAR(50) NOT NULL,
MATKHAU NVARCHAR(30) NOT NULL,
PHANQUYEN INT NOT NULL,
)
select*from TAIKHOAN

CREATE TABLE BAN(
MaBAN VARCHAR(5) PRIMARY KEY NOT NULL,
TENBAN NVARCHAR(10),
SOGHE INT
) 
CREATE TABLE KHACHHANG(
MAKH INT IDENTITY PRIMARY KEY NOT NULL,
HOTEN NVARCHAR(50) NOT NULL,
)

CREATE TABLE NHANVIEN (
MANV VARCHAR(5) PRIMARY KEY NOT NULL,
HOTEN NVARCHAR(50) NOT NULL,
GIOITINH NVARCHAR(5),
NGAYSINH DATETIME,
QUEQUAN NVARCHAR(50)
)

CREATE TABLE HOADON(
MAHD VARCHAR(5) PRIMARY KEY NOT NULL,
NGAYLAP DATETIME,
GIOTHANHTOAN TIME,
MANV VARCHAR(5) REFERENCES NHANVIEN(MANV),
MAKH INT REFERENCES KHACHHANG(MAKH),
)	

CREATE TABLE NHOMMON(
MANM VARCHAR(5) PRIMARY KEY NOT NULL,
TENNM NVARCHAR(50)
)

CREATE TABLE MONAN(
MAMON VARCHAR(5) PRIMARY KEY NOT NULL,
TENMON NVARCHAR(50),
DONGIA INT,
MANM VARCHAR(5) REFERENCES NHOMMON(MANM)
)

CREATE TABLE PHIEUYEUCAU(
MAPHIEU VARCHAR(5) PRIMARY KEY NOT NULL,
THOIGIAN TIME,
MAKH INT REFERENCES KHACHHANG(MAKH),
MABAN VARCHAR(5) REFERENCES BAN(MABAN)
)

CREATE TABLE CHITIETPHIEUYEUCAU(
MAPHIEU VARCHAR(5) REFERENCES PHIEUYEUCAU(MAPHIEU),
SOLUONG INT,
MAMON VARCHAR(5) REFERENCES MONAN(MAMON)
)

--INSERT
INSERT INTO TAIKHOAN VALUES ('Nam','admin','123456',1);

INSERT INTO NHOMMON VALUES ('001',N'Món đợi');
INSERT INTO NHOMMON VALUES ('002',N'Khai vị');
INSERT INTO NHOMMON VALUES ('003',N'Món chính');
INSERT INTO NHOMMON VALUES ('004',N'Tráng miệng');
INSERT INTO NHOMMON VALUES ('005',N'Ăn sáng');

INSERT INTO MONAN VALUES ('001',N'Khoai tây chiên',30000,'001');
INSERT INTO MONAN VALUES ('002',N'Lạc rang',20000,'001');
INSERT INTO MONAN VALUES ('003',N'Dưa chuột',20000,'001');
INSERT INTO MONAN VALUES ('004',N'Khoai lang chiên',35000,'001');
INSERT INTO MONAN VALUES ('101',N'Súp gà',50000,'002');
INSERT INTO MONAN VALUES ('102',N'Tôm chiên xù',100000,'002');
INSERT INTO MONAN VALUES ('103',N'Mực chiên xù',120000,'002');
INSERT INTO MONAN VALUES ('104',N'Chả giò hải sản',80000,'002');
INSERT INTO MONAN VALUES ('201',N'Cá chép hấp xì dầu',200000,'003');
INSERT INTO MONAN VALUES ('202',N'Ba Ba xào tỏi',200000,'003');
INSERT INTO MONAN VALUES ('203',N'Gà bó xôi',200000,'003');
INSERT INTO MONAN VALUES ('204',N'Bồ câu quay',180000,'003');
INSERT INTO MONAN VALUES ('205',N'Canh cua rau đay',100000,'003');
INSERT INTO MONAN VALUES ('206',N'Canh sườn khoai tây',100000,'003');
INSERT INTO MONAN VALUES ('207',N'Sườn xào chua ngọt',100000,'003');
INSERT INTO MONAN VALUES ('208',N'Thịt bò xào đỗ',170000,'003');
INSERT INTO MONAN VALUES ('301',N'Hoa quả tươi',80000,'004');
INSERT INTO MONAN VALUES ('302',N'Chè hạt sen',50000,'004');
INSERT INTO MONAN VALUES ('303',N'Bánh quy bơ trà xanh',70000,'004');
INSERT INTO MONAN VALUES ('401',N'Phở bò',30000,'005');
INSERT INTO MONAN VALUES ('402',N'Bún chả',30000,'005');
INSERT INTO MONAN VALUES ('403',N'Bún bò',30000,'005');

INSERT INTO BAN VALUES ('001',N'Bàn nhỏ 1',4);
INSERT INTO BAN VALUES ('002',N'Bàn nhỏ 2',4);
INSERT INTO BAN VALUES ('003',N'Bàn nhỏ 3',4);
INSERT INTO BAN VALUES ('004',N'Bàn nhỏ 4',4);
INSERT INTO BAN VALUES ('005',N'Bàn nhỏ 5',4);
INSERT INTO BAN VALUES ('101',N'Bàn vừa 1',8);
INSERT INTO BAN VALUES ('102',N'Bàn vừa 2',8);
INSERT INTO BAN VALUES ('103',N'Bàn vừa 3',8);
INSERT INTO BAN VALUES ('104',N'Bàn vừa 4',8);
INSERT INTO BAN VALUES ('105',N'Bàn vừa 5',8);
INSERT INTO BAN VALUES ('201',N'Bàn to 1',10);
INSERT INTO BAN VALUES ('202',N'Bàn to 2',10);
INSERT INTO BAN VALUES ('203',N'Bàn to 3',12);
INSERT INTO BAN VALUES ('204',N'Bàn to 4',12);
INSERT INTO BAN VALUES ('205',N'Bàn to 5',14);
INSERT INTO BAN VALUES ('206',N'Bàn to 6',14);
INSERT INTO BAN VALUES ('301',N'Bàn VIP 1',8);
INSERT INTO BAN VALUES ('302',N'Bàn VIP 2',12);
INSERT INTO BAN VALUES ('303',N'Bàn VIP 3',16);
INSERT INTO BAN VALUES ('304',N'Bàn VIP 4',20);

INSERT INTO KHACHHANG VALUES (N'Lâm Xung');
INSERT INTO KHACHHANG VALUES (N'Tống Giang');
INSERT INTO KHACHHANG VALUES (N'Lư Tuấn nghĩa');
INSERT INTO KHACHHANG VALUES (N'Võ Tòng');
INSERT INTO KHACHHANG VALUES (N'Phan Kim Liên');
INSERT INTO KHACHHANG VALUES (N'Lữ Bố');
INSERT INTO KHACHHANG VALUES (N'Điêu Thuyền');
INSERT INTO KHACHHANG VALUES (N'Tào Tháo');
select * from KHACHHANG

INSERT INTO NHANVIEN VALUES ('NV01',N'SƠN TÙNG','NAM',2-2-1992,N'THÁI BÌNH');
INSERT INTO NHANVIEN VALUES ('NV02',N'CHỊ DẬU',N'NỮ',21-12-1991,N'HÀ NỘI');
INSERT INTO NHANVIEN VALUES ('NV03',N'LÃO HẠC','NAM',5-2-1997,N'BẮC NINH');
INSERT INTO NHANVIEN VALUES ('NV04',N'CẬU VÀNG','NAM',1-2-1995,N'THÁI NGUYÊN');
INSERT INTO NHANVIEN VALUES ('NV05',N'ÔNG GIÁO','NAM',1-7-2000,N'THÁI LAN');
INSERT INTO NHANVIEN VALUES ('NV06',N'HERA',N'NỮ',2-4-1992,N'HÀN QUỐC');
INSERT INTO NHANVIEN VALUES ('NV07',N'THUỲ LINH',N'NỮ',22-12-1993,N'SƠN LA');
INSERT INTO NHANVIEN VALUES ('NV08',N'VÀNG ANH',N'NỮ',18-11-2002,N'THÁI BÌNH');

INSERT INTO HOADON VALUES ('HD01',31-02-2018,'6:12','NV01',01);
INSERT INTO HOADON VALUES ('HD02',11-02-2018,'20:00','NV02',02);
INSERT INTO HOADON VALUES ('HD03',01-01-2018,'9:30','NV03',03);
INSERT INTO HOADON VALUES ('HD04',07-09-2017,'12:00','NV04',04);
INSERT INTO HOADON VALUES ('HD05',07-09-2017,'13:10','NV05',05);
INSERT INTO HOADON VALUES ('HD06',07-09-2017,'14:03','NV06',06);
INSERT INTO HOADON VALUES ('HD07',07-09-2017,'10:14','NV07',07);

INSERT INTO PHIEUYEUCAU VALUES ('PH01','11:11',01,'001');
INSERT INTO PHIEUYEUCAU VALUES ('PH02','22:22',02,'103');
INSERT INTO PHIEUYEUCAU VALUES ('PH03','12:21',03,'102');
INSERT INTO PHIEUYEUCAU VALUES ('PH04','21:12',04,'302');


INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH01',2,'001');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH01',4,'204');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH01',2,'301');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH02',1,'002');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH02',5,'202');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH03',2,'101');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH03',1,'208');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH04',1,'004');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH04',3,'104');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH04',3,'205');
INSERT INTO CHITIETPHIEUYEUCAU VALUES ('PH04',1,'303');



--THÊM DỮ LIỆU
--Thêm dữ liệu cho bảng NHANVIEN 

CREATE PROCEDURE ADD_NHANVIEN
    (@MANV VARCHAR(5),
	@HOTEN NVARCHAR(50),
	@GIOITINH NVARCHAR(5),
	@NGAYSINH DATETIME,
	@QUEQUAN NVARCHAR(50))

AS
BEGIN
IF NOT EXISTS(SELECT @MANV,@HOTEN,@GIOITINH,@NGAYSINH,@QUEQUAN FROM NHANVIEN WHERE MANV=@MANV OR HOTEN= @HOTEN OR GIOITINH=@GIOITINH OR NGAYSINH =@NGAYSINH OR QUEQUAN =@QUEQUAN)
			BEGIN
				INSERT INTO NHANVIEN(MANV,HOTEN,GIOITINH,NGAYSINH,QUEQUAN)
				VALUES(@MANV,@HOTEN,@GIOITINH,@NGAYSINH,@QUEQUAN)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

--
--Thêm dữ liệu bảng KHACHHANG
CREATE PROCEDURE ADD_KHACHHANG 
 (@MAKH VARCHAR(5),
 @HOTEN NVARCHAR(50))

 AS
BEGIN
IF NOT EXISTS(SELECT @MAKH,@HOTEN FROM KHACHHANG WHERE MAKH=@MAKH OR HOTEN=@HOTEN)
			BEGIN
				INSERT INTO KHACHHANG(MAKH,HOTEN)
				VALUES(@MAKH,@HOTEN)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END



--Thêm dữ liệu bảng MONAN 
CREATE PROCEDURE ADD_MONAN
@MAMON VARCHAR(5), 
@TENMON NVARCHAR(50),
@DONGIA INT,
@MANM VARCHAR(5)

AS
BEGIN
IF NOT EXISTS(SELECT @MAMON,@TENMON,@DONGIA,@MANM FROM MONAN WHERE MAMON=@MAMON OR TENMON=@TENMON OR DONGIA=@DONGIA OR MANM=@MANM)
			BEGIN
				INSERT INTO MONAN(MAMON,TENMON,DONGIA,MANM)
				VALUES(@MAMON,@TENMON,@DONGIA,@MANM)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END



--Thêm dữ liệu bảng NHOMMON
CREATE PROCEDURE ADD_NHOMMON

@MANM VARCHAR(5),
@TENNM NVARCHAR(50)
AS
BEGIN
IF NOT EXISTS(SELECT @MANM,@TENNM FROM NHOMMON WHERE MANM=@MANM OR TENNM=@TENNM)
			BEGIN
				INSERT INTO NHOMMON(MANM,TENNM)
				VALUES(@MANM,@TENNM)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END


--Thêm dữ liệu BAN 

CREATE PROCEDURE ADD_BAN

@MABAN VARCHAR(5) ,
@TENBAN NVARCHAR(10),
@SOGHE INT
AS
BEGIN
IF NOT EXISTS(SELECT @MABAN,@TENBAN,@SOGHE FROM BAN WHERE MABAN=@MABAN OR TENBAN=@TENBAN OR SOGHE=@SOGHE)
			BEGIN
				INSERT INTO BAN(MABAN,TENBAN,SOGHE)
				VALUES(@MABAN,@TENBAN,@SOGHE)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END



--Thêm dữ liệu bảng PHIEUYEUCAU

CREATE PROCEDURE ADD_PHIEUYEUCAU
@MAPHIEU INT,
@THOIGIAN TIME,
@MAKH VARCHAR(5),
@MABAN VARCHAR(5) 
AS
BEGIN
IF NOT EXISTS(SELECT @MAPHIEU,@THOIGIAN,@MAKH FROM PHIEUYEUCAU WHERE MAPHIEU=@MAPHIEU OR THOIGIAN=@THOIGIAN OR MAKH=@MAKH)
			BEGIN
				INSERT INTO PHIEUYEUCAU(MAPHIEU,THOIGIAN,MAKH)
				VALUES(@MAPHIEU,@THOIGIAN,@MAKH)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END


--EXEC INSERT_PHIEUYEUCAU

--Thêm dữ liệu bảng HOADON 


CREATE PROCEDURE ADD_HOADON
@MAHD VARCHAR(5) ,
@NGAYLAP DATETIME,
@GIOTHANHTOAN TIME,
@MANV VARCHAR(5),
@MAKH VARCHAR(5)
AS
BEGIN
IF NOT EXISTS(SELECT @MAHD,@NGAYLAP,@GIOTHANHTOAN,@MANV,@MAKH FROM HOADON WHERE MAHD=@MAHD OR NGAYLAP=@NGAYLAP OR GIOTHANHTOAN=@GIOTHANHTOAN OR MAKH=@MAKH)
			BEGIN
				INSERT INTO HOADON(MAHD,NGAYLAP,GIOTHANHTOAN,MAKH)
				VALUES(@MAHD,@NGAYLAP,@GIOTHANHTOAN,@MAKH)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

--EXEC INSERT_HOADON

--Thêm dữ liệu bảng CTHOADON


CREATE PROCEDURE ADD_CHITIETPHIEUYEUCAU
@MAPHIEU varCHAR(5),
@SOLUONG INT,
@MAMON varCHAR(5)
AS
BEGIN
IF NOT EXISTS(SELECT @MAPHIEU,@SOLUONG,@MAMON FROM CHITIETPHIEUYEUCAU WHERE MAPHIEU=@MAPHIEU OR SOLUONG=@SOLUONG OR MAMON=@MAMON)
			BEGIN
				INSERT INTO CHITIETPHIEUYEUCAU
				VALUES(@MAPHIEU,@SOLUONG,@MAMON)
			END
		ELSE
			BEGIN
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

----------------------------------------------------

--SỬA DỮ LIỆU


CREATE PROCEDURE ALTER_NHANVIEN
    (@MANV VARCHAR(5),
	@HOTEN NVARCHAR(50),
	@GIOITINH NVARCHAR(5),
	@NGAYSINH DATETIME,
	@QUEQUAN NVARCHAR(50))
AS
	BEGIN
		IF NOT EXISTS(SELECT MANV,HOTEN,GIOITINH,NGAYSINH,QUEQUAN FROM NHANVIEN WHERE MANV=@MANV OR HOTEN=@HOTEN OR GIOITINH =@GIOITINH OR NGAYSINH=@NGAYSINH OR QUEQUAN=@QUEQUAN)
			BEGIN
				UPDATE NHANVIEN
				SET HOTEN=@HOTEN
				WHERE MANV=@MANV
			END
		ELSE
			BEGIN
				PRINT 'No update, already exists'
				ROLLBACK TRANSACTION
			END
	END
--EXEC NHANVIEN
--Sửa dữ liệu bảng khách hàng 

CREATE PROCEDURE ALTER_KHACHHANG
 @MAKH VARCHAR(5),
 @HOTEN NVARCHAR(50)

 AS
BEGIN
IF NOT EXISTS(SELECT @MAKH,@HOTEN FROM KHACHHANG WHERE MAKH=@MAKH OR HOTEN=@HOTEN)
			BEGIN
			UPDATE KHACHHANG
				SET HOTEN=@HOTEN
				WHERE MAKH=@MAKH
			END
		ELSE
			BEGIN
				PRINT 'No update, already exists'
				ROLLBACK TRANSACTION
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

--Sửa dữ liệu bảng MONAN

CREATE PROCEDURE ALTER_MONAN
@MAMON VARCHAR(5), 
@TENMON NVARCHAR(50),
@DONGIA INT,
@MANM VARCHAR(5)

AS
BEGIN
IF NOT EXISTS(SELECT @MAMON,@TENMON,@DONGIA,@MANM FROM MONAN WHERE MAMON=@MAMON OR TENMON=@TENMON OR DONGIA=@DONGIA OR MANM=@MANM)
			BEGIN

		UPDATE MONAN
				SET TENMON=@TENMON
				WHERE MAMON=@MAMON
			END
		ELSE
			BEGIN
				PRINT 'No update, already exists'
				ROLLBACK TRANSACTION
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

--Sừa dữ liệu bảng NHOMMON

--Sửa dữ liệu bảng HOADON 

CREATE PROCEDURE ALTER_HOADON
@MAHD VARCHAR(5) ,
@NGAYLAP DATETIME,
@GIOTHANHTOAN TIME,
@MANV VARCHAR(5),
@MAKH VARCHAR(5) 

AS
BEGIN
IF NOT EXISTS(SELECT @MAHD,@NGAYLAP,@GIOTHANHTOAN,@MANV,@MAKH FROM HOADON WHERE MAHD=@MAHD OR MANV=@MANV OR NGAYLAP=@NGAYLAP OR GIOTHANHTOAN=@GIOTHANHTOAN OR MAKH=@MAKH)
			BEGIN
				UPDATE HOADON
				SET NGAYLAP=@NGAYLAP
				WHERE MAHD=@MAHD
			END
		ELSE
			BEGIN
				PRINT 'No update, already exists'
				ROLLBACK TRANSACTION
				PRINT 'ALREADY EXIST'
				ROLLBACK TRANSACTION
            END
END

--Sửa dữ liệu bảng CTHOADON

--Sửa dữ liệu PHIEUYEUCAU

--Sửa dữ liệu bảng BAN

----------------------------------------------------------------------
--XÓA DỮ LIỆU
--Xóa dữ liệu bảng NHANVIEN
CREATE PROCEDURE D_NHANVIEN
    (@MANV VARCHAR(5),
	@HOTEN NVARCHAR(50),
	@GIOITINH NVARCHAR(5),
	@NGAYSINH DATETIME,
	@QUEQUAN NVARCHAR(50))
	AS
	BEGIN 
		IF EXISTS(SELECT HOTEN FROM NHANVIEN WHERE MANV=@MANV )
			BEGIN
				DELETE FROM NHANVIEN
				WHERE MANV=@MANV
			END
		ELSE
			BEGIN
				PRINT 'Does not exist !'
				ROLLBACK
			END
	END
--Xóa dữ liệu bảng KHACHHANG
CREATE PROCEDURE D_KHACHHANG
 @MAKH VARCHAR(5),
 @HOTEN NVARCHAR(50)
 AS
	BEGIN 
		IF EXISTS(SELECT MAKH FROM KHACHHANG WHERE MAKH=@MAKH )
			BEGIN
				DELETE FROM KHACHHANG
				WHERE @MAKH=@MAKH
			END
		ELSE
			BEGIN
				PRINT 'Does not exist !'
				ROLLBACK
			END
	END
--XÓA DỮ LIỆU BẢNG MONAN
CREATE PROCEDURE D_MONAN
@MAMON VARCHAR(5), 
@TENMON NVARCHAR(50),
@DONGIA INT,
@MANM VARCHAR(5)
AS
	BEGIN 
		IF EXISTS(SELECT * FROM MONAN WHERE MAMON=@MAMON )
			BEGIN
				DELETE FROM MONAN
				WHERE MAMON=@MAMON
			END
		ELSE
			BEGIN
				PRINT 'Does not exist !'
				ROLLBACK
			END
	END
--XÓA DỮ LIỆU BẢNG NHOMMON
--xÓA DỮ LIỆU BẢNG HOADON
CREATE PROCEDURE D_HOADON
@MAHD VARCHAR(5) ,
@NGAYLAP DATETIME,
@GIOTHANHTOAN TIME,
@MANV VARCHAR(5),
@MAKH VARCHAR(5) ,
@MABAN VARCHAR(5)
AS
	BEGIN 
		IF EXISTS(SELECT GIOTHANHTOAN FROM HOADON WHERE MAHD=@MAHD )
			BEGIN
				DELETE FROM HOADON
				WHERE MAHD=@MAHD
			END
		ELSE
			BEGIN
				PRINT 'Does not exist !'
				ROLLBACK
			END
	END
--XÓA DỮ LIỆU BẢNG CTHOADON
--XÓA DỮ LIỆU BẢNG PHIEUYEUCAU
--XÓA DỮ LIỆU BẢNG BÀN
