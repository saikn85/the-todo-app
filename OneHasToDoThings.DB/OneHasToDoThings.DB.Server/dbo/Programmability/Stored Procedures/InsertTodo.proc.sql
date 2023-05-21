CREATE PROCEDURE [dbo].[InsertToDo]
(
    @TaskName VARCHAR(20),
    @TaskDescription VARCHAR(MAX),
    @TaskTypeId SMALLINT
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