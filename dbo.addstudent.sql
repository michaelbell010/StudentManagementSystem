CREATE PROCEDURE dbo.AddStudent
	@Id int,
	@Name varchar(50),
	@Sname varchar(50),
	@Level bit,
	@Course varchar(100),
	@Address varchar(100),
	@Email varchar(100),
	@Phone varchar(50),
	@City varchar(50),
	@County varchar(50),
	@StudentNumber varchar(50)
AS
	
	BEGIN
	INSERT INTO dbo.[Table]
	(Name,
	Sname,
	Level,
	Course,
	Address,
	Email,
	Phone,
	City,
	County,
	StudentNumber)

	VALUES
	(
	@Id,
	@Name,
	@Sname,
	@Level,
	@Course,
	@Address,
	@Email,
	@Phone,
	@City ,
	@County,
	@StudentNumber 
	)

	END



