create database QuanLyCuaHangQuanAo
go 
use QuanLyCuaHangQuanAo


 ------------------------------NHÀ CUNG CẤP-----------------------------
CREATE TABLE tblNhaCC
(
	sMaNCC nvarchar(50) NOT NULL PRIMARY KEY,
	sTenNhaCC nvarchar(50) NULL,
	sDiachi nvarchar(50) NULL,
	sDienthoai nvarchar(12) NULL,
);

INSERT INTO tblNhaCC ( sMaNCC, sTenNhaCC, sDiachi,sDienthoai )
VALUES	( N'NCC1', N'Đỗ Thùy Dương', N'Quảng Ninh', '0355678341' ),
		( N'NCC2', N'Trần Ánh Minh', N'Nam Định', '0355678342' ),
		( N'NCC3', N'Nguyễn Kiều Anh', N'Bắc Giang', '0355678343' ),
		( N'NCC4', N'Lê Thị Ngọc Ánh', N'Thanh Hóa', '0355678344' ),
		( N'NCC5', N'Võ Thị Thanh', N'Thanh Hóa', '0355678345' ),
		( N'NCC6', N'Phạm Thu Trang', N'Hải Phòng', '0355678346' ),
		( N'NCC7', N'Trần Tuyết Mai', N'Hà Nội', '0355678347' ),
		( N'NCC8', N'Đỗ Minh Thư', N'Hà Nam', '0355678348' ),
		( N'NCC9', N'Trần Phương Ly', N'Ninh Bình', '0355678349' ),
		( N'NCC10', N'Nguyễn Kiều Diễm', N'Nam Định', '0355678340' );

create proc pr_ThemNCC
@MaNCC nvarchar(50), @TenNCC nvarchar(50), @diachi nvarchar(50), @sdt nvarchar(12)
AS
BEGIN
	INSERT INTO tblNhaCC
	VALUES ( @MaNCC, @TenNCC, @diachi, @sdt )
END

 ------------------------------SẢN PHẨM-----------------------------
CREATE TABLE tblSanPham
(
	sMaSP nvarchar(10) NOT NULL PRIMARY KEY,
	sTenSP nvarchar(30) NOT NULL,
	sMaNCC nvarchar(50) NOT NULL,
	fSoluong float NULL,
	fGiaBan float NULL,
	fGiaNhap FLOAT NULL,
	
FOREIGN KEY(sMaNCC) REFERENCES dbo.tblNhaCC(sMaNCC)
);

INSERT INTO tblSanPham ( sMaSP, sTenSP, sMaNCC, fSoluong, fGiaBan, fGiaNhap )
VALUES	( N'SP01', N'Áo Phông', N'NCC10', 50, 150000, 50000 ),
		( N'SP02', N'Áo Polo', N'NCC1', 40, 80000, 10000 ),
		( N'SP03', N'Áo Khoác', N'NCC9', 45, 100000, 40000 ),
		( N'SP04', N'Quần Short', N'NCC2', 30, 200000, 90000 ),
		( N'SP05', N'Quần Dài', N'NCC8', 55, 110000, 45000 ),
		( N'SP06', N'Vest', N'NCC3', 35, 90000, 20000 ),
		( N'SP07', N'Váy Dạ', N'NCC7', 60, 120000, 45000 ),
		( N'SP08', N'Áo Nỉ', N'NCC4', 65, 130000, 60000 ),
		( N'SP09', N'Quần Nỉ', N'NCC6', 50, 300000, 90000 ),
		( N'SP10', N'Đồ Lót', N'NCC5', 60, 115000, 60000 );

SELECT * FROM tblSanPham

 ------------------------------KHÁCH HÀNG-----------------------------
CREATE TABLE tblKhachHang
(
	sMaKH nvarchar(50) NOT NULL PRIMARY KEY ,
	sTenKH nvarchar(50) NULL,
	sDiachi nvarchar(50) NULL,
	sDienthoai varchar(12) NULL,
	bGioiTinh BIT 
);

