SET IDENTITY_INSERT [dbo].[TaskType] ON;
GO

;WITH
[New] (TaskTypeId, TaskDescription) AS 
	(
		SELECT
			1		AS	TaskTypeId,
			N'New'	AS	TaskDescription
	)
MERGE [dbo].[TaskType] [Old]
USING [New] ON [Old].[TaskTypeId] = [New].[TaskTypeId]
WHEN MATCHED		THEN	UPDATE SET [Old].[TaskDescription] = [New].[TaskDescription]
WHEN NOT MATCHED	THEN	INSERT
	(
		TaskTypeId, TaskDescription
	)
	VALUES
	(
		[New].[TaskDescription], [New].[TaskDescription]
	)
WHEN NOT MATCHED BY SOURCE THEN DELETE;
GO

SET IDENTITY_INSERT [dbo].[TaskType] OFF;
GO