USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spAdmin_Check]    Script Date: 15.01.2020 09:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spAdmin_Check]
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    select *
	from dbo.Admin
	where UserName = @Username AND Password = @Password
	RETURN @@ROWCOUNT

END
