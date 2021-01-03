USE [FeedBackDB]
GO
/****** Object:  Table [dbo].[CommentInfo]    Script Date: 1/3/2021 8:03:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PostID] [int] NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CommentInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostInfo]    Script Date: 1/3/2021 8:03:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Post] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PostInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 1/3/2021 8:03:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](100) NOT NULL,
	[FullName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VoteInfo]    Script Date: 1/3/2021 8:03:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VoteInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PostID] [int] NOT NULL,
	[CommentID] [int] NOT NULL,
	[AggreByVote] [bit] NOT NULL,
 CONSTRAINT [PK_VoteInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[PostInfo] ON 

INSERT [dbo].[PostInfo] ([ID], [UserID], [Post], [CreateDate]) VALUES (1, 4, N'Post 1', CAST(N'2021-01-03 00:00:00.000' AS DateTime))
INSERT [dbo].[PostInfo] ([ID], [UserID], [Post], [CreateDate]) VALUES (3, 4, N'Post 2', CAST(N'2021-01-03 00:00:00.000' AS DateTime))
INSERT [dbo].[PostInfo] ([ID], [UserID], [Post], [CreateDate]) VALUES (4, 4, N'Post 3', CAST(N'2021-01-03 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PostInfo] OFF
SET IDENTITY_INSERT [dbo].[UserInfo] ON 

INSERT [dbo].[UserInfo] ([ID], [UserID], [FullName]) VALUES (1, N'User1', N'User 1')
INSERT [dbo].[UserInfo] ([ID], [UserID], [FullName]) VALUES (2, N'User2', N'User 2')
INSERT [dbo].[UserInfo] ([ID], [UserID], [FullName]) VALUES (3, N'User3', N'User 3')
INSERT [dbo].[UserInfo] ([ID], [UserID], [FullName]) VALUES (4, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
