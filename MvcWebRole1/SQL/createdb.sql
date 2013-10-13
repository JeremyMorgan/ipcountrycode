SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[geoplugin] (
Id int NOT NULL IDENTITY,
[ipStart] bigint,
[ipEnd] bigint,
[countryCode] varchar(2),
[countryName] varchar(50)
CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED 
(
      [Id] ASC
))

GO

SET ANSI_PADDING OFF
GO





