USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spExam_Get]    Script Date: 15.01.2020 09:20:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spExam_Get]
AS
BEGIN
	
	SET NOCOUNT ON;

	select AccessCode, Creator, Name, NumberOfQuestions
	from dbo.Exam
   
END
