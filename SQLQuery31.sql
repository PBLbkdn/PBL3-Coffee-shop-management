use QuanCaPhePBL3;

Create table TaiKhoan(
MaNV int Primary key,
TenDangNhap nvarchar(255),
MatKhau nvarchar(255) 
);
insert into TaiKhoan values (1, N'admin1', N'admin1');
insert into TaiKhoan values (2, N'thungan1', N'thungan1');
insert into TaiKhoan (MaNV) values (3);
insert into TaiKhoan (MaNV) values (4);


Create table ChucVu (
MaCV int primary key,
TenCV nvarchar(255)
);
insert into ChucVu values (1,N'Quản lý');
insert into ChucVu values (2,N'Nhân viên thu ngân');
insert into ChucVu values (3,N'Nhân viên pha chế');
insert into ChucVu values (4,N'Nhân viên phục vụ');

CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
	MaCV int not null,
    HoTenNV nVARCHAR(255),
	NgaySinh Date,
	SDT Varchar(255),
	Luong bigint,
	GioiTinh bit, 
	CONSTRAINT FK_MaChucVu FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
);
insert into NhanVien values (1,1, N'Nguyễn Văn A', '2004-07-03', '0765500744', 4000000, 1);
insert into NhanVien values (2,2, N'Nguyễn Văn B', '2004-07-05', '0776500744', 3500000, 0);
insert into NhanVien values (3,3, N'Nguyễn Văn C', '2004-07-04', '0776600744', 3000000, 0);
insert into NhanVien values (4,4, N'Nguyễn Văn D', '2004-07-06', '0775660744', 3000000, 0);
insert into NhanVien values (5,2, N'Nguyễn Văn E', '2000-07-06', '0775650744', 3500000, 0);
insert into NhanVien values (6,4, N'Nguyễn Văn F', '2000-07-06', '0665660744', 3000000, 0);

Create table CaTruc(
MaCT int,
NgayTruc Date ,
ThoiGianBD Time,
ThoiGianKT Time
primary key (MaCT, NgayTruc)
);
insert into CaTruc values (1, '2022-04-21', '07:00', '12:00');
insert into CaTruc values (2, '2022-04-21', '12:00', '17:00');
insert into CaTruc values (3, '2022-04-21', '17:00', '22:00');
insert into CaTruc values (1, '2024-04-23', '07:00', '12:00');
insert into CaTruc values (2, '2024-04-23', '12:00', '17:00');
insert into CaTruc values (3, '2024-04-23', '17:00', '22:00');
create table ChiTietCaTruc(
MaCT int, 
NgayTruc Date,
MaNV int,
Primary key (MaCT, NgayTruc, MaNV)
);

insert into ChiTietCaTruc values (1, '2022-04-21', 1);
insert into ChiTietCaTruc values (1, '2022-04-21', 2);
insert into ChiTietCaTruc values (1, '2022-04-21', 3);
insert into ChiTietCaTruc values (2, '2022-04-21', 1);
insert into ChiTietCaTruc values (3, '2022-04-21', 1);
insert into ChiTietCaTruc values (1, '2022-04-22', 1);


Create table DoanhThu(
MaCT int,
NgayTruc Date ,
DoanhThuCT bigint,
DoanhThuNT bigint
primary key (MaCT, NgayTruc)
);
insert into DoanhThu values (1, '2022-04-21', 200000, 600000);
insert into DoanhThu values (2, '2022-04-21', 200000, 600000);
insert into DoanhThu values (3, '2022-04-21', 200000, 600000);
insert into DoanhThu values (1, '2024-04-23', 200000, 400000);
insert into DoanhThu values (2, '2024-04-23', 200000, 400000);

Create table SanPham(
MaSP int primary key,
TenSP Nvarchar(255),
GiaSP Bigint,
LoaiSP Nvarchar(255),
NhomSP nvarchar(255),
DonViSP Nvarchar(20)
);
insert into SanPham values (1, N'Cà phê đen', 20000, N'Đồ uống',N'Cà phê','Ly');
insert into SanPham values (2, N'Cà phê sữa', 22000, N'Đồ uống',N'Cà phê','Ly');
insert into SanPham values (3, N'Trà thạch đào', 20000, N'Đồ uống',N'Trà','Ly');
insert into SanPham values (4, N'Trà thạch vải', 20000, N'Đồ uống',N'Trà','Ly');


