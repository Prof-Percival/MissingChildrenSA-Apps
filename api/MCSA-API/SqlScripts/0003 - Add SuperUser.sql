DECLARE @Now DATETIME2 = GETDATE();

INSERT INTO [User] (Username, PasswordHash, FirstName, LastName, RoleId, Created, Updated)
VALUES ('superuser@mcsa.org.za', 'AQAAAAIAAYagAAAAEN0OlCxUpcv0+H8sCgdU9er9VBCc5dFHaN1Itx6kxPLVjlgh5XL7EVQecaqZyeJ59g==', 'Super', 'User', 1, @Now, @Now)