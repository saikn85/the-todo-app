﻿CREATE TABLE [dbo].[Todo]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[TaskName] VARCHAR (100) NOT NULL,
	[TaskDescription] VARCHAR (MAX) NOT NULL,
	[Created] DATETIMEOFFSET NOT NULL DEFAULT GETDATE(),
	[TaskTypeId] SMALLINT NOT NULL,
	[Completed] DATETIMEOFFSET NOT NULL DEFAULT '0001-01-01 00:00:00.0000000 +00:00',
    CONSTRAINT [PK_Todo_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Todo_TaskType] FOREIGN KEY ([TaskTypeId])
	REFERENCES [dbo].[TaskType] ([TaskTypeId]) ON DELETE NO ACTION	ON UPDATE CASCADE
);
GO

CREATE UNIQUE NONCLUSTERED INDEX [UX_Todo_NC]
    ON [dbo].[Todo]([TaskName] ASC);
GO