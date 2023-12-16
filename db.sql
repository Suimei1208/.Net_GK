USE [master]
GO
/****** Object:  Database [StudentInformationDB]    Script Date: 16/12/2023 10:19:53 SA ******/
CREATE DATABASE [StudentInformationDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentInformationDB', FILENAME = N'E:\application\SQLSERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentInformationDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentInformationDB_log', FILENAME = N'E:\application\SQLSERVER\MSSQL16.MSSQLSERVER\MSSQL\DATA\StudentInformationDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StudentInformationDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentInformationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentInformationDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentInformationDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentInformationDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentInformationDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentInformationDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentInformationDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentInformationDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentInformationDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentInformationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentInformationDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentInformationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentInformationDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentInformationDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentInformationDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentInformationDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentInformationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentInformationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentInformationDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentInformationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentInformationDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentInformationDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentInformationDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentInformationDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentInformationDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentInformationDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentInformationDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentInformationDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentInformationDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentInformationDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentInformationDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentInformationDB', N'ON'
GO
ALTER DATABASE [StudentInformationDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StudentInformationDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StudentInformationDB]
GO
/****** Object:  Table [dbo].[Certificates]    Script Date: 16/12/2023 10:19:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificates](
	[CertificateID] [int] IDENTITY(1,1) NOT NULL,
	[CertificateName] [nvarchar](50) NOT NULL,
	[StudentID] [int] NULL,
 CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED 
(
	[CertificateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 16/12/2023 10:19:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[LoginHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[LoginTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 16/12/2023 10:19:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Age] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Gender] [nvarchar](20) NULL,
	[Status] [nvarchar](20) NULL,
	[GPA] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16/12/2023 10:19:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
	[Age] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Avatar] [nvarchar](255) NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [StudentInformationDB] SET  READ_WRITE 
GO
