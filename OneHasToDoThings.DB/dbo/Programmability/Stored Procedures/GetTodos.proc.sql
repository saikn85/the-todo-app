CREATE PROCEDURE [dbo].[GetTodos]
AS
BEGIN
	SELECT 
		[T1].[Id] AS Id,
		[T1].[TaskName] AS Task,
		[T2].[TaskDescription] AS N'Task Details',
		[T1].[TaskDescription] AS N'Task Type',
		[T1].[Created],
		[T1].[Completed]
	FROM [dbo].[Todo] AS T1
	INNER JOIN [dbo].[TaskType] AS T2 ON [T2].[TaskTypeId] = [T1].[TypeId]
END;
GO