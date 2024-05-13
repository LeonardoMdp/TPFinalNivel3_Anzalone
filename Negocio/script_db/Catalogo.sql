USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 6 may. 2024 18:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Precio] [money] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 6 may. 2024 18:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favoritos]    Script Date: 6 may. 2024 18:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favoritos](
	[IdUsuario] [int] NULL,
	[IdArticulo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 6 may. 2024 18:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6 may. 2024 18:18:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Pass] [varchar](50) NULL,
	[TipoUser] [int] NULL,
	[Email] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechadeNacimiento] [smalldatetime] NULL,
	[ImagenDePerfil] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ARTICULOS] ON 

INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1053, N'm20', N'Twenty One Pilots', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211142&authkey=%21AM_5yNItI7mqMBg&width=1440&height=1920', 10000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1054, N'mdeath', N'Megadeth', N'Remera Agodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211141&authkey=%21ADLbNbU_gYNvFvU&width=1440&height=1920', 20000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1055, N'macdc', N'AcDc', N'Remera Agodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211143&authkey=%21ANAsWxSWM0If-10&width=1440&height=1920', 20000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1056, N'ledzp', N'Led Zeppelin', N'Remera Agodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211145&authkey=%21ALsjv-3GndlRXt4&width=1440&height=1920', 30000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1057, N'mbea', N'The Beatles ', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211144&authkey=%21AL6kk4GeJy9yhcc&width=1440&height=1920', 30000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1058, N'afd', N'Guns - Appetite For Destruction', N'Remera Algodon Clasico', 2, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211146&authkey=%21AEohHjk2YucF5uI&width=1440&height=1920', 40000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1059, N'msla', N'Slayer', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211147&authkey=%21ACqkT0h9zC4hDhQ&width=1440&height=1920', 40000.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1060, N'g01', N'Guns Logo', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211148&authkey=%21AHGHmLKh4hjgzc0&width=1440&height=1920', 15200.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1061, N'G03', N'Guns Logo Bateria', N'remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211149&authkey=%21AGcIlGMK9IWC6tg&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1062, N'mcrue', N'Motley Crue', N'remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211150&authkey=%21AIg0mIHhnryZnOw&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1063, N'mram', N'Ramstein', N'Remera Agodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211151&authkey=%21AGoEKKn8-0ag0KQ&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1064, N'r01', N'Red Hot Chili Pappers', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211152&authkey=%21AFZoLtR92Qswp8Y&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1067, N'm666', N'Megadeth Rip', N'Remera Algodon Clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211154&authkey=%21AK0ZjHNXdBuWHbs&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1069, N'm4321', N'remera Sex Pistols', N'Remera algodon clasico', 1, 1, N'https://onedrive.live.com/embed?resid=76F7CBF19E31A865%211186&authkey=%21AKcKd5B_wl4kgrI&width=1440&height=1920', 15200.0000, 1)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1071, N'', N'', N'', 1, 1, N'', 15200.0000, NULL)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio], [Activo]) VALUES (1073, N'', N'cerati', N'', 1, 1, N'', 15200.0000, NULL)
SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
GO
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON 

INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (1, N'Remeras')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (2, N'Buzos')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (3, N'Camperas')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (4, N'Jeans')
SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
GO
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (2, 1064)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (2, 1063)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (2, 1062)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (1, 1060)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (1, 1058)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (1, 1059)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (2, 1056)
INSERT [dbo].[Favoritos] ([IdUsuario], [IdArticulo]) VALUES (2, 1069)
GO
SET IDENTITY_INSERT [dbo].[MARCAS] ON 

INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (1, N'S')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (2, N'M')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (3, N'L')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (4, N'XL')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (5, N'XXL')
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (1, N'test', N'test', 1, N'test@test.com', N'Muntz', CAST(N'1977-10-18T00:00:00' AS SmallDateTime), N'perfil-1.jpg')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (2, N'admin', N'admin', 2, N'admin@admin.com', N'Anzalone', CAST(N'1980-10-18T00:00:00' AS SmallDateTime), N'perfil-2.jpg')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (3, NULL, N'1234', 0, N'ass@sd.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (4, NULL, N'333', 0, N'bbb@sd.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (5, NULL, N'pepepass', 0, N'pepe@daadas.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (6, NULL, N'123', 0, N'fidelios.fide@gmail.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (7, NULL, N'lalalala', 0, N'lalalala@lalalala.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (8, NULL, N'lele', 0, N'lele@lele.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (9, NULL, N'6666', 0, N'mamama@sd.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (10, NULL, N'nelson', 0, N'nelson@nelson.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (11, N'', N'osos', 0, N'osos@asdj.com', N'', NULL, N'perfil-11.jpg')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (12, NULL, N'papas', 0, N'papas@dafsf.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (13, NULL, N'asd', 0, N'', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (14, NULL, N'fg', 0, N'', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (15, NULL, N'24', 0, N'', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (16, NULL, N'csdf', 0, N'', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (17, NULL, N'sdf', 0, N'', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (18, NULL, N'asd', 0, N'asd@asd.com', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Pass], [TipoUser], [Email], [Apellido], [FechadeNacimiento], [ImagenDePerfil]) VALUES (19, N'qwe', N'qwe', 0, N'qwe@sda.com', N'qweqwe', CAST(N'1980-01-01T00:00:00' AS SmallDateTime), N'perfil-19.jpg')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
/****** Object:  StoredProcedure [dbo].[insertarNuevo]    Script Date: 6 may. 2024 18:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[insertarNuevo]

@email varchar(50),
@pass varchar(50)

as

insert into Usuarios (Email, Pass, TipoUser) output inserted.Id values (@email, @pass, 0)
GO
/****** Object:  StoredProcedure [dbo].[ModificarconSp]    Script Date: 6 may. 2024 18:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[ModificarconSp]
@codigo varchar (50),
@nombre varchar(50),
@descripcion varchar (150),
@IdMarca int,
@IdCategoria int,
@ImagenUrl varchar (1000),
@Precio money,
@id int

as


update ARTICULOS set Codigo = @codigo, Nombre=@nombre, Descripcion=@descripcion, IdMarca= @IdMarca, 
IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl , Precio = @Precio where Id = @id
GO
/****** Object:  StoredProcedure [dbo].[SpaltaProducto]    Script Date: 6 may. 2024 18:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpaltaProducto]
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(150),
@idmarca int,
@idcategoria int,
@imagenurl varchar(100),
@precio money

as
insert ARTICULOS  values (@codigo , @nombre,@descripcion, @idmarca ,@idcategoria ,@imagenurl,@precio)
GO
