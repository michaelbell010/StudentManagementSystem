CREATE TABLE [dbo].[Student] (
    [Id]            INT           NOT NULL,
    [Name]          VARCHAR (50)  NULL,
    [Sname]         VARCHAR (50)  NULL,
    [Level]         BIT           NULL,
    [Course]        VARCHAR (100) NULL,
    [Address]       VARCHAR (100) NULL,
    [Email]         VARCHAR (100) NULL,
    [Phone]         VARCHAR (50)  NULL,
    [City]          VARCHAR (50)  NULL,
    [County]        VARCHAR (50)  NULL,
    [StudentNumber] VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

