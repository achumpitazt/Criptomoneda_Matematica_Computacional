USE [master]
GO
/****** Object:  Database [dbSimuladorV4]    Script Date: 14/04/2020 01:10:30 ******/
CREATE DATABASE [dbSimuladorV4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbSimuladorV4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbSimuladorV4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbSimuladorV4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbSimuladorV4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbSimuladorV4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbSimuladorV4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbSimuladorV4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbSimuladorV4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbSimuladorV4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbSimuladorV4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbSimuladorV4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET RECOVERY FULL 
GO
ALTER DATABASE [dbSimuladorV4] SET  MULTI_USER 
GO
ALTER DATABASE [dbSimuladorV4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbSimuladorV4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbSimuladorV4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbSimuladorV4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbSimuladorV4] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbSimuladorV4', N'ON'
GO
ALTER DATABASE [dbSimuladorV4] SET QUERY_STORE = OFF
GO
USE [dbSimuladorV4]
GO
/****** Object:  Table [dbo].[BilleteraVirtual]    Script Date: 14/04/2020 01:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BilleteraVirtual](
	[idCreador] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Cantidad] [money] NULL,
	[Minado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creador]    Script Date: 14/04/2020 01:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creador](
	[idCreador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[CodigoEspecial] [int] NULL,
	[Inversion] [money] NULL,
	[Retiro] [money] NULL,
	[TipoCpu] [varchar](50) NULL,
	[TipoRam] [int] NULL,
	[TipoTarjetaGrafica] [varchar](50) NULL,
	[TiempoConexion] [int] NULL,
	[NumeroTransacciones] [int] NULL,
 CONSTRAINT [PK_Creador] PRIMARY KEY CLUSTERED 
(
	[idCreador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criptomoneda]    Script Date: 14/04/2020 01:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criptomoneda](
	[idCriptomoneda] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Cantidad] [money] NULL,
	[Valor] [money] NULL,
	[idCreador] [int] NULL,
	[InversionSeguridad] [money] NULL,
	[InversionPublicidad] [money] NULL,
	[Status] [int] NULL,
	[Mes] [int] NULL,
	[Año] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recibo]    Script Date: 14/04/2020 01:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibo](
	[idEmisor] [int] NULL,
	[NombreEmisor] [varchar](50) NULL,
	[idDestinatario] [int] NULL,
	[NombreDestinatario] [varchar](50) NULL,
	[Motivo] [varchar](50) NULL,
	[Cantidad] [money] NULL,
	[NombreCriptomoneda] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [dbSimuladorV4] SET  READ_WRITE 
GO
