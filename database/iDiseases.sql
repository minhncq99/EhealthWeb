-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- run : exec iDiseases 1
-- =============================================
CREATE PROCEDURE iDiseases 
	-- Add the parameters for the stored procedure here
	@diseaseId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select c.ChapterId,
		c.Name as 'ChapterName',
		g.GroupId,
		g.Name as 'GroupName',
		n.NumberId,
		n.Name as 'NumberName',
		d.DiseaseId,
		d.EnglishName,
		d.VietnameseName
		from Diseases d inner join Numbers n on d.NumberId = n.NumberId 
		inner join Groups g on n.GroupId = g.GroupId 
		inner join Chapters c on g.ChapterId = c.ChapterId
		where d.DiseaseId = @diseaseId;
END
GO
