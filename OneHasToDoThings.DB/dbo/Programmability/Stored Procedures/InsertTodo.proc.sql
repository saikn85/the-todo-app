CREATE PROCEDURE [dbo].[CreateToDo]
AS
BEGIN
    INSERT INTO [dbo].[Todo] 
        (
            TaskName, 
            TaskDescription, 
            TaskTypeId
        ) 
    VALUES
        (
            @TaskName,
            @TaskDescription,
            @TaskTypeId
        )
END;
GO