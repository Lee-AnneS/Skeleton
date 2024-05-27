CREATE PROCEDURE sproc_tblStaff_Update
	--create the parameters for the stored procedure
	@StaffId int,
	@StaffFullName varchar (50), 
	@StaffDoB date,
	@StaffEmail varchar (75),
	@NINumber varchar (9),
	@Salary decimal (18, 2),
	@PresentInBuilding bit  
AS
	--update the new record as specified by the @StaffId value
	UPDATE tblStaff
	SET
	StaffId=@StaffId, 
	StaffFullName=@StaffFullName,
	StaffDoB=@StaffDoB, 
	StaffEmail=@StaffEmail, 
	NINumber=@NINumber,
	Salary=@Salary, 
	PresentInBuilding=@PresentInBuilding
	
	WHERE StaffId=@StaffId