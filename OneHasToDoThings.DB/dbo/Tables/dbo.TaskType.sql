CREATE TABLE [dbo].[TaskType] (
    [TaskTypeId]      SMALLINT     IDENTITY (1, 1) NOT NULL,
    [TaskDescription] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TaskType_TaskTypeId] PRIMARY KEY CLUSTERED ([TaskTypeId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UX_TaskType_NC]
    ON [dbo].[TaskType]([TaskDescription] ASC);

