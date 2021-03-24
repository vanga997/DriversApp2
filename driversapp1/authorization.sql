CREATE TABLE [dbo].[Authentication](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Login] [nvarchar](MAX) NOT NULL,
	[Password] [nvarchar](MAX) NOT NULL,
)

SET IDENTITY_INSERT [dbo].[Authentication] ON
INSERT [dbo].[Authentication] ([ID], [Login], [Password]) VALUES (1, N'Admin', N'666')
INSERT [dbo].[Authentication] ([ID], [Login], [Password]) VALUES (2, N'user1', N'112233')
SET IDENTITY_INSERT [dbo].[Authentication] OFF