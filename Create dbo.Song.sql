USE [LynzyLDB]
GO

/****** Object: Table [dbo].[Song] Script Date: 5/15/2018 11:31:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE TABLE [dbo].[Song] (
    [SID]                  INT           IDENTITY (1, 1) NOT NULL,
    [Name]                 VARCHAR (128) NULL,
    [Title]                VARCHAR (128) NULL,
    [Contributing Artists] VARCHAR (128) NULL,
    [Album]                VARCHAR (128) NULL,
    [Bit Rate]             VARCHAR (128) NULL,
    [File extension]       VARCHAR (128) NULL,
    [Genre]                VARCHAR (128) NULL,
    [Length]               TIME (7)      NULL,
    [Favorite]             BIT           NULL,
    [Year]                 DATE          NULL
);