INSERT INTO tblKhachHang ( sMaKH, sTenKH, sDiachi, sDienthoai, bGioiTinh )
VALUES	( N'KH01', N'Tô Hoài Nam', N'Nam Định', '0967833441', 0 ),
		( N'KH02', N'Trần Quang Anh', N'Nam Định', '0967833442', 0 ),
		( N'KH03', N'Nguyễn Kiều Tâm', N'Bắc Giang', '0967833443', 1 ),
		( N'KH04', N'Lê Thị Ngọc Anh', N'Hà Nam', '0967833444', 1 ),
		( N'KH05', N'Trần Văn Hoàng', N'Thanh Hóa', '0967833445', 0 ),
		( N'KH06', N'Phạm Thu Thảo', N'Hải Phòng', '0967833446', 1 ),
		( N'KH07', N'Trần Tuyết Như', N'Hà Nội', '0967833447', 1 ),
		( N'KH08', N'Đỗ Minh Toàn', N'Hà Nam', '0967833448', 0 ),
		( N'KH09', N'Trần Phương Yến', N'Ninh Bình', '0967833449', 1 ),
		( N'KH10', N'Nguyễn Minh Nhật', N'Nam Định', '0967833440', 0 );

SELECT * FROM tblKhachHang

 ------------------------------NHÂN VIÊN-----------------------------
CREATE TABLE tblNhanVien
(
	sMaNV nvarchar(50) NOT NULL primary key,
	sTenNV nvarchar(50) NULL,
	dNgaysinh DATE NULL, 
	sDiachi nvarchar(50) NULL,
	sDienthoai varchar(12) NULL,
	fLuongcoban FLOAT NULL 
);

INSERT INTO tblNhanVien ( sMaNV, sTenNV, dNgaysinh, sDiachi, sDienthoai, fLuongcoban ) 
VALUES	(N'NV01', N'Trần Khánh Hùng', '1991/03/27', N'Hà Tĩnh', '0953472181', 5000000 ),
		(N'NV02', N'Trần Ngọc Linh', '1992/03/27', N'vĩnh Phúc', '0953472182', 5000000 ),
		(N'NV03', N'Vũ Đức Huy', '1993/03/27', N'Nam Định', '0953472183', 7000000 ),
		(N'NV04', N'Ngô Minh Phương', '1994/03/27', N'Nghệ An', '0953472184', 8000000 ),
		(N'NV05', N'Trần Khánh Hoàng', '1990/03/27', N'Hà Tĩnh', '0953472185', 9000000 ),
		(N'NV06', N'Trần Việt Dũng', '1995/03/27', N'Nam Định', '0953472186', 5500000 ),
		(N'NV07', N'Trần Khánh Toàn', '1989/03/27', N'Hà Nam', '0953472187', 6500000 ),
		(N'NV08', N'Trần Huy Hoàng', '1988/03/27', N'Hà Nội', '0953472188', 7500000 ),
		(N'NV09', N'Trần Minh Trí', '1992/03/27', N'Ninh Bình', '0953472189', 8500000 ),
		(N'NV10', N'Đặng Nhật Minh', '1991/03/27', N'Thái Bình', '0953472180', 9500000 );

create proc pr_ThemNV 
(
	@MaNV nvarchar(50), 
	@TenNV nvarchar(50), 
	@ngaysinh date, 
	@diachi nvarchar(50),
	@sdt nvarchar(50), 
	@Luong float
)
as
insert into tblNhanVien
values (@MaNV, @TenNV, @ngaysinh, @diachi, @sdt ,@Luong)

CREATE PROC pr_XoaNV(@MaNV nvarchar(10))
AS
BEGIN
	DELETE tblNhanVien
	WHERE @MaNV = sMaNV
END


