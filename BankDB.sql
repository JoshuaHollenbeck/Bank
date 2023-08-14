USE [master]
GO
/****** Object:  Database [BankDB]    Script Date: 8/14/2023 2:04:13 PM ******/
CREATE DATABASE [BankDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bank', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Bank.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bank_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Bank_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BankDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BankDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BankDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BankDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BankDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BankDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BankDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BankDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BankDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BankDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BankDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BankDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BankDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BankDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BankDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BankDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BankDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BankDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BankDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BankDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BankDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BankDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BankDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BankDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BankDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BankDB] SET  MULTI_USER 
GO
ALTER DATABASE [BankDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BankDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BankDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BankDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BankDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BankDB', N'ON'
GO
ALTER DATABASE [BankDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [BankDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BankDB]
GO
/****** Object:  User [joshua.hollenbeck]    Script Date: 8/14/2023 2:04:13 PM ******/
CREATE USER [joshua.hollenbeck] FOR LOGIN [joshua.hollenbeck] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[business_contact]    Script Date: 8/14/2023 2:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[business_contact](
	[business_id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](200) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[address] [nvarchar](200) NOT NULL,
	[address_2] [nvarchar](200) NULL,
	[city] [nvarchar](50) NOT NULL,
	[state] [nvarchar](50) NOT NULL,
	[zip_code] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[business_info]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[business_info](
	[business_id] [int] NOT NULL,
	[business_secondary_id] [int] NOT NULL,
	[business_name] [nvarchar](50) NOT NULL,
	[client_since] [date] NOT NULL,
	[business_type] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[business_tax]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[business_tax](
	[business_id] [int] IDENTITY(1,1) NOT NULL,
	[encrypted_tax_a] [varbinary](128) NOT NULL,
	[tax_b] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client_acct]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client_acct](
	[acct_id] [int] NOT NULL,
	[acct_num] [int] NOT NULL,
	[cust_id] [int] NOT NULL,
	[acct_nickname] [nvarchar](50) NULL,
	[acct_pass] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp_department]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp_department](
	[department_id] [int] NOT NULL,
	[department_name] [varchar](50) NOT NULL,
	[description] [varchar](500) NOT NULL,
 CONSTRAINT [PK__departme__C22324223AEB4B50] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp_location]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp_location](
	[location_id] [int] NOT NULL,
	[location_name] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[city] [varchar](100) NULL,
	[state] [varchar](100) NULL,
	[zip] [varchar](20) NULL,
	[location_type_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp_location_type]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp_location_type](
	[location_type_id] [int] NOT NULL,
	[location_type] [varchar](100) NOT NULL,
 CONSTRAINT [PK__comp_loc__771831EA8051DD08] PRIMARY KEY CLUSTERED 
(
	[location_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp_position]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp_position](
	[position_id] [int] NOT NULL,
	[position_name] [varchar](100) NOT NULL,
	[department_id] [int] NOT NULL,
	[salary_range_low] [decimal](10, 2) NOT NULL,
	[salary_range_high] [decimal](10, 2) NOT NULL,
	[parent_position_id] [int] NOT NULL,
	[position_removed] [bit] NOT NULL,
 CONSTRAINT [PK__position__99A0E7A4A17D6B7C] PRIMARY KEY CLUSTERED 
(
	[position_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comp_position_location]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comp_position_location](
	[position_location_id] [int] NOT NULL,
	[location_id] [int] NOT NULL,
	[position_id] [int] NOT NULL,
 CONSTRAINT [PK_comp_position_location] PRIMARY KEY CLUSTERED 
(
	[position_location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_contact]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_contact](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](200) NOT NULL,
	[phone_home] [nvarchar](50) NOT NULL,
	[phone_business] [nvarchar](50) NOT NULL,
	[address] [nvarchar](200) NOT NULL,
	[address_2] [nvarchar](200) NULL,
	[city] [nvarchar](50) NOT NULL,
	[state] [nvarchar](50) NOT NULL,
	[zip_code] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_emp]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_emp](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[employment_status] [nvarchar](50) NULL,
	[employer_name] [nvarchar](200) NULL,
	[occupation] [nvarchar](500) NULL,
 CONSTRAINT [PK_cust_emp] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_id]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_id](
	[cust_id] [int] NOT NULL,
	[id_type] [int] NULL,
	[id_state] [nvarchar](50) NULL,
	[id_num] [nvarchar](50) NULL,
	[id_exp] [nvarchar](50) NULL,
	[mothers_maiden] [nvarchar](50) NULL,
 CONSTRAINT [PK_cust_state_id] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_info]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_info](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_secondary_id] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[middle_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[suffix] [nvarchar](50) NULL,
	[date_of_birth] [date] NOT NULL,
	[client_since] [date] NOT NULL,
 CONSTRAINT [PK_cust_information] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_privacy]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_privacy](
	[cust_id] [int] NOT NULL,
	[voice_auth] [bit] NULL,
	[do_not_call] [bit] NULL,
	[share_affiliates] [bit] NULL,
 CONSTRAINT [PK_cust_stuff] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cust_tax]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_tax](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[encrypted_tax_a] [varbinary](128) NOT NULL,
	[tax_b] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_cust_tax] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_contact]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_contact](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](200) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[address] [nvarchar](200) NOT NULL,
	[address_2] [nvarchar](200) NULL,
	[city] [nvarchar](50) NOT NULL,
	[state] [nvarchar](50) NOT NULL,
	[zip_code] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__emp_pers__1299A8612474792A] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_info]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_info](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_secondary_id] [nvarchar](50) NULL,
	[first_name] [nvarchar](200) NULL,
	[middle_name] [nvarchar](200) NULL,
	[last_name] [nvarchar](200) NULL,
	[suffix] [nvarchar](50) NULL,
	[date_of_birth] [date] NULL,
	[termination_date] [date] NULL,
	[hire_date] [date] NULL,
 CONSTRAINT [PK__emp_info__1299A861548DE268] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_position]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_position](
	[emp_position_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [int] NOT NULL,
	[position_location_id] [int] NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NULL,
 CONSTRAINT [PK__employee__0A9EB98968F67576] PRIMARY KEY CLUSTERED 
(
	[emp_position_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_salary]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_salary](
	[salary_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [int] NULL,
	[effective_date] [date] NULL,
	[salary_amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK__emp_sala__A3C71C5158369EBA] PRIMARY KEY CLUSTERED 
(
	[salary_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_tax]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_tax](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[encrypted_tax_a] [varbinary](128) NOT NULL,
	[tax_b] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_emp_tax] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp_termination]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_termination](
	[termination_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [int] NOT NULL,
	[termination_date] [date] NOT NULL,
	[reason] [varchar](100) NOT NULL,
	[rehireable] [bit] NOT NULL,
 CONSTRAINT [PK__terminat__B66BAA113D18C8F0] PRIMARY KEY CLUSTERED 
(
	[termination_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LU_business_types]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LU_business_types](
	[business_type_id] [int] NOT NULL,
	[business_type_name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LU_id_type]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LU_id_type](
	[id_id] [int] NOT NULL,
	[id_type] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LU_termination_reason]    Script Date: 8/14/2023 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LU_termination_reason](
	[termination_id] [int] NOT NULL,
	[termination_reason] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[LU_id_type] ([id_id], [id_type]) VALUES (1, N'Passport')
INSERT [dbo].[LU_id_type] ([id_id], [id_type]) VALUES (2, N'Driver''s License')
INSERT [dbo].[LU_id_type] ([id_id], [id_type]) VALUES (3, N'DOD ID')
INSERT [dbo].[LU_id_type] ([id_id], [id_type]) VALUES (4, N'State ID')
INSERT [dbo].[LU_id_type] ([id_id], [id_type]) VALUES (5, N'Work Visa')
GO
USE [master]
GO
ALTER DATABASE [BankDB] SET  READ_WRITE 
GO
