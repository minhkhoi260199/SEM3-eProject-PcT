USE [HealthInsuranceMgmt]
GO
/****** Object:  Table [dbo].[AdminLogin]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UserType] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Adrress] [varchar](50) NULL,
 CONSTRAINT [PK_AdminLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InsuranceId] [int] NOT NULL,
	[Status] [int] NULL,
	[Description] [varchar](250) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyDetails]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](20) NULL,
	[CompanyUrl] [varchar](50) NULL,
 CONSTRAINT [PK_CompanyDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Designation] [varchar](50) NULL,
	[JoinDate] [datetime] NOT NULL,
	[Salary] [money] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospitals]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospitals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
	[HospitalUrl] [varchar](50) NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicals]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MedicalName] [varchar](250) NOT NULL,
	[MedicalDescription] [varchar](250) NULL,
	[CompanyId] [int] NOT NULL,
	[HospitalId] [int] NOT NULL,
 CONSTRAINT [PK_Medicals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policies]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyDesc] [varchar](250) NULL,
	[Amount] [money] NULL,
	[Emi] [money] NULL,
	[PolicyDuration] [int] NULL,
	[MedicalId] [int] NOT NULL,
 CONSTRAINT [PK_Policies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoliciesOnEmployees]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoliciesOnEmployees](
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusId] [int] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_PoliciesOnEmployees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyRequestDetails]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyRequestDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[ApprovedDate] [datetime] NULL,
	[Reason] [varchar](250) NULL,
 CONSTRAINT [PK_PolicyRequestDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](250) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](250) NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 8/5/2020 11:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminLogin] ON 

INSERT [dbo].[AdminLogin] ([Id], [UserName], [Password], [UserType], [FirstName], [LastName], [Phone], [Email], [Adrress]) VALUES (1, N'long', N'123456', 1, N'Long', N'Nguyen', N'0898512680', N'long@gmail.com', N'HCM')
SET IDENTITY_INSERT [dbo].[AdminLogin] OFF
SET IDENTITY_INSERT [dbo].[CompanyDetails] ON 

INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (1, N'Liberty Insurance Inc', N'44A Mac Dinh Chi st, Dist 1, HCM City', N'+84-1800599998', N'https://www.libertyinsurance.com.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (2, N'Bao Viet Insurance Inc', N'257 NTMK st, Dist 3, HCM City', N'+84-0966795333', N'https://ibaoviet.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (3, N'Bao Minh Insurance Inc', N'112 CMT8 st, Dist 10, HCM City', N'+84-0903686166', N'http://baominhsaigon.com.vn')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (4, N'VietinBank Health Insurance Inc', N'357 Le Duan st, Dist 1, HCM City', N'+84-2819001566', N'https://vbi.vietinbank.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (5, N'BIC Health Insurance Inc', N'191 Ba Trieu st, Dong Da Dist, HN City', N'+84-0422200282', N'https://bic.vn/')
SET IDENTITY_INSERT [dbo].[CompanyDetails] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (1, N'Worker', CAST(N'2020-07-15T00:00:00.000' AS DateTime), 6000000.0000, N'Lan', N'Ly', N'user001', N'123456', N'17A NTMK st', N'+84-394455693', N'Dist 3', N'Vietnam', N'HCM', 2)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (2, N'Manager', CAST(N'2019-08-07T00:00:00.000' AS DateTime), 20000000.0000, N'Van', N'Hanh', N'user002', N'123456', N'22 Alexander', N'+84-455365115', N'Cau Giay', N'Vietnam', N'HN', 2)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Hospitals] ON 

INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (1, N'Vinmec Central Park International Hospital', N'+84-2836221166', N'Binh Thanh, HCM', N'https://vinmec.com/centralpark/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (2, N'FV International Hospital', N'+84-2854113333', N'Dist 7, HCM', N'http://www.fvhospital.com/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (3, N'City International Hospital', N'+84-2862803333', N'Binh Tan, HCM', N'https://cih.com.vn/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (4, N'Victoria Healthcare International Hospital', N'+84-2839104545', N'Phu Nhuan, HCM', N'https://www.victoriavn.com/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (5, N'Columbia Asia Internation General Hospital', N'+84-2838238888', N'Dist 1, HCM', N'https://www.columbiaasia.com/')
SET IDENTITY_INSERT [dbo].[Hospitals] OFF
SET IDENTITY_INSERT [dbo].[Medicals] ON 

INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (1, N'Liberty MediCare Health Insurance', N'Citizens are living in Vietnam. Ages 15 to 64. This insurance is not for people with pre-existing illness or special illness.', 1, 1)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (2, N'Liberty Healthcare Insurance', N'Citizens are living in Vietnam. Ages 15 to 64. This insurance is not for people with pre-existing illness or special illness.', 1, 2)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (3, N'Bao Viet K-Care Insurance', N'Citizens are living in Vietnam. Ages 15 to 60. This insurance is not for people with pre-existing illness or special illness.', 2, 3)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (4, N'Bao Viet InterCare Insurance', N'Citizens are living in Vietnam. Ages 15 to 75. This insurance is not for people with pre-existing illness or special illness.', 2, 4)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (5, N'Bao Minh HealthCare Insurance', N'Citizens are living in Vietnam. Ages 15 to 60. People with mental illness, leprosy, cancer.', 3, 5)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (6, N'Bao Minh PSN-Care Insurance', N'Citizens are living in Vietnam. Ages 1 to 70. Those who are disabled or permanently disabled from 50% or more.', 3, 1)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (7, N'ViettinBank VBI Care Insurance', N'Citizens are living in Vietnam. Ages 1 to 60. People who are in the process of treating illnesses, injuries', 4, 2)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (8, N'ViettinBank HC Insurance', N'Citizens are living in Vietnam. Ages 18 to 70. People who are in the process of treating illnesses, injuries', 4, 3)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (9, N'BIC Care Insurance', N'Citizens are living in Vietnam. Ages 1 to 65. People with mental illness, leprosy. Those with permanent disability more than 50%', 5, 4)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (10, N'BIC 24/7 Insurance', N'Citizens are living in Vietnam. Ages 1 to 65. People with mental illness, leprosy. Those with permanent disability more than 50%', 5, 5)
SET IDENTITY_INSERT [dbo].[Medicals] OFF
SET IDENTITY_INSERT [dbo].[Policies] ON 

INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (1, N'Liberty MediCare Standard', N'There is no limit to the number of visits and the cost of each visit. Transparent, fast and fair compensation procedure.', 300000000.0000, 25000000.0000, 12, 1)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (2, N'Liberty MediCare Premium', N'There is no limit to the number of visits and the cost of each visit. Transparent, fast and fair compensation procedure.', 600000000.0000, 50000000.0000, 12, 1)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (3, N'Liberty Healthcare Standard', N'Insurance for both illness and accident. Medical examination and treatment in Vietnam or abroad. Get global emergency medical assistance by International SOS', 24000000.0000, 2000000.0000, 12, 2)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (4, N'Liberty Healthcare Premium', N'Insurance for both illness and accident. Medical examination and treatment in Vietnam or abroad. Get global emergency medical assistance by International SOS', 48000000.0000, 4000000.0000, 12, 2)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (5, N'Bao Viet K-Care Standard', N'The Bao Viet K-Care is the optimal choice to help customers reduce the worry about treatment costs from the beginning, peace of mind to choose the solutions Best treatments without having to worry about financial burdens', 120000000.0000, 10000000.0000, 12, 3)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (6, N'Bao Viet K-Care Premium', N'The Bao Viet K-Care is the optimal choice to help customers reduce the worry about treatment costs from the beginning, peace of mind to choose the solutions Best treatments without having to worry about financial burdens.', 240000000.0000, 20000000.0000, 12, 3)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (7, N'Bao Viet InterCare Standard', N'The Bao Viet K-Care is the optimal choice to help customers reduce the worry about treatment costs from the beginning, peace of mind to choose the solutions Best treatments without having to worry about financial burdens.', 48000000.0000, 4000000.0000, 12, 4)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (8, N'Bao Viet InterCare Premium', N'The Bao Viet K-Care is the optimal choice to help customers reduce the worry about treatment costs from the beginning, peace of mind to choose the solutions Best treatments without having to worry about financial burdens', 120000000.0000, 10000000.0000, 12, 4)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (9, N'Bao Minh HealthCare Standard', N'Accident insurance protects against the following risks:
Died. Total permanent disability. Permanent disability
Loss of income. Medical costs.
', 60000000.0000, 5000000.0000, 12, 5)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (10, N'Bao Minh HealthCare Premium', N'Accident insurance protects against the following risks:
Died. Total permanent disability. Permanent disability
Loss of income. Medical costs.
', 120000000.0000, 10000000.0000, 12, 5)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (11, N'Bao Minh PSN-Care Standard', N'Health insurance has a variety of insurance packages such as life insurance and medical cost insurance, dental treatment insurance, eye treatment insurance for customers to choose on demand.', 96000000.0000, 8000000.0000, 12, 6)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (12, N'Bao Minh PSN-Care Premium', N'Health insurance has a variety of insurance packages such as life insurance and medical cost insurance, dental treatment insurance, eye treatment insurance for customers to choose on demand.', 240000000.0000, 20000000.0000, 12, 6)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (14, N'ViettinBank VBI Care Standard', N'For every human being, health is always the most important issue. We cannot foresee the risks that can happen to us and our family such as illness, illness, and accident risk. ', 480000000.0000, 40000000.0000, 12, 7)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (15, N'ViettinBank VBI Care Premium', N'For every human being, health is always the most important issue. We cannot foresee the risks that can happen to us and our family such as illness, illness, and accident risk.', 120000000.0000, 10000000.0000, 12, 7)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (16, N'ViettinBank HC Standard', N'Understanding that, VBI Insurance brings you VBI Care health insurance package. Choosing VBI insurance is the best financial solution for you and your family to enjoy life with peace of mind', 360000000.0000, 30000000.0000, 12, 8)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (18, N'ViettinBank HC premium', N'Understanding that, VBI Insurance brings you VBI Care health insurance package. Choosing VBI insurance is the best financial solution for you and your family to enjoy life with peace of mind', 720000000.0000, 60000000.0000, 12, 8)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (19, N'BIC Care Standard', N'Insurance benefits: Death of permanent disability due to an accident. Medical expenses due to an accident
Income allowance for the treatment of accidental injuries.
', 60000000.0000, 5000000.0000, 12, 9)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (20, N'BIC Care Premium', N'Insurance benefits: Death of permanent disability due to an accident. Medical expenses due to an accident
Income allowance for the treatment of accidental injuries.
', 144000000.0000, 12000000.0000, 12, 9)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (21, N'BIC 24/7 Standard', N'Medical expenses (including hospitalization expenses) according to the amount of insurance selected by the enterprise.', 96000000.0000, 8000000.0000, 12, 10)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (22, N'BIC 24/7 Premium', N'Medical expenses (including hospitalization expenses) according to the amount of insurance selected by the enterprise.', 144000000.0000, 12000000.0000, 12, 10)
SET IDENTITY_INSERT [dbo].[Policies] OFF
SET IDENTITY_INSERT [dbo].[PoliciesOnEmployees] ON 

INSERT [dbo].[PoliciesOnEmployees] ([EmpId], [PolicyId], [Id], [StatusId], [EndDate]) VALUES (1, 3, 1, 2, CAST(N'2021-08-25T00:00:00.000' AS DateTime))
INSERT [dbo].[PoliciesOnEmployees] ([EmpId], [PolicyId], [Id], [StatusId], [EndDate]) VALUES (2, 7, 2, 2, CAST(N'2021-07-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PoliciesOnEmployees] OFF
SET IDENTITY_INSERT [dbo].[PolicyRequestDetails] ON 

INSERT [dbo].[PolicyRequestDetails] ([Id], [RequestDate], [EmpId], [PolicyId], [Status], [ApprovedDate], [Reason]) VALUES (1, CAST(N'2020-08-05T00:00:00.000' AS DateTime), 2, 7, 2, CAST(N'2020-08-10T00:00:00.000' AS DateTime), N'traffic accidents')
SET IDENTITY_INSERT [dbo].[PolicyRequestDetails] OFF
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Status]) VALUES (1, N'Pending')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (2, N'Accepted')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (3, N'Cancel')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (4, N'Denied')
SET IDENTITY_INSERT [dbo].[Status] OFF
SET IDENTITY_INSERT [dbo].[UserStatus] ON 

INSERT [dbo].[UserStatus] ([Id], [StatusName]) VALUES (1, N'Block')
INSERT [dbo].[UserStatus] ([Id], [StatusName]) VALUES (2, N'Active')
INSERT [dbo].[UserStatus] ([Id], [StatusName]) VALUES (3, N'Inactive')
SET IDENTITY_INSERT [dbo].[UserStatus] OFF
SET IDENTITY_INSERT [dbo].[UserType] ON 

INSERT [dbo].[UserType] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[UserType] ([Id], [Name]) VALUES (2, N'Manager')
INSERT [dbo].[UserType] ([Id], [Name]) VALUES (3, N'Financial Manager')
SET IDENTITY_INSERT [dbo].[UserType] OFF
ALTER TABLE [dbo].[AdminLogin]  WITH CHECK ADD  CONSTRAINT [FK_AdminLogin_UserType] FOREIGN KEY([UserType])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[AdminLogin] CHECK CONSTRAINT [FK_AdminLogin_UserType]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_PoliciesOnEmployees] FOREIGN KEY([InsuranceId])
REFERENCES [dbo].[PoliciesOnEmployees] ([Id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_PoliciesOnEmployees]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_UserStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[UserStatus] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_UserStatus]
GO
ALTER TABLE [dbo].[Medicals]  WITH CHECK ADD  CONSTRAINT [FK_Medicals_CompanyDetails] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyDetails] ([Id])
GO
ALTER TABLE [dbo].[Medicals] CHECK CONSTRAINT [FK_Medicals_CompanyDetails]
GO
ALTER TABLE [dbo].[Medicals]  WITH CHECK ADD  CONSTRAINT [FK_Medicals_Hospitals] FOREIGN KEY([HospitalId])
REFERENCES [dbo].[Hospitals] ([Id])
GO
ALTER TABLE [dbo].[Medicals] CHECK CONSTRAINT [FK_Medicals_Hospitals]
GO
ALTER TABLE [dbo].[Policies]  WITH CHECK ADD  CONSTRAINT [FK_Policies_Medicals] FOREIGN KEY([MedicalId])
REFERENCES [dbo].[Medicals] ([Id])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Medicals]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Employees]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Policies] FOREIGN KEY([PolicyId])
REFERENCES [dbo].[Policies] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Policies]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Status]
GO
ALTER TABLE [dbo].[PolicyRequestDetails]  WITH CHECK ADD  CONSTRAINT [FK_PolicyRequestDetails_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[PolicyRequestDetails] CHECK CONSTRAINT [FK_PolicyRequestDetails_Employees]
GO
ALTER TABLE [dbo].[PolicyRequestDetails]  WITH CHECK ADD  CONSTRAINT [FK_PolicyRequestDetails_Policies] FOREIGN KEY([PolicyId])
REFERENCES [dbo].[Policies] ([Id])
GO
ALTER TABLE [dbo].[PolicyRequestDetails] CHECK CONSTRAINT [FK_PolicyRequestDetails_Policies]
GO
ALTER TABLE [dbo].[PolicyRequestDetails]  WITH CHECK ADD  CONSTRAINT [FK_PolicyRequestDetails_Status] FOREIGN KEY([Status])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[PolicyRequestDetails] CHECK CONSTRAINT [FK_PolicyRequestDetails_Status]
GO