CREATE VIEW vNhanVien
AS
SELECT sMaNV as 'Mã nhân viên', 
	   sTenNV as 'Tên nhân viên',
	   dNgaySinh as 'Ngày sinh',
	   sDiaChi as 'Địa chỉ',
	   sDienThoai as 'Điện Thoại',
	   fLuongcoban as 'Lương cơ bản'
FROM tblNhanVien


------------------------------HÓA ĐƠN-----------------------------
CREATE TABLE tblHoaDon
(
	sSoHD nvarchar(50) NOT NULL PRIMARY KEY,
	sMaNV nvarchar(50) NOT NULL,
	sMaKH nvarchar(50) NOT NULL,
	dNgaymuaSP DATE,
	
FOREIGN KEY(sMaNV) REFERENCES dbo.tblNhanVien(sMaNV),
FOREIGN KEY(sMaKH) REFERENCES dbo.tblKhachHang(sMaKH)
);

INSERT INTO tblHoaDon ( sSoHD, sMaNV, sMaKH, dNgaymuaSP )
VALUES	( N'HD01', N'NV01', N'KH10', '2023/01/01' ),
		( N'HD02', N'NV03', N'KH08', '2023/02/02' ),
		( N'HD03', N'NV05', N'KH06', '2023/01/21' ),
		( N'HD04', N'NV07', N'KH04', '2023/02/21' ),
		( N'HD05', N'NV09', N'KH02', '2023/03/03' ),
		( N'HD06', N'NV10', N'KH01', '2023/04/04' ),
		( N'HD07', N'NV02', N'KH09', '2023/03/15' ),
		( N'HD08', N'NV06', N'KH03', '2023/02/15' ),
		( N'HD09', N'NV08', N'KH05', '2023/03/22' ),
		( N'HD10', N'NV04', N'KH07', '2023/02/22' );

SELECT * FROM tblHoaDon

 ------------------------------CHI TIẾT HÓA ĐƠN-----------------------------
CREATE TABLE tblChiTietHoaDon
(
	sSoHD nvarchar(50) NOT NULL ,
	sMaSP nvarchar(10) NOT NULL ,
	fDonGia FLOAT NULL,
	fSoluong FLOAT NULL,

CONSTRAINT PK_SoHD_MaSP PRIMARY KEY(sSoHD,sMaSP),
FOREIGN KEY(sSoHD) REFERENCES dbo.tblHoaDon(sSoHD),
FOREIGN KEY(sMaSP) REFERENCES dbo.tblSanPham(sMaSP)
);

INSERT INTO tblChiTietHoaDon ( sSoHD, sMaSP, fDonGia, fSoluong)
VALUES	( N'HD09', N'SP02', 80000, 2 ),
		( N'HD10', N'SP01', 150000, 5 ),
		( N'HD07', N'SP04', 200000, 3 ),
		( N'HD08', N'SP03', 100000, 2 ),
		( N'HD06', N'SP06', 90000, 4 ),
		( N'HD01', N'SP10', 115000, 5 ),
		( N'HD02', N'SP09', 300000, 4 ),
		( N'HD05', N'SP05', 110000, 3 ),
		( N'HD04', N'SP07', 120000, 2 ),
		( N'HD03', N'SP08', 130000, 1 );

SELECT * FROM tblChiTietHoaDon

create proc them_SanPham
(
	@MaSP nvarchar(10), 
	@TenSP nvarchar(30), 
	@MaNCC nvarchar(50), 
	@SoLuong float, 
	@GiaBan float, 
	@GiaNhap float
)as
	INSERT INTO tblSanPham
	VALUES ( @MaSP, @TenSP, @MaNCC, @SoLuong, @GiaBan, @GiaNhap )

-----------------------------TÀI KHOẢN-----------------------------
create table tblTaiKhoan
(
	Id int primary key,
	sTenTaiKhoan nvarchar(20),
  sMatKhau nvarchar(20)
)

INSERT INTO dbo.tblTaiKhoan
  (
      Id, sTenTaiKhoan,sMatKhau
  )
  VALUES
  ( '1',N'trung','12345')