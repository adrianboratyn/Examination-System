USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spResult_Get]    Script Date: 15.01.2020 09:22:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spResult_Get]
AS
BEGIN
	
	SET NOCOUNT ON;

	select * 
	from dbo.Result
   
END
