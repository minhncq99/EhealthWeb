USE [EhealthDB]
GO
/****** Object:  StoredProcedure [dbo].[percentDisease]    Script Date: 6/20/2020 3:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[percentDisease]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT b.VietnameseName , Count(a.DiseaseId) as 'SumDiseaseSaved'
	FROM Diseases_Users a inner join Diseases b on a.DiseaseId = b.DiseaseId
	WHERE a.Saved = 1
	GROUP By b.VietnameseName, b.DiseaseId
END