Create table NguyenLieu(
MaNL int primary key,
TenNL Nvarchar(255),
SLTonKho int,
NgayHetHan Date,
GiaNhap Bigint,
DonViTinh Nvarchar(20),
);
insert into NguyenLieu values (1,N'Bột cà phê',  30, '2024-10-1', 4500000, N'Kg');
insert into NguyenLieu values (2,N'Sữa tươi', 10, '2024-05-01', 340000, N'Lít');
insert into NguyenLieu values (3, N'Trà xanh Thái Nguyên', 2, '2025-10-1', 670000, N'Kg');
insert into NguyenLieu values (4,N'Đường', 50, '2024-10-1', 600000, N'Kg');
insert into NguyenLieu values (5,N'Vải hộp', 10, '2024-10-1', 6000000, N'Hộp');
insert into NguyenLieu values (6,N'Đào hộp', 10, '2024-10-1', 6000000, N'Hộp');

create table ChiTietNguyenLieu(
MaNL int,
NgayNhap Date,
SLNhap int,
primary key (MaNL, NgayNhap)
);
insert into ChiTietNguyenLieu values (1,'2024-04-21',30);
insert into ChiTietNguyenLieu values (2,'2024-04-21',10);
insert into ChiTietNguyenLieu values (3,'2024-04-21',2);
insert into ChiTietNguyenLieu values (4,'2024-04-21',50);
insert into ChiTietNguyenLieu values (5,'2024-04-21',10);
insert into ChiTietNguyenLieu values (6,'2024-04-21',10);

Create table ChiTietSanPham(
MaSP int,
MaNL int,
SLNguyenLieu Decimal(6,3)
Primary key (MaSP, MaNL)
);

insert into ChiTietSanPham values (1, 1, 0.01);
insert into ChiTietSanPham values (2, 1, 0.01);
insert into ChiTietSanPham values (2,2, 0.05);
insert into ChiTietSanPham values (4, 3, 0.006);
insert into ChiTietSanPham values (4, 4, 0.1);
insert into ChiTietSanPham values (4, 5, 0.5);
insert into ChiTietSanPham values (3, 3, 0.006);
insert into ChiTietSanPham values (3, 4, 0.1);
insert into ChiTietSanPham values (3, 6, 0.5);


Create table Ban(
MaBan int primary key,
TrangThai NVarchar(255),
ViTri NVarchar(255)
);

insert into Ban values (1, N'Bàn trống', N'Tầng 1');
insert into Ban values (2, N'Bàn bận', N'Tầng 1');
insert into Ban values (3, N'Bàn đã được đặt trước', N'Tầng 1');
insert into Ban values (4, N'Bàn trống', N'Tầng 1');
insert into Ban values (5, N'Bàn bận', N'Tầng 1');
insert into Ban values (6, N'Bàn đã được đặt trước', N'Tầng 2');
insert into Ban values (7, N'Bàn trống', N'Tầng 2');
insert into Ban values (8, N'Bàn bận', N'Tầng 2');
insert into Ban values (9, N'Bàn đã được đặt trước', N'Tầng 2');

Create table KhuyenMai(
MaKM int primary key,
TenCT Nvarchar(255),
TGBatDau Date,
TGKetThuc Date,
MoTa NVarchar(255),
GiaTriKM decimal(3,2),
);

insert into KhuyenMai values (1, N'Tri ân khách hàng', '2024-01-01', '2024-12-31', N'Tri ân khách hàng thân thiết', 0.2);
insert into KhuyenMai values (2, N'Khách hàng mới', '2024-01-01', '2024-12-31', N'Khách hàng mới', 0.15);

Create table LoaiKhachHang(
MaLKH int primary key,
TenLKH Nvarchar(255),
);


insert into LoaiKhachHang values (1, N'Khách hàng thân thiết');
insert into LoaiKhachHang values (2, N'Khách hàng mới');
insert into LoaiKhachHang values (3, N'Khách hàng');

