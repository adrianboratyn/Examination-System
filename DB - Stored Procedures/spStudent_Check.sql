USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudent_Check]    Script Date: 15.01.2020 09:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spStudent_Check]
		@UserName nvarchar(50),
		@Password nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

	select *
	from dbo.Student
	where UserName = @Username AND Password = @Password
	RETURN @@ROWCOUNT
    
END
