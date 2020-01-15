USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudent_Update]    Script Date: 15.01.2020 09:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spStudent_Update]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Age int,
	@School nvarchar(50),
	@DegreeCourse nvarchar(50),
	@OldUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    Update dbo.Student
	SET
	FirstName = @FirstName,
	LastName = @LastName,
	UserName = @UserName,
	Password = @Password,
	Age = @Age,
	School = @School,
	DegreeCourse = @DegreeCourse
	WHERE UserName = @OldUserName



END
