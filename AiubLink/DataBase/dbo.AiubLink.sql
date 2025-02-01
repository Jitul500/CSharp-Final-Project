CREATE TABLE [dbo].[AiubLink] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50)    NULL,
    [Phone]    INT             NULL,
    [UserID]   VARCHAR (50)    NULL,
    [Email]    VARCHAR (50)    NULL,
    [Photo]    VARBINARY (MAX) NULL,
    [DOB]      DATETIME        NULL,
    [Password] VARCHAR (50)    NULL,
    [Role]     VARCHAR (50)    NULL,
    [Status] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

