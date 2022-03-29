USE [Tradingsystem]
GO
/****** Object:  Table [dbo].[Annex]    Script Date: 3/29/2022 10:42:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Annex](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaNhom] [nvarchar](255) NOT NULL,
	[NoiDung] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Annex] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Annex] ON 

INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (1, N'CA PHE TP', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (2, N'CA PHE TP', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (3, N'CA PHE TP', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (4, N'CA PHE TP', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (5, N'CA PHE TP', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (7, N'HAT TIEU', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (8, N'HAT TIEU', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (9, N'HAT TIEU', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (10, N'HAT TIEU', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (11, N'HAT TIEU', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (12, N'HAT DIEU TP', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (13, N'HAT DIEU TP', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (14, N'HAT DIEU TP', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (15, N'HAT DIEU TP', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (16, N'HAT DIEU TP', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (17, N'CA PHE XO', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (18, N'CA PHE XO', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (19, N'CA PHE XO', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (20, N'CA PHE XO', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (21, N'CA PHE XO', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (22, N'HAT DIEU THO', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (23, N'HAT DIEU THO', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (24, N'HAT DIEU THO', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (25, N'HAT DIEU THO', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (26, N'HAT DIEU THO', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (27, N'COM DUA', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (28, N'COM DUA', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (29, N'COM DUA', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (30, N'COM DUA', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (31, N'COM DUA', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (32, N'SAN', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (33, N'SAN', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (34, N'SAN', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (35, N'SAN', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (36, N'SAN', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (37, N'GAO TP', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (38, N'GAO TP', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (39, N'GAO TP', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (40, N'GAO TP', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (41, N'GAO TP', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (42, N'GAO PP', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (43, N'GAO PP', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (44, N'GAO PP', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (45, N'GAO PP', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (46, N'GAO XO', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (47, N'GAO XO', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (48, N'GAO XO', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (49, N'GAO XO', N'Điều 5: Điều khoản chung')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (50, N'GAO PP', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (51, N'GAO XO', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (52, N'CA PHE HOA TAN', N'Điều 1: Đơn giá - Giá trị hợp đồng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (53, N'CA PHE HOA TAN', N'Điều 2: Quy cách phẩm chất bao bì kiểm hàng')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (54, N'CA PHE HOA TAN', N'Điều 3: Phương thức thanh toán')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (55, N'CA PHE HOA TAN', N'Điều 4: Địa điểm thời gian giao hàng, vận chuyển và bốc xếp')
INSERT [dbo].[Annex] ([Id], [MaNhom], [NoiDung]) VALUES (56, N'CA PHE HOA TAN', N'Điều 5: Điều khoản chung')
SET IDENTITY_INSERT [dbo].[Annex] OFF
GO
