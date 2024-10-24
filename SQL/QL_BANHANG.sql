USE [QUAN_LY_BAN_HANG]
GO
/****** Object:  Table [dbo].[DANG_NHAP]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANG_NHAP](
	[user_ma] [varchar](10) NOT NULL,
	[user_hoten] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DANG_NHAP] PRIMARY KEY CLUSTERED 
(
	[user_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANH_MUC]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANH_MUC](
	[dm_ma] [varchar](10) NOT NULL,
	[dm_ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DANH_MUC] PRIMARY KEY CLUSTERED 
(
	[dm_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DAT_HANG]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAT_HANG](
	[dh_ma] [varchar](10) NOT NULL,
	[kh_ma] [varchar](10) NOT NULL,
	[dh_ngay] [date] NOT NULL,
	[dh_gio] [time](3) NOT NULL,
	[trangthai] [varchar](20) NULL,
 CONSTRAINT [PK_DAT_HANG] PRIMARY KEY CLUSTERED 
(
	[dh_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DON_CHUA_HANG]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DON_CHUA_HANG](
	[dh_ma] [varchar](10) NOT NULL,
	[sp_ma] [varchar](10) NOT NULL,
	[soluong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[hd_ma] [varchar](10) NOT NULL,
	[dh_ma] [varchar](10) NOT NULL,
	[kh_ma] [varchar](10) NOT NULL,
	[hd_ngay] [date] NOT NULL,
	[tongtien] [decimal](19, 4) NOT NULL,
	[phuongthucthanhtoan] [nvarchar](50) NOT NULL,
	[nv_ma] [varchar](10) NOT NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
	[trangthai] [varchar](50) NULL,
 CONSTRAINT [PK_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[hd_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[kh_ma] [varchar](10) NOT NULL,
	[kh_ten] [nvarchar](50) NOT NULL,
	[gioitinh] [nvarchar](50) NOT NULL,
	[kh_sdt] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KHACH_HANG] PRIMARY KEY CLUSTERED 
(
	[kh_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[nv_ma] [varchar](10) NOT NULL,
	[nv_hoten] [nvarchar](50) NOT NULL,
	[nv_sdt] [nvarchar](50) NOT NULL,
	[nv_gioitinh] [nvarchar](50) NOT NULL,
	[nv_diachi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[nv_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 24/10/2024 9:35:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[sp_ma] [varchar](10) NOT NULL,
	[dm_ma] [varchar](10) NOT NULL,
	[sp_ten] [nvarchar](50) NOT NULL,
	[kichthuoc] [nvarchar](50) NOT NULL,
	[sp_gia] [money] NOT NULL,
	[sp_gioitinh] [nvarchar](50) NOT NULL,
	[soluongton] [int] NULL,
	[sp_anh] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_SAN_PHAM_1] PRIMARY KEY CLUSTERED 
(
	[sp_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[DAT_HANG] ADD  DEFAULT ('Pending') FOR [trangthai]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ('Pending') FOR [trangthai]
GO
ALTER TABLE [dbo].[DANG_NHAP]  WITH CHECK ADD FOREIGN KEY([user_ma])
REFERENCES [dbo].[NHAN_VIEN] ([nv_ma])
GO
ALTER TABLE [dbo].[DAT_HANG]  WITH CHECK ADD  CONSTRAINT [fk_dat_hang_khach_hang] FOREIGN KEY([kh_ma])
REFERENCES [dbo].[KHACH_HANG] ([kh_ma])
GO
ALTER TABLE [dbo].[DAT_HANG] CHECK CONSTRAINT [fk_dat_hang_khach_hang]
GO
ALTER TABLE [dbo].[DON_CHUA_HANG]  WITH CHECK ADD  CONSTRAINT [fk_don_chua_hang_dat_hang] FOREIGN KEY([dh_ma])
REFERENCES [dbo].[DAT_HANG] ([dh_ma])
GO
ALTER TABLE [dbo].[DON_CHUA_HANG] CHECK CONSTRAINT [fk_don_chua_hang_dat_hang]
GO
ALTER TABLE [dbo].[DON_CHUA_HANG]  WITH CHECK ADD  CONSTRAINT [fk_don_chua_hang_san_pham] FOREIGN KEY([sp_ma])
REFERENCES [dbo].[SAN_PHAM] ([sp_ma])
GO
ALTER TABLE [dbo].[DON_CHUA_HANG] CHECK CONSTRAINT [fk_don_chua_hang_san_pham]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [fk_hoa_don_khach_hang] FOREIGN KEY([kh_ma])
REFERENCES [dbo].[KHACH_HANG] ([kh_ma])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [fk_hoa_don_khach_hang]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [fk_hoa_don_nhan_vien] FOREIGN KEY([nv_ma])
REFERENCES [dbo].[NHAN_VIEN] ([nv_ma])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [fk_hoa_don_nhan_vien]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_SAN_PHAM_DANH_MUC] FOREIGN KEY([dm_ma])
REFERENCES [dbo].[DANH_MUC] ([dm_ma])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [FK_SAN_PHAM_DANH_MUC]
GO
