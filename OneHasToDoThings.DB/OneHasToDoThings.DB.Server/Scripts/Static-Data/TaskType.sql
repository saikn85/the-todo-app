SET IDENTITY_INSERT [dbo].[TaskType] ON;
GO

;WITH
[New] (TaskTypeId, TaskDescription) AS
(
	SELECT
		1 AS TaskTypeId,
		'New' AS TaskDescription
	UNION ALL
	SELECT
		2 AS TaskTypeId,
		'In Progress' AS TaskDescription
	UNION ALL
	SELECT
		3 AS TaskTypeId,
		'Completed' AS TaskDescription
)
MERGE [dbo].[TaskType] [Old]
USING [New] ON [Old].[TaskTypeId] = [New].[TaskTypeId]
WHEN MATCHED THEN UPDATE SET [Old].[TaskDescription] = [New].[TaskDescription]
WHEN NOT MATCHED THEN INSERT
	(
		TaskTypeId, TaskDescription
	)
VALUES
	(
		[New].[TaskTypeId], [New].[TaskDescription]
	)
WHEN NOT MATCHED BY SOURCE THEN DELETE;
GO

SET IDENTITY_INSERT [dbo].[TaskType] OFF;
GO