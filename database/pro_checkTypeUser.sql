﻿USE [EhealthDB]
GO
/****** Object:  StoredProcedure [dbo].[checkTypeUser]    Script Date: 6/20/2020 3:02:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- run : exec checkTypeUser 1
-- =============================================
Create PROCEDURE [dbo].[checkTypeUser] 
	-- Add the parameters for the stored procedure here
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select u.TypeUser
	from Users u
	where u.UserId = @userId;
END
