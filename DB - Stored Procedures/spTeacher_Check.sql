USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spTeacher_Check]    Script Date: 15.01.2020 09:26:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeacher_Check]
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    select *
	from dbo.Teacher
	where UserName = @Username AND Password = @Password
	RETURN @@ROWCOUNT

END
