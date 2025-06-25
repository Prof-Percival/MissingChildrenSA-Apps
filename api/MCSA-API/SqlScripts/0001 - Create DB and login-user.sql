CREATE Database [MissingChildrenSA];

-- Create a new login at the SQL Server level
CREATE LOGIN [mcsa-user] WITH PASSWORD = 'Your String Password';

--You might have to manually switch to the DB
USE [MissingChildrenSA];

-- Create a user in the specific database for the new login
CREATE USER [mcsa-user] FOR LOGIN [mcsa-user];

ALTER USER [mcsa-user] WITH DEFAULT_SCHEMA = dbo;

GRANT ALTER ON SCHEMA::dbo TO [mcsa-user];

GRANT REFERENCES TO [mcsa-user];
GRANT CREATE PROCEDURE TO [mcsa-user];
GRANT CREATE VIEW TO [mcsa-user];

-- Grant necessary permissions
-- Adjust the permissions as needed
ALTER ROLE db_datareader ADD MEMBER [mcsa-user]; -- Allows read access
ALTER ROLE db_datawriter ADD MEMBER [mcsa-user]; -- Allows write access
--ALTER ROLE db_owner ADD MEMBER [mcsa-user]; -- Grants full control (optional, use with caution)

-- Optionally, grant execute permissions on all stored procedures
GRANT EXECUTE TO [mcsa-user];

-- For the Migration to Work
GRANT CREATE TABLE TO [mcsa-user];

-- Optional: If you have specific schemas, grant permissions accordingly
-- GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::[YourSchemaName] TO [mcsa-user];
