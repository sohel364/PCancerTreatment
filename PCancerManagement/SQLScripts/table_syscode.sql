USE cancer
GO

/****** Object:  Table [dbo].[SYSTEM_CODE]    Script Date: 5/9/2015 10:11:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SYSTEM_CODE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entity_name] [varchar](50) NULL,
	[entity_code] [int] NULL,
	[entity_prefix] [varchar](3) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

