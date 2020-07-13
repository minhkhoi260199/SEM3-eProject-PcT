USE [HealthInsuranceMgmt]
GO
/****** Object:  Table [dbo].[AdminLogin]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminLogin](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AdminLogin] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyDetails]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetails](
	[CompanyId] [int] NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](20) NULL,
	[CompanyUrl] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[Designation] [varchar](50) NULL,
	[JoinDate] [datetime] NULL,
	[Salary] [money] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[PolicyStatus] [bit] NULL,
	[PolicyId] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospitals]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospitals](
	[HospitalId] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
	[HospitalUrl] [varchar](50) NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[HospitalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policies]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[PolicyId] [int] IDENTITY(1,1) NOT NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyDesc] [varchar](250) NULL,
	[Amount] [money] NULL,
	[Emi] [money] NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_Policies] PRIMARY KEY CLUSTERED 
(
	[PolicyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoliciesOnEmployees]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoliciesOnEmployees](
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NOT NULL,
	[PolicyName] [varchar](50) NOT NULL,
	[PolicyAmount] [money] NOT NULL,
	[PolicyDuration] [int] NOT NULL,
	[Emi] [money] NOT NULL,
	[PStartDate] [datetime] NOT NULL,
	[PEndDate] [datetime] NOT NULL,
	[CompanyId] [varchar](50) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyApprovalDetails]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyApprovalDetails](
	[PolicyId] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NULL,
	[ApprovedDate] [datetime] NULL,
	[Amount] [money] NULL,
	[Status] [bit] NULL,
	[Reason] [varchar](50) NULL,
 CONSTRAINT [PK_PolicyApprovalDetails] PRIMARY KEY CLUSTERED 
(
	[PolicyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyRequestDetails]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyRequestDetails](
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [datetime] NULL,
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyAmount] [money] NULL,
	[Emi] [money] NULL,
	[CompanyId] [int] NULL,
	[CompanyName] [varchar](50) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_PolicyRequestDetails] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyTotalDescription]    Script Date: 7/13/2020 7:47:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyTotalDescription](
	[PolicyId] [int] IDENTITY(1,1) NOT NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyDesc] [varchar](250) NULL,
	[PolicyAmount] [money] NULL,
	[Emi] [money] NULL,
	[PolicyDuration] [int] NULL,
	[CompanyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PolicyTotalDescription] PRIMARY KEY CLUSTERED 
(
	[PolicyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CompanyDetails] ([CompanyId], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (1, N'YKK (U.S.A) Inc', N'3340 Chestney Rd, Macon, GA 31217, United States', N'+14787457911', N'https://ykknorthamerica.com/')
SET IDENTITY_INSERT [dbo].[Hospitals] ON 

INSERT [dbo].[Hospitals] ([HospitalId], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (1, N'Augusta University Medical Center', N'+14787457922', N'Augusta', N'	http://www.augustahealth.org/')
INSERT [dbo].[Hospitals] ([HospitalId], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (17, N'Candler Hospital', N'+14277885688', N'Savannah', N'http://www.candlerhospital.org/')
INSERT [dbo].[Hospitals] ([HospitalId], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (18, N'Coliseum Northside Hospital', N'+14885675675', N'Macon', N'http:/www.colinorthospiital.com/')
INSERT [dbo].[Hospitals] ([HospitalId], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (19, N'Doctors Hospital of Augusta', N'+14889995675', N'Augusta', N'http:/www.dochospital.com/')
INSERT [dbo].[Hospitals] ([HospitalId], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (20, N'Emory University Hospital', N'+14785665675', N'Atlanta', N'http:/www.emoryhospital.com/')
SET IDENTITY_INSERT [dbo].[Hospitals] OFF
SET IDENTITY_INSERT [dbo].[Policies] ON 

INSERT [dbo].[Policies] ([PolicyId], [PolicyName], [PolicyDesc], [Amount], [Emi], [CompanyId]) VALUES (1, N'Bronze', N'covers 60% on average of your medical costs; patient pay 40%', 12000000.0000, 1000000.0000, 1)
INSERT [dbo].[Policies] ([PolicyId], [PolicyName], [PolicyDesc], [Amount], [Emi], [CompanyId]) VALUES (2, N'Silver', N'covers 70% on average of your medical costs; patient pay 30%', 24000000.0000, 2000000.0000, 1)
INSERT [dbo].[Policies] ([PolicyId], [PolicyName], [PolicyDesc], [Amount], [Emi], [CompanyId]) VALUES (3, N'Gold', N'covers 80% on average of your medical costs; patient pay 20%', 36000000.0000, 3000000.0000, 1)
INSERT [dbo].[Policies] ([PolicyId], [PolicyName], [PolicyDesc], [Amount], [Emi], [CompanyId]) VALUES (4, N'Platinum', N'covers 90% on average of your medical costs; patient pay 10%', 48000000.0000, 4000000.0000, 1)
SET IDENTITY_INSERT [dbo].[Policies] OFF
