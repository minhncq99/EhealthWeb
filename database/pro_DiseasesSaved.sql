﻿USE [EhealthDB]
GO
/****** Object:  StoredProcedure [dbo].[DiseasesSaved]    Script Date: 6/20/2020 3:02:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[DiseasesSaved]
	-- Add the parameters for the stored procedure here
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select du.DiseaseId, d.EnglishName, d.VietnameseName
	from Diseases_Users du inner join Diseases d on du.DiseaseId = d.DiseaseId
	where du.UserId = @userId;
END
