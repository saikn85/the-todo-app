CREATE PROCEDURE [dbo].[CreateToDo]
(
    @TaskName VARCHAR(20),
    @TaskDescrption VARCHAR(MAX),
    @TaskTypeId SMALLIN
)
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