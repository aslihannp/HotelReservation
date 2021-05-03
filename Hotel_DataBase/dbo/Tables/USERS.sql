﻿CREATE TABLE [dbo].[USERS] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [USER_NAME]    VARCHAR (50) NULL,
    [USER_SURNAME] VARCHAR (50) NULL,
    [USER_CODE]    VARCHAR (10) NULL,
    [PASSWORD]     VARCHAR (50) NULL,
    CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED ([ID] ASC)
);
