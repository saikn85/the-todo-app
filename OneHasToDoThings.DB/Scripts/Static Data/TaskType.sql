SET IDENTITY_INSERT [dbo].[TaskType] ON;
GO

;WITH
N (TaskTypeId, TaskDescription) AS 
	(
		SELECT
			1		AS	TaskTypeId,
			N'New'	AS	TaskDescription
	)
MERGE [dbo].[TaskType] O
USING N ON O.[TaskTypeId] = N.[TaskTypeId]
WHEN MATCHED		THEN	UPDATE SET O.[TaskDescription] = N.[TaskDescription]
WHEN NOT MATCHED	THEN	INSERT
	(
		TaskTypeId, TaskDescription
	)
	VALUES
	(
		N.[TaskTypeId], N.[TaskDescription]
	)
WHEN NOT MATCHED BY SOURCE THEN DELETE;
GO

SET IDENTITY_INSERT [dbo].[TaskType] OFF;
GO