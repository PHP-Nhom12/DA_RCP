USE [master]
GO
/****** Object:  Database [QL_rap_chieu_phim]    Script Date: 11/17/2018 4:50:52 PM ******/
CREATE DATABASE [QL_rap_chieu_phim]
GO
ALTER DATABASE [QL_rap_chieu_phim] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_rap_chieu_phim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET  MULTI_USER 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_rap_chieu_phim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_rap_chieu_phim] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QL_rap_chieu_phim]
GO
/****** Object:  Table [dbo].[Ca]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ca](
	[MaCa] [int] NOT NULL,
	[TenCa] [nchar](10) NULL,
	[HeSo] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Ca] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietLichChieu]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietLichChieu](
	[MaLich] [int] NOT NULL,
	[MaPhim] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[MaCa] [int] NOT NULL,
	[ThoiGianBD] [nchar](10) NULL,
	[ThoiGianKT] [nchar](10) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ChiTietLichChieu] PRIMARY KEY CLUSTERED 
(
	[MaLich] ASC,
	[MaPhim] ASC,
	[MaPhong] ASC,
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTLoaiPhong]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTLoaiPhong](
	[Maloai] [int] NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[HeSo] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_CTLoaiPhong] PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoiVe]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiVe](
	[MaVeCu] [int] NOT NULL,
	[MaVeMoi] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[LiDo] [text] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_DoiVe] PRIMARY KEY CLUSTERED 
(
	[MaVeCu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ghe](
	[MaGhe] [char](10) NOT NULL,
	[MaPhong] [int] NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[MaGhe] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HuyVe]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HuyVe](
	[MaVe] [int] NOT NULL,
	[MaPhim] [char](10) NOT NULL,
	[MaLichChieu] [char](10) NOT NULL,
	[ThoiGian] [datetime] NULL,
	[LiDo] [nchar](10) NULL,
	[TongTien] [float] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HuyVe] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC,
	[MaPhim] ASC,
	[MaLichChieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichChieu]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieu](
	[MaLich] [int] NOT NULL,
	[NgayNhap] [datetime] NULL,
	[ThoiGian] [datetime] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_LichChieu] PRIMARY KEY CLUSTERED 
(
	[MaLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTV]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTV] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Luong]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaLuong] [int] NOT NULL,
	[NgayLam] [datetime] NULL,
	[GioVao] [datetime] NULL,
	[GioRa] [datetime] NULL,
	[LoaiCa] [int] NULL,
	[MaLoaiNV] [int] NULL,
	[LuongCB] [float] NULL,
	[HeSoPhatSinh] [float] NULL,
 CONSTRAINT [PK_Luong_1] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaLoaiNV]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaLoaiNV](
	[MaLoaiNV] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[HeSo] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_MaLoaiNV_1] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movie]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movie](
	[MaPhim] [int] NOT NULL,
	[TenPhim] [nvarchar](50) NULL,
	[NDPhim] [nvarchar](255) NULL,
	[TheLoai] [char](10) NULL,
	[Settime] [datetime] NULL,
	[Endtime] [datetime] NULL,
	[ThoiLuong] [int] NULL,
	[NamXS] [nchar](10) NULL,
	[DaoDien] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[NhaXS] [nvarchar](50) NULL,
	[Mac] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HovaTen] [nvarchar](max) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[NgayVaoLam] [date] NULL,
	[LoaiNV] [int] NULL,
	[MaLuong] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongChieu](
	[MaPhong] [int] NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [int] NULL,
	[SLCho] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_PhongChieu] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [char](10) NOT NULL,
	[MaNV] [int] NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaTV] [int] IDENTITY(1,1) NOT NULL,
	[TenTV] [nvarchar](50) NULL,
	[LoaiTV] [int] NULL,
	[CMND] [int] NULL,
	[NgaySinh] [datetime] NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [char](10) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [int] IDENTITY(1,1) NOT NULL,
	[MaPhim] [int] NOT NULL,
	[ViTriNgoi] [char](10) NULL,
	[PhongChieu] [int] NULL,
	[GiaVe] [int] NULL,
	[NgayTaoVe] [date] NULL,
	[MaVoucher] [int] NULL,
	[MaTV] [int] NULL,
	[MaLichChieu] [int] NULL,
	[TGBatDau] [nchar](10) NULL,
	[TGKetThuc] [nchar](10) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[MaVoucher] [int] NOT NULL,
	[TenVoucher] [nvarchar](50) NULL,
	[TiLe] [float] NULL,
	[NgayDung] [text] NULL,
	[HanSuDung] [date] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Voucher] PRIMARY KEY CLUSTERED 
(
	[MaVoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Voucher_ThanhVien]    Script Date: 11/17/2018 4:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher_ThanhVien](
	[MaTV] [int] NOT NULL,
	[MaVoucher] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_Voucher_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC,
	[MaVoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Ca] ([MaCa], [TenCa], [HeSo], [TrangThai]) VALUES (1, N'Sáng      ', 1.3, 1)
INSERT [dbo].[Ca] ([MaCa], [TenCa], [HeSo], [TrangThai]) VALUES (2, N'Chiều     ', 1.2, 1)
INSERT [dbo].[Ca] ([MaCa], [TenCa], [HeSo], [TrangThai]) VALUES (3, N'Tối       ', 1.5, 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 1, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 2, 2, 1, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 3, 3, 1, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 4, 4, 1, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 5, 5, 2, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 6, 6, 2, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 7, 1, 2, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 8, 2, 2, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 9, 3, 3, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 10, 4, 3, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 11, 5, 3, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (1, 12, 6, 3, N'22:00     ', N'24:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 1, 3, 3, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 2, 4, 3, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 3, 5, 3, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 4, 6, 3, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 13, 1, 1, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 14, 2, 1, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 15, 3, 1, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 16, 4, 1, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 17, 5, 2, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 18, 6, 2, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 19, 1, 2, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (2, 20, 2, 2, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 5, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 6, 2, 1, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 7, 3, 1, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 8, 4, 1, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 9, 5, 2, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 10, 6, 2, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 11, 1, 2, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 12, 2, 2, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 13, 3, 3, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 14, 4, 3, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 15, 5, 3, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (3, 16, 6, 3, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 1, 5, 2, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 2, 6, 2, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 3, 1, 2, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 4, 2, 2, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 5, 3, 3, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 6, 4, 3, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 7, 5, 3, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 8, 6, 3, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 17, 1, 1, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 18, 2, 1, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 19, 3, 1, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (4, 20, 4, 1, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 9, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 10, 2, 1, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 11, 3, 1, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 12, 4, 1, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 13, 5, 2, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 14, 6, 2, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 15, 1, 2, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 16, 2, 2, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 17, 3, 3, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 18, 4, 3, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 19, 5, 3, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (5, 20, 6, 3, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 1, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 2, 2, 1, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 3, 3, 1, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 4, 4, 1, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 5, 5, 2, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 6, 6, 2, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 7, 1, 2, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 8, 2, 2, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 9, 3, 3, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 10, 4, 3, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 11, 5, 3, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (6, 12, 6, 3, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 1, 3, 3, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 2, 4, 3, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 3, 5, 3, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 4, 6, 3, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 13, 1, 1, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 14, 2, 1, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 15, 3, 1, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 16, 4, 1, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 17, 5, 2, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 18, 6, 2, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 19, 1, 2, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (7, 20, 2, 2, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 5, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 6, 2, 1, N'9:00      ', N'11:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 7, 3, 1, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 8, 4, 1, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 9, 5, 2, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 10, 6, 2, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 11, 1, 2, N'17:00     ', N'19:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 12, 2, 2, N'18:00     ', N'20:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 13, 3, 3, N'19:00     ', N'21:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 14, 4, 3, N'20:00     ', N'22:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 15, 5, 3, N'21:00     ', N'23:00     ', 1)
INSERT [dbo].[ChiTietLichChieu] ([MaLich], [MaPhim], [MaPhong], [MaCa], [ThoiGianBD], [ThoiGianKT], [TrangThai]) VALUES (8, 16, 6, 3, N'22:00     ', N'00:00     ', 1)
INSERT [dbo].[CTLoaiPhong] ([Maloai], [TenPhong], [HeSo], [TrangThai]) VALUES (1, N'Phòng 2D', 1, 1)
INSERT [dbo].[CTLoaiPhong] ([Maloai], [TenPhong], [HeSo], [TrangThai]) VALUES (2, N'Phòng 3D', 1.5, 1)
INSERT [dbo].[CTLoaiPhong] ([Maloai], [TenPhong], [HeSo], [TrangThai]) VALUES (3, N'Phòng IMAX', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A1        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A10       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A100      ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A11       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A12       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A13       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A14       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A15       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A16       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A17       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A18       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A19       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A2        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A20       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A21       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 1, 1)
GO
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A22       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A23       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A24       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A25       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A26       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A27       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A28       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A29       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A3        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A30       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A31       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A32       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A33       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A34       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 3, 1)
GO
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A35       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A36       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A37       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A38       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A39       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A4        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A40       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A41       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A42       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A43       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A44       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A45       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A46       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A47       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 5, 1)
GO
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A48       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A49       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A5        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A50       ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A51       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A51       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A51       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A52       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A52       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A52       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A53       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A53       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A53       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A54       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A54       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A54       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A55       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A55       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A55       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A56       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A56       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A56       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A57       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A57       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A57       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A58       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A58       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A58       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A59       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A59       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A59       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A6        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A60       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A60       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A60       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A61       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A61       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A61       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A62       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A62       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A62       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A63       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A63       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A63       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A64       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A64       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A64       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A65       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A65       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A65       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A66       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A66       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A66       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A67       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A67       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A67       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A68       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A68       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A68       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A69       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A69       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A69       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A7        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A70       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A70       ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A70       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A71       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A72       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A73       ', 4, 1)
GO
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A74       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A75       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A76       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A77       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A78       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A79       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A8        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A80       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A81       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A82       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A83       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A84       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A85       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A86       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A87       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A88       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A89       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 2, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 3, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 5, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 6, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A9        ', 7, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A90       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A91       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A92       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A93       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A94       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A95       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A96       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A97       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A98       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'A99       ', 4, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B1        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B10       ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B2        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B3        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B4        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B5        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B6        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B7        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B8        ', 1, 1)
INSERT [dbo].[Ghe] ([MaGhe], [MaPhong], [TrangThai]) VALUES (N'B9        ', 1, 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (1, CAST(N'2018-04-04 00:00:00.000' AS DateTime), CAST(N'2018-11-13 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (2, CAST(N'2018-11-14 00:00:00.000' AS DateTime), CAST(N'2018-11-14 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (3, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (4, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-16 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (5, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-17 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (6, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-18 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (7, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-19 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[LichChieu] ([MaLich], [NgayNhap], [ThoiGian], [TrangThai]) VALUES (8, CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-11-20 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[LoaiTV] ON 

INSERT [dbo].[LoaiTV] ([ID], [MaLoai], [TenLoai]) VALUES (1, 1, N'Vip')
INSERT [dbo].[LoaiTV] ([ID], [MaLoai], [TenLoai]) VALUES (2, 2, N'Hội Viên')
INSERT [dbo].[LoaiTV] ([ID], [MaLoai], [TenLoai]) VALUES (3, 3, N'HSSV')
SET IDENTITY_INSERT [dbo].[LoaiTV] OFF
INSERT [dbo].[Luong] ([MaLuong], [NgayLam], [GioVao], [GioRa], [LoaiCa], [MaLoaiNV], [LuongCB], [HeSoPhatSinh]) VALUES (1, CAST(N'2017-02-04 00:00:00.000' AS DateTime), CAST(N'2018-10-23 06:00:00.000' AS DateTime), CAST(N'2018-10-23 14:00:00.000' AS DateTime), 1, 2, 500000, 3)
INSERT [dbo].[Luong] ([MaLuong], [NgayLam], [GioVao], [GioRa], [LoaiCa], [MaLoaiNV], [LuongCB], [HeSoPhatSinh]) VALUES (2, CAST(N'2017-03-04 00:00:00.000' AS DateTime), CAST(N'2017-05-05 00:00:00.000' AS DateTime), CAST(N'2017-03-01 00:00:00.000' AS DateTime), 2, 3, 400000, 3)
INSERT [dbo].[MaLoaiNV] ([MaLoaiNV], [TenLoai], [HeSo], [TrangThai]) VALUES (1, N'Admin', 1, 0)
INSERT [dbo].[MaLoaiNV] ([MaLoaiNV], [TenLoai], [HeSo], [TrangThai]) VALUES (2, N'Nhân Viên Bán Vé', 1.2, 0)
INSERT [dbo].[MaLoaiNV] ([MaLoaiNV], [TenLoai], [HeSo], [TrangThai]) VALUES (3, N'Nhân Viên Phòng', 1.2, 0)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (1, N'Dạ Quỷ', N'Chưa coi phim này :D', N'2         ', CAST(N'2018-04-04 00:00:00.000' AS DateTime), CAST(N'2018-04-14 00:00:00.000' AS DateTime), 100, N'2018      ', N'TPhong', NULL, N'Phong', N'18+', CAST(N'2018-04-04 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (2, N'Avengers: Infinity Wars', N'Thanos hấp diêm 1 nửa Biệt Đội Siêu Anh Hùng', N'1         ', CAST(N'2018-04-04 00:00:00.000' AS DateTime), CAST(N'2018-04-14 00:00:00.000' AS DateTime), 120, N'2017      ', N'HTien', NULL, N'HTien', N'16+', CAST(N'2018-11-14 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (3, N'Fantastic Beast', N'Quái vật cực đẹp', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-12-31 00:00:00.000' AS DateTime), 90, N'2018      ', N'MyDuyen', NULL, N'MyDuyen', N'16+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (4, N'Người Bất Tử', N'Chơi ngải cực mạnh', N'3         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-12-31 00:00:00.000' AS DateTime), 103, N'2018      ', N'Victor Vũ', NULL, N'CGV Entertainment', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (5, N'Nhiệm Vụ Bất Khả Thi', N'Tom Cruise đánh nhau cực mạnh', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-12-31 00:00:00.000' AS DateTime), 90, N'2018      ', N'Christopher McQuarrie', NULL, N'Mỹ', N'16+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (6, N'Ngôi Nhà Ma Ám', N'Má ám gì gì dó', N'5         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2018-12-31 00:00:00.000' AS DateTime), 89, N'2017      ', N'Rich Ragsdale', NULL, N'KNR Productions', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (7, N'Quái Thú Vô Hình', N'Quái vật ngoài hành tinh xuống thăm trái đất :D', N'8         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 107, N'2018      ', N'Shane Black', N'', N'Mỹ', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (8, N'Cá Mập Siêu Bạo Chúa', N'Cá mập bự nhất thế giới :3', N'8         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 90, N'2018      ', N'Jon Turtletaub', NULL, N'Mỹ, Trung Quốc', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (9, N'Cô Ba Sì Gòn', N'Phim hay quá chời quá đất :D', N'3         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 100, N'2017      ', N'Kay Trần, Trần Bửu Lộc', NULL, N'Việt Nam', N'P', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (10, N'Ác Quỷ Ma Sơ', N'Valak hù ma cực mạnh', N'5         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 90, N'2018      ', N'Corin Hardy', NULL, N'Mỹ', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (11, N'Quái Vật Godzilla', N'Godzilla là bạn, không phải quái vật', N'8         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 120, N'2018      ', N'Gareth Edwards', NULL, N'Warner Bros', N'16+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (12, N'Cuộc Đàm Phán Sinh Tử', N'Chị cảnh sát xinh lắm :D', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 113, N'2018      ', N'Lee Jong-Suk', NULL, N'Hàn Quốc', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (13, N'Con Nhà Siêu Giàu Châu Á', N'Ước gì :D', N'3         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 119, N'2018      ', N'Jon M. Chu', NULL, N'Mỹ', N'P', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (14, N'Thiện Ác Đối Đầu', N'Đập nhau cực mạnh !!!', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 121, N'2018      ', N'Antoine Fuqua', NULL, N'Mỹ', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (15, N'Bạn Ma Phiền Toái', N'Phim hài cực mạnh :D', N'4         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 114, N'2018      ', N'Jo Won-Hee', NULL, N'Hàn Quốc', N'P', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (16, N'Johnny English 3: Tái Xuất', N'Mr.Bean trở lại và lợi hại cực bội', N'4         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 90, N'2017      ', N'David Kerr', NULL, N'Mỹ', N'P', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (17, N'Quái Vật Venom', N'Spider Man phiên bản cực ngầu :D', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 120, N'2018      ', N'Đang cập nhật', NULL, N'Mỹ', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (18, N'Doctor Strange', N'How to từ bác sĩ trở thành phù thủy :D', N'1         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 90, N'2018      ', N'Stan Lee', NULL, N'Mỹ', N'16+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (19, N'Xác Ướp', N'The Sexiest Mummy ever :v', N'8         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 90, N'2018      ', N'Alex Kurtzman', NULL, N'Mỹ', N'18+', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Movie] ([MaPhim], [TenPhim], [NDPhim], [TheLoai], [Settime], [Endtime], [ThoiLuong], [NamXS], [DaoDien], [HinhAnh], [NhaXS], [Mac], [NgayNhap], [TrangThai]) VALUES (20, N'Người Đẹp Và Quái Vật', N'Phim gì hát hò miết', N'2         ', CAST(N'2018-11-15 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), 129, N'2017      ', N'Bill Condon', NULL, N'Disney', N'P', CAST(N'2018-11-15 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (1, N'Ngô Trần Tuấn Phong', CAST(N'1998-02-04' AS Date), N'Nam       ', N'Bến Tre', N'phongngo@gmail.com', N'202cb962ac59075b964b07152d234b70', N'D:\RapChieuPhim\DA_RapChieuPhim\DA_RapChieuPhim\bin\Debug\Dữ Liệu\o.jpg', CAST(N'2017-03-04' AS Date), 2, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (2, N'Nguyễn Hữu Tiền', CAST(N'1998-03-04' AS Date), N'Nam       ', N'TP.HCM', N'T1', N'c20ad4d76fe97759aa27a0c99bff6710', N'D:\RapChieuPhim\DA_RapChieuPhim\DA_RapChieuPhim\bin\Debug\Dữ Liệu\o.jpg', CAST(N'2017-03-05' AS Date), 3, 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (3, N'Trần Hà Mỹ Duyên', CAST(N'1998-02-04' AS Date), N'Nữ        ', N'Bến Tre', N't2', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-10-31' AS Date), 2, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (4, N'Nguyễn Hữu Phước', CAST(N'1998-09-29' AS Date), N'Nam       ', N'Bến Tre', N't3', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-13' AS Date), 2, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (5, N'Nguyễn Huỳnh Anh Tuấn', CAST(N'1998-01-24' AS Date), N'Nam       ', N'Bến Tre', N't4@gmail.com', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-05' AS Date), 2, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (6, N'Nguyễn Minh Trung', CAST(N'1998-01-26' AS Date), N'Nam       ', N'VT', N't5', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-14' AS Date), 2, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (7, N'Trần Thế Nguyên', CAST(N'2018-02-03' AS Date), N'Nam       ', N'LA', N't6', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-06' AS Date), 2, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (8, N'a', CAST(N'2018-11-06' AS Date), N'Nam       ', N'Bến Tre', N'T7', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-21' AS Date), 2, 2, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (9, N'Nguyễn Thị A', CAST(N'2018-11-13' AS Date), N'Nữ        ', N'Bến Tre', N'a@gmail.com', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-12' AS Date), 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (10, N'b', CAST(N'2018-11-06' AS Date), N'Nữ        ', N'Bến Tre', N't9', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-14' AS Date), 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (11, N'b', CAST(N'2018-11-06' AS Date), N'Nữ        ', N'Bến Tre', N't9', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-14' AS Date), 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (12, N'Nguyễn Hữu Tiền C', CAST(N'2018-11-13' AS Date), N'Nam       ', N'B?n Tre', N'T10', N'4297f44b13955235245b2497399d7a93', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-20' AS Date), 3, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HovaTen], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Password], [HinhAnh], [NgayVaoLam], [LoaiNV], [MaLuong], [TrangThai]) VALUES (13, N'Hiền', CAST(N'2018-05-17' AS Date), N'Nữ        ', N'HCM', N'hien.le@gmail.com', N'202cb962ac59075b964b07152d234b70', N'D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/.png', CAST(N'2018-11-16' AS Date), 2, 2, 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (1, N'Phòng Số 1', 2, 70, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (2, N'Phòng Số 2', 2, 70, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (3, N'Phòng Số 3', 3, 50, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (4, N'Phòng Số 4', 1, 100, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (5, N'Phòng Số 5', 3, 50, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (6, N'Phòng Số 6', 3, 50, 1)
INSERT [dbo].[PhongChieu] ([MaPhong], [TenPhong], [LoaiPhong], [SLCho], [TrangThai]) VALUES (7, N'Phòng Số 7', 3, 50, 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [HinhAnh], [Password], [TrangThai]) VALUES (N'1         ', 1, N'D:\RapChieuPhim\RapChieuPhim\img\Dữ Liệu', N'123465', 1)
SET IDENTITY_INSERT [dbo].[ThanhVien] ON 

INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (1, N'Ngô Trần Tuấn Phong', 1, 3013456, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (4, N'Nguyễn Hữu Tiền', 2, 561315, CAST(N'2018-02-02 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (5, N'Trần Hà Mỹ Duyên', 1, 5615618, CAST(N'2018-03-03 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (9, N'Nguyễn Hữu Phước', 1, 123165, CAST(N'2018-03-02 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (11, N'123', 1, 7899, CAST(N'2018-10-29 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (12, N'ferere', 3, 46465, CAST(N'2018-10-29 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThanhVien] ([MaTV], [TenTV], [LoaiTV], [CMND], [NgaySinh], [TrangThai]) VALUES (13, N'phongggg', 1, 3213213, CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ThanhVien] OFF
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'1         ', N'Hành Động')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'10        ', N'Tài Liệu')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'2         ', N'Cổ Trang')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'3         ', N'Tình Cảm')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'4         ', N'Hài')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'5         ', N'Kinh Dị')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'6         ', N'Hoạt Hình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'7         ', N'Phiêu Lưu')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'8         ', N'Viễn Tưởng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'9         ', N'Khoa Học')
SET IDENTITY_INSERT [dbo].[Ve] ON 

INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (3, 1, N'A10       ', 1, 50000, CAST(N'2018-01-01' AS Date), 1, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (5, 1, N'A1        ', 1, 50000, CAST(N'2018-11-16' AS Date), 2, 1, 1, N'8:00      ', N'10:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (7, 2, N'A100      ', 4, 19500, CAST(N'2018-11-16' AS Date), 1, 4, 4, N'10:00     ', N'12:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (8, 10, N'A15       ', 6, 22500, CAST(N'2018-11-16' AS Date), 1, 1, 4, N'11:00     ', N'13:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (9, 19, N'A13       ', 3, 30000, CAST(N'2018-11-16' AS Date), 2, 1, 4, N'15:00     ', N'17:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (10, 3, N'A29       ', 5, 19500, CAST(N'2018-11-16' AS Date), 1, 1, 5, N'16:00     ', N'18:00     ', 1)
INSERT [dbo].[Ve] ([MaVe], [MaPhim], [ViTriNgoi], [PhongChieu], [GiaVe], [NgayTaoVe], [MaVoucher], [MaTV], [MaLichChieu], [TGBatDau], [TGKetThuc], [TrangThai]) VALUES (11, 10, N'A11       ', 6, 37500, CAST(N'2018-11-16' AS Date), 2, 1, 4, N'11:00     ', N'13:00     ', 1)
SET IDENTITY_INSERT [dbo].[Ve] OFF
INSERT [dbo].[Voucher] ([MaVoucher], [TenVoucher], [TiLe], [NgayDung], [HanSuDung], [TrangThai]) VALUES (1, N'Nhà Giáo Việt Nam', 30, N'', CAST(N'2018-12-31' AS Date), 1)
INSERT [dbo].[Voucher] ([MaVoucher], [TenVoucher], [TiLe], [NgayDung], [HanSuDung], [TrangThai]) VALUES (2, N'Siêu Khuyến Mãi', 50, NULL, CAST(N'2018-12-31' AS Date), 1)
INSERT [dbo].[Voucher] ([MaVoucher], [TenVoucher], [TiLe], [NgayDung], [HanSuDung], [TrangThai]) VALUES (3, N'Mua 1 Tặng 1', 100, NULL, CAST(N'2018-12-31' AS Date), 1)
INSERT [dbo].[Voucher_ThanhVien] ([MaTV], [MaVoucher], [SoLuong], [TrangThai]) VALUES (1, 1, NULL, 1)
INSERT [dbo].[Voucher_ThanhVien] ([MaTV], [MaVoucher], [SoLuong], [TrangThai]) VALUES (1, 2, NULL, 1)
INSERT [dbo].[Voucher_ThanhVien] ([MaTV], [MaVoucher], [SoLuong], [TrangThai]) VALUES (4, 1, NULL, 1)
ALTER TABLE [dbo].[ChiTietLichChieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLichChieu_Ca] FOREIGN KEY([MaCa])
REFERENCES [dbo].[Ca] ([MaCa])
GO
ALTER TABLE [dbo].[ChiTietLichChieu] CHECK CONSTRAINT [FK_ChiTietLichChieu_Ca]
GO
ALTER TABLE [dbo].[ChiTietLichChieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLichChieu_LichChieu] FOREIGN KEY([MaLich])
REFERENCES [dbo].[LichChieu] ([MaLich])
GO
ALTER TABLE [dbo].[ChiTietLichChieu] CHECK CONSTRAINT [FK_ChiTietLichChieu_LichChieu]
GO
ALTER TABLE [dbo].[ChiTietLichChieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLichChieu_Movie] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Movie] ([MaPhim])
GO
ALTER TABLE [dbo].[ChiTietLichChieu] CHECK CONSTRAINT [FK_ChiTietLichChieu_Movie]
GO
ALTER TABLE [dbo].[ChiTietLichChieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLichChieu_PhongChieu] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongChieu] ([MaPhong])
GO
ALTER TABLE [dbo].[ChiTietLichChieu] CHECK CONSTRAINT [FK_ChiTietLichChieu_PhongChieu]
GO
ALTER TABLE [dbo].[DoiVe]  WITH CHECK ADD  CONSTRAINT [FK_DoiVe_Ve] FOREIGN KEY([MaVeMoi])
REFERENCES [dbo].[Ve] ([MaVe])
GO
ALTER TABLE [dbo].[DoiVe] CHECK CONSTRAINT [FK_DoiVe_Ve]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [FK_Ghe_PhongChieu] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongChieu] ([MaPhong])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [FK_Ghe_PhongChieu]
GO
ALTER TABLE [dbo].[HuyVe]  WITH CHECK ADD  CONSTRAINT [FK_HuyVe_DoiVe] FOREIGN KEY([MaVe])
REFERENCES [dbo].[DoiVe] ([MaVeCu])
GO
ALTER TABLE [dbo].[HuyVe] CHECK CONSTRAINT [FK_HuyVe_DoiVe]
GO
ALTER TABLE [dbo].[HuyVe]  WITH CHECK ADD  CONSTRAINT [FK_HuyVe_Ve] FOREIGN KEY([MaVe])
REFERENCES [dbo].[Ve] ([MaVe])
GO
ALTER TABLE [dbo].[HuyVe] CHECK CONSTRAINT [FK_HuyVe_Ve]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Luong] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[Luong] ([MaLuong])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Luong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaLoaiNV] FOREIGN KEY([LoaiNV])
REFERENCES [dbo].[MaLoaiNV] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaLoaiNV]
GO
ALTER TABLE [dbo].[PhongChieu]  WITH CHECK ADD  CONSTRAINT [FK_PhongChieu_CTLoaiPhong] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[CTLoaiPhong] ([Maloai])
GO
ALTER TABLE [dbo].[PhongChieu] CHECK CONSTRAINT [FK_PhongChieu_CTLoaiPhong]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_LoaiTV1] FOREIGN KEY([LoaiTV])
REFERENCES [dbo].[LoaiTV] ([MaLoai])
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [FK_ThanhVien_LoaiTV1]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Ghe] FOREIGN KEY([ViTriNgoi], [PhongChieu])
REFERENCES [dbo].[Ghe] ([MaGhe], [MaPhong])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Ghe]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_LichChieu] FOREIGN KEY([MaLichChieu])
REFERENCES [dbo].[LichChieu] ([MaLich])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_LichChieu]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Movie] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Movie] ([MaPhim])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Movie]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_ThanhVien] FOREIGN KEY([MaTV])
REFERENCES [dbo].[ThanhVien] ([MaTV])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_ThanhVien]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_ThanhVien1] FOREIGN KEY([MaTV])
REFERENCES [dbo].[ThanhVien] ([MaTV])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_ThanhVien1]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_Voucher1] FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[Voucher] ([MaVoucher])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_Voucher1]
GO
ALTER TABLE [dbo].[Voucher_ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_ThanhVien_ThanhVien] FOREIGN KEY([MaTV])
REFERENCES [dbo].[ThanhVien] ([MaTV])
GO
ALTER TABLE [dbo].[Voucher_ThanhVien] CHECK CONSTRAINT [FK_Voucher_ThanhVien_ThanhVien]
GO
ALTER TABLE [dbo].[Voucher_ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_ThanhVien_Voucher] FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[Voucher] ([MaVoucher])
GO
ALTER TABLE [dbo].[Voucher_ThanhVien] CHECK CONSTRAINT [FK_Voucher_ThanhVien_Voucher]
GO
USE [master]
GO
ALTER DATABASE [QL_rap_chieu_phim] SET  READ_WRITE 
GO
