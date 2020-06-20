Create Trigger tg_ins_upd_CheckUser
On Users
For Insert, Update
As
If(UPDATE(TypeUser))
Begin
	If Not Exists(
		Select * From Inserted
		Where Inserted.TypeUser = 0 Or Inserted.TypeUser = 1)
	Begin
		raiserror (N'TypeUser không hợp lệ',0,1);
		rollback tran;
	End
End
