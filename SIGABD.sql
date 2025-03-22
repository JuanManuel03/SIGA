USE [master]
GO
/****** Object:  Database [siga]    Script Date: 21/03/2025 9:55:49 p. m. ******/
CREATE DATABASE [siga]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'siga', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.DIOUSEKSQL\MSSQL\DATA\siga.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'siga_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.DIOUSEKSQL\MSSQL\DATA\siga_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [siga] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [siga].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [siga] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [siga] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [siga] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [siga] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [siga] SET ARITHABORT OFF 
GO
ALTER DATABASE [siga] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [siga] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [siga] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [siga] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [siga] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [siga] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [siga] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [siga] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [siga] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [siga] SET  ENABLE_BROKER 
GO
ALTER DATABASE [siga] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [siga] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [siga] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [siga] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [siga] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [siga] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [siga] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [siga] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [siga] SET  MULTI_USER 
GO
ALTER DATABASE [siga] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [siga] SET DB_CHAINING OFF 
GO
ALTER DATABASE [siga] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [siga] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [siga] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [siga] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [siga] SET QUERY_STORE = ON
GO
ALTER DATABASE [siga] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [siga]
GO
/****** Object:  Table [dbo].[admins]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[Id_adm] [int] NOT NULL,
	[Descrip] [varchar](100) NULL,
	[Id_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_adm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[asignatura]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignatura](
	[Id_asig] [int] NOT NULL,
	[Nomb_asig] [varchar](20) NOT NULL,
	[Id_curso] [int] NULL,
	[Id_pro] [int] NULL,
	[Id_hor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_asig] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cursos]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cursos](
	[Id_curso] [int] NOT NULL,
	[Nomb_cur] [varchar](30) NOT NULL,
	[Tiem_cur] [varchar](30) NOT NULL,
	[Precio] [bigint] NOT NULL,
	[Id_adm] [int] NULL,
	[Id_inscrip] [int] NULL,
	[Id_usuario] [int] NULL,
	[Id_pro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estud]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estud](
	[Id_inscrip] [int] NOT NULL,
	[Descrip] [varchar](100) NULL,
	[Salon] [int] NOT NULL,
	[Id_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_inscrip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horarios]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horarios](
	[Id_hor] [int] NOT NULL,
	[Hora] [varchar](20) NULL,
	[Dia] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_hor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profes]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profes](
	[Id_pro] [int] NOT NULL,
	[Descrip] [varchar](100) NULL,
	[Dispo] [bit] NOT NULL,
	[Id_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_pro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 21/03/2025 9:55:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[Id_usuario] [int] NOT NULL,
	[Id_rol] [int] NULL,
	[Nomb_rol] [varchar](20) NULL,
	[Nomb_usu] [varchar](20) NOT NULL,
	[Nomb2_usu] [varchar](20) NULL,
	[Apell_usu] [varchar](20) NOT NULL,
	[Apell2_usu] [varchar](20) NULL,
	[Edad] [int] NULL,
	[Correo] [varchar](30) NULL,
	[Contrasena] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[asignatura]  WITH CHECK ADD FOREIGN KEY([Id_curso])
REFERENCES [dbo].[cursos] ([Id_curso])
GO
ALTER TABLE [dbo].[asignatura]  WITH CHECK ADD FOREIGN KEY([Id_hor])
REFERENCES [dbo].[horarios] ([Id_hor])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_adm])
REFERENCES [dbo].[admins] ([Id_adm])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_inscrip])
REFERENCES [dbo].[estud] ([Id_inscrip])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_inscrip])
REFERENCES [dbo].[estud] ([Id_inscrip])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_pro])
REFERENCES [dbo].[profes] ([Id_pro])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[usuarios] ([Id_usuario])
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[usuarios] ([Id_usuario])
GO
USE [master]
GO
ALTER DATABASE [siga] SET  READ_WRITE 
GO