Create table ChiTietKhuyenMai(
MaKM int,
MaLKH int,
primary key (MaKM, MaLKH)
);
insert into ChiTietKhuyenMai values (1,1);
insert into ChiTietKhuyenMai values (2,2);

Create table KhachHang(
MaKH int primary key,
TenKH NVarchar(255),
SDT NVarchar(255),
MaLKH int
);
insert into KhachHang values (1,N'Đào Lê Hạnh Nguyên', '0123321777', 1);
insert into KhachHang values (2,N'Huỳnh Thúy Minh Nguyệt', '0775500744', 2);
insert into KhachHang values (3,N'Lê Xuân Hòa', '0123355777', 3);

create table DonHang (
MaDH int,
MaSP int,
SoLuongSP int
primary key (MaDH, MaSP)
);
insert into DonHang values (1, 1, 2);
insert into DonHang values (1,2,3);
insert into DonHang values (2,2,3);

create table HoaDon (
MaHD int primary key,
MaDH int,
MaKH int,
ThoiGian DateTime,
TongTien Bigint
);
insert into HoaDon values (1, 1, 1,'2024-04-21 08:30:00', 84800);
insert into HoaDon values (2, 2, 2,'2024-04-23 08:30:00', 56100);

Create table ChiTietHoaDon(
MaHD int,
MaBan int,
MaNV int,
MaSP int,
MaKM int,
SoLuongSP int,
primary key (MaHD, MaSP)
);

insert into ChiTietHoaDon values (1,3,4,1,1,2);
insert into ChiTietHoaDon values (1,3,4,2,1,3);
insert into ChiTietHoaDon values (2,6,6,2,2,3);

ALTER TABLE ChiTietCaTruc
ADD CONSTRAINT FK_ChiTietCaTruc_CaTruc
FOREIGN KEY (MaCT, NgayTruc)
REFERENCES CaTruc(MaCT, NgayTruc);

ALTER TABLE ChiTietCaTruc
ADD CONSTRAINT FK_ChiTietCaTruc_NhanVien
FOREIGN KEY (MaNV)
REFERENCES NhanVien(MaNV);

ALTER TABLE DoanhThu
ADD CONSTRAINT FK_DoanhThu_CaTruc
FOREIGN KEY (MaCT, NgayTruc)
REFERENCES CaTruc(MaCT, NgayTruc);

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_NhanVien
FOREIGN KEY (MaNV)
REFERENCES NhanVien(MaNV);

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_NhanVien
FOREIGN KEY (MaNV)
REFERENCES NhanVien(MaNV);

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon
FOREIGN KEY (MaHD)
REFERENCES HoaDon(MaHD);

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_SanPham
FOREIGN KEY (MaSP)
REFERENCES SanPham(MaSP);


ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_SanPham
FOREIGN KEY (MaSP)
REFERENCES SanPham(MaSP);

ALTER TABLE DonHang
ADD CONSTRAINT FK_DonHang_SanPham
FOREIGN KEY (MaSP)
REFERENCES SanPham(MaSP);

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_KhachHang
FOREIGN KEY (MaKH)
REFERENCES KhachHang(MaKH);


ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_NguyenLieu
FOREIGN KEY (MaNL)
REFERENCES NguyenLieu(MaNL);

ALTER TABLE ChiTietNguyenLieu
ADD CONSTRAINT FK_ChiTietNguyenLieu_NguyenLieu
FOREIGN KEY (MaNL)
REFERENCES NguyenLieu(MaNL);


ALTER TABLE ChiTietKhuyenMai
ADD CONSTRAINT FK_ChiTietKhuyenMai_KhuyenMai
FOREIGN KEY (MaKM)
REFERENCES KhuyenMai(MaKM);

ALTER TABLE ChiTietKhuyenMai
ADD CONSTRAINT FK_ChiTietKhuyenMai_LoaiKhachHang
FOREIGN KEY (MaLKH)
REFERENCES LoaiKhachHang(MaLKH);

ALTER TABLE KhachHang
ADD CONSTRAINT FK_KhachHang_LoaiKhachHang
FOREIGN KEY (MaLKH)
REFERENCES LoaiKhachHang(MaLKH);


ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_Ban
FOREIGN KEY (MaBan)
REFERENCES Ban(MaBan);

