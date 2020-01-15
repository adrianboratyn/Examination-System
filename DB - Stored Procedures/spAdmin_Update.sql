USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spAdmin_Update]    Script Date: 15.01.2020 09:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spAdmin_Update]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@OldUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    Update dbo.Admin
	SET
	FirstName = @FirstName,
	LastName = @LastName,
	UserName = @UserName,
	Password = @Password
	WHERE UserName = @OldUserName

	

END
