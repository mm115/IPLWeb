INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5116aa90-09f2-4807-90dd-95c6f8583d6f', N'admin', N'admin', N'dd025bac-ab93-4b2f-a94f-5398ec651feb')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5a53a1e9-4417-42e0-8134-4ffe5e11f5cb', N'emily@gmail.com', N'EMILY@GMAIL.COM', N'emily@gmail.com', N'EMILY@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDiZe3Him7pRLlk6Zz9BrR7M2EsUDtWfB7ZL9T/mRR6PHIDA+C2yiGNjtIF+FbVbwg==', N'IVKIT4CDQSDJQJQYBYS2UCLQIQDTHA43', N'13c7f2bc-872c-495d-8d03-12f47a8a72bc', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'afd2bdc6-220f-4080-92ab-d6f3c366b083', N'admins@iplt20.com', N'ADMINS@IPLT20.COM', N'admins@iplt20.com', N'ADMINS@IPLT20.COM', 1, N'AQAAAAEAACcQAAAAELz08cpDnwJVCm573faMu2Zra1TyybxVQVvK5EZEaQcCvp3KJpoXSduG/XGdmONYhg==', N'E5VCQ23O74ZOG3M5DCW2FLR2RDO2WNRH', N'ca594928-e4a1-4f11-8f42-8f84b6905fa3', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'afd2bdc6-220f-4080-92ab-d6f3c366b083', N'5116aa90-09f2-4807-90dd-95c6f8583d6f')
GO
SET IDENTITY_INSERT [dbo].[Seasons] ON 
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (1, N'2021')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (2, N'2020')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (3, N'2019')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (4, N'2018')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (5, N'2017')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (6, N'2016')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (7, N'2015')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (8, N'2014')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (9, N'2013')
GO
INSERT [dbo].[Seasons] ([SeasonID], [SeasonYear]) VALUES (10, N'2012')
GO
SET IDENTITY_INSERT [dbo].[Seasons] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (1, N'Chennai Super Kings', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (2, N'Delhi Capitals', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (3, N'Kolkata Knight Riders', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (4, N'Mumbai Indians', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (5, N'Punjab Kings', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (6, N'Rajasthan Royals', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (7, N'Royal Challengers Bangalore', N'.png')
GO
INSERT [dbo].[Teams] ([TeamID], [TeamName], [Extension]) VALUES (8, N'Sunrise Hyderabad', N'.png')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Matches] ON 
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (1, N'Arun Jaitley Stadium, Delhi', CAST(N'2021-05-04T21:34:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 8, 4)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (2, N'Arun Jaitley Stadium, Delhi', CAST(N'2021-05-05T21:39:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 6, 1)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (3, N'Narendra Modi Stadium, Ahmedabad', CAST(N'2021-05-06T21:40:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 7, 5)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (4, N'Arun Jaitley Stadium, Delhi', CAST(N'2021-05-07T21:41:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 8, 1)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (5, N'Narendra Modi Stadium, Ahmedabad', CAST(N'2021-05-08T21:43:00.0000000' AS DateTime2), N'15:30 IST (10:00 GMT)', 1, 3, 2)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (6, N'Arun Jaitley Stadium, Delhi', CAST(N'2021-05-08T21:43:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 6, 4)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (7, N'M. Chinnaswamy Stadium, Bengaluru', CAST(N'2021-05-09T21:44:00.0000000' AS DateTime2), N'15:30 IST (10:00 GMT)', 1, 1, 5)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (8, N'Eden Gardens, Kolkata', CAST(N'2021-05-09T21:45:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 7, 8)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (9, N'M. Chinnaswamy Stadium, Bengaluru', CAST(N'2021-05-10T21:45:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 4, 3)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (10, N'Eden Gardens, Kolkata', CAST(N'2021-05-11T21:46:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 2, 6)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (11, N'M. Chinnaswamy Stadium, Bengaluru', CAST(N'2021-05-12T21:46:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 1, 3)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (12, N'M. Chinnaswamy Stadium, Bengaluru', CAST(N'2021-05-13T21:47:00.0000000' AS DateTime2), N'15:30 IST (10:00 GMT)', 1, 4, 5)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (13, N' Eden Gardens, Kolkata', CAST(N'2021-05-13T21:47:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 8, 6)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (14, N'Eden Gardens, Kolkata', CAST(N'2021-05-14T21:48:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 7, 2)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (15, N'M. Chinnaswamy Stadium, Bengaluru', CAST(N'2021-05-15T21:48:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 3, 5)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (16, N'Eden Gardens, Kolkata', CAST(N'2021-05-16T21:49:00.0000000' AS DateTime2), N'15:30 IST (10:00 GMT)', 1, 6, 7)
GO
INSERT [dbo].[Matches] ([TeamID], [VenueName], [MatchDate], [MatchTime], [SeasonID], [TeamID1], [TeamID2]) VALUES (17, N'Eden Gardens, Kolkata', CAST(N'2021-05-16T21:49:00.0000000' AS DateTime2), N'19:30 IST (14:00 GMT)', 1, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[Matches] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 
GO
INSERT [dbo].[Comments] ([CommentID], [CommentText], [CommentDate], [UserID], [MatchID]) VALUES (1, N'Match starts at 15:30 IST (10:00 GMT)', CAST(N'2021-05-03T23:30:54.6573886' AS DateTime2), N'emily@gmail.com', 1)
GO
INSERT [dbo].[Comments] ([CommentID], [CommentText], [CommentDate], [UserID], [MatchID]) VALUES (2, N'Hello everyone and welcome to Match 52 of the 2021 VIVO IPL between Kokata Knight Riders and Sunrisers Hyderabad', CAST(N'2021-05-03T23:31:21.2357993' AS DateTime2), N'emily@gmail.com', 1)
GO
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
