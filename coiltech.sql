USE [master]
GO
/****** Object:  Database [coiltechDB]    Script Date: 27.02.2021 03:43:29 ******/
CREATE DATABASE [coiltechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'coiltechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\coiltechDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'coiltechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\coiltechDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [coiltechDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [coiltechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [coiltechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [coiltechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [coiltechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [coiltechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [coiltechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [coiltechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [coiltechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [coiltechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [coiltechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [coiltechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [coiltechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [coiltechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [coiltechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [coiltechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [coiltechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [coiltechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [coiltechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [coiltechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [coiltechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [coiltechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [coiltechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [coiltechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [coiltechDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [coiltechDB] SET  MULTI_USER 
GO
ALTER DATABASE [coiltechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [coiltechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [coiltechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [coiltechDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [coiltechDB]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 27.02.2021 03:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[musteri] [varchar](50) NULL,
	[makineGrubu] [varchar](50) NULL,
	[adet] [varchar](50) NULL,
	[anmaKodu] [varchar](50) NULL,
	[siparisKodu] [varchar](50) NULL,
	[listeFiyati] [varchar](50) NULL,
	[musteriFiyati] [varchar](50) NULL,
	[euro] [varchar](50) NULL,
	[dolar] [varchar](50) NULL,
	[iskontoOrani] [varchar](50) NULL,
	[cezaliSozlesmeli] [varchar](20) NULL,
	[teminatCekli] [varchar](20) NULL,
	[musteriTemsilcisi] [varchar](50) NULL,
	[musteriKonumu] [varchar](10) NULL,
	[faturaSekli] [varchar](10) NULL,
	[satisSekli] [varchar](10) NULL,
	[UYFno] [varchar](50) NULL,
	[siparisTarihi] [varchar](20) NULL,
	[teslimTarihi] [varchar](20) NULL,
	[musteriYeniEski] [varchar](10) NULL,
	[notlar] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sifreTablosu]    Script Date: 27.02.2021 03:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sifreTablosu](
	[sifre] [varchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Table_1] ([musteri], [makineGrubu], [adet], [anmaKodu], [siparisKodu], [listeFiyati], [musteriFiyati], [euro], [dolar], [iskontoOrani], [cezaliSozlesmeli], [teminatCekli], [musteriTemsilcisi], [musteriKonumu], [faturaSekli], [satisSekli], [UYFno], [siparisTarihi], [teslimTarihi], [musteriYeniEski], [notlar]) VALUES (N'ahmet erkin', N'ahmet makine', N'2', N'2133', N'231312', N'', N'', N'', N'', N'', N'Cezalı Sözleşmeli', N'Teminat Çekli', N'aslı sarı', N' yurt içi', N'ihracat', N' doğrudan', N'', N'  .  .', N'  .  .', N'yeni ', N'sadsaddsasdasd')
INSERT [dbo].[Table_1] ([musteri], [makineGrubu], [adet], [anmaKodu], [siparisKodu], [listeFiyati], [musteriFiyati], [euro], [dolar], [iskontoOrani], [cezaliSozlesmeli], [teminatCekli], [musteriTemsilcisi], [musteriKonumu], [faturaSekli], [satisSekli], [UYFno], [siparisTarihi], [teslimTarihi], [musteriYeniEski], [notlar]) VALUES (N'sadık gümüş', N'sadık makine', N'4', N'423', N'3212', N'765', N'565', N'187', N'932', N'%12', N'Cezalı Sözleşmeli', N'Teminat Çekli', N'ali inan', N' yurt dışı', N'ihracat', N' dolaylı', N'3234', N'22.02.2021', N'26.04.2021', N'eski', N'deneme')
INSERT [dbo].[Table_1] ([musteri], [makineGrubu], [adet], [anmaKodu], [siparisKodu], [listeFiyati], [musteriFiyati], [euro], [dolar], [iskontoOrani], [cezaliSozlesmeli], [teminatCekli], [musteriTemsilcisi], [musteriKonumu], [faturaSekli], [satisSekli], [UYFno], [siparisTarihi], [teslimTarihi], [musteriYeniEski], [notlar]) VALUES (N'sinem kızılkaya', N'sinem makine ltd şti', N'2', N'2133', N'213', N'4322', N'4322', N'123', N'312', N'', N'Cezalı Sözleşmeli', N'Teminat Çekli', N'ali inan', N' yurt içi', N'ihracat', N' doğrudan', N'231321', N'05.06.2021', N'05.09.2021', N'yeni ', N'merhaba')
INSERT [dbo].[tbl_sifreTablosu] ([sifre]) VALUES (N'414141')
USE [master]
GO
ALTER DATABASE [coiltechDB] SET  READ_WRITE 
GO
