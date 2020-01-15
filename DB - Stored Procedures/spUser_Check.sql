USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spUser_Check]    Script Date: 15.01.2020 09:28:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spUser_Check]
	@UserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    select *
	from dbo.Users
	where UserName = @Username
	RETURN @@ROWCOUNT

END
