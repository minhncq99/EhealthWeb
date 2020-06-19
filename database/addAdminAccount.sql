USE [EhealthDB]
GO

INSERT INTO [dbo].[Users]
           ([FullName]
           ,[UserName]
           ,[Password]
           ,[Email]
           ,[Job]
           ,[TypeUser])
     VALUES
           ('admin'
           ,'admin'
           ,'Passw0rd'
           ,'admin@gmail.com'
           ,'admin'
           ,1)
GO


