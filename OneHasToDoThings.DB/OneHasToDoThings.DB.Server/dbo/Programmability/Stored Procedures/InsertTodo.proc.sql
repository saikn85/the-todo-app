CREATE PROCEDURE [dbo].[CreateToDo]
(
    @TaskName           VARCHAR(30),
    @TaskDescription    VARCHAR(max),
    @TaskTypeId         SMALLINT
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