/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET
    ANSI_NULLS,
    ANSI_PADDING,
    ANSI_WARNINGS,
    ARITHABORT,
    CONCAT_NULL_YIELDS_NULL,
    QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;
GO

:setvar __IsSqlCmdEnabled "True"
:setvar DatabaseName "OneHasToDoThings"
GO

IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
    END;
GO

SET NOEXEC ON;
GO

SET XACT_ABORT ON;
GO

USE [$(DatabaseName)];
GO

BEGIN TRANSACTION;
    :r "..\Static-Data\TaskType.sql"
COMMIT TRANSACTION;
GO