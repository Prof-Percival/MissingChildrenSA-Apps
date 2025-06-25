-- Create User table
CREATE TABLE [User] (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(255) NOT NULL,
    PasswordHash NVARCHAR(256) NOT NULL,
    FirstName NVARCHAR(150) NOT NULL,
    LastName NVARCHAR(150) NOT NULL,
    RoleId INT NOT NULL,
    Created DATETIME2 NOT NULL,
    Updated DATETIME2 NOT NULL,
    CONSTRAINT UQ_User_Username UNIQUE (Username)
);

-- Create MissingPerson table with temporal versioning
CREATE TABLE [MissingPerson] (
    Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    FirstName NVARCHAR(150) NOT NULL,
    LastName NVARCHAR(150) NOT NULL,
    DateOfBirth DATETIME2 NOT NULL,
    GenderId INT NOT NULL,
    RaceId INT NOT NULL,
    ProvinceId INT NOT NULL,
    DateWentMissing DATETIME2 NOT NULL,
    HairColour NVARCHAR(50) NOT NULL,
    HairLengthOrStyle NVARCHAR(50) NOT NULL,
    EyeColour NVARCHAR(50) NOT NULL,
    Height INT NOT NULL,
    Weight FLOAT NOT NULL,
    MarksTattoos NVARCHAR(100) NOT NULL,
    LastSeenWearing NVARCHAR(500) NOT NULL,
    LocationLastSeen NVARCHAR(150) NOT NULL,
    DetailsOfDisappearance NVARCHAR(500) NOT NULL,
    ImageUrl NVARCHAR(500) NOT NULL,
    PoliceStation NVARCHAR(250) NOT NULL,
    CaseNumber NVARCHAR(50) NOT NULL,
    InvestigatingOfficer NVARCHAR(300) NOT NULL,
    InvestigatingOfficerContactNumber NVARCHAR(15) NOT NULL,
    FamilyContactName NVARCHAR(300) NOT NULL,
    FamilyContactNumber NVARCHAR(15) NOT NULL,
    StatusId INT NOT NULL,
    Created DATETIME2 NOT NULL,
    Updated DATETIME2 NOT NULL,
    ModerationStatusId INT NOT NULL,
    LastEditedByUserId INT NULL,
    SysEndTime DATETIME2 NOT NULL,
    SysStartTime DATETIME2 NOT NULL,
    CONSTRAINT FK_MissingPerson_LastEditedByUserId FOREIGN KEY (LastEditedByUserId) REFERENCES [User](Id),
    CONSTRAINT PK_MissingPerson_Id PRIMARY KEY (Id),
    PERIOD FOR SYSTEM_TIME (SysStartTime, SysEndTime)
) 
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = [dbo].[MissingPersonHistory]));

-- Create MissingPersonModerationQueue table with temporal versioning
CREATE TABLE [MissingPersonModerationQueue] (
    Id INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
    Created DATETIME2 NOT NULL,
    Updated DATETIME2 NOT NULL,
    ModeratedByUserId INT NULL,
    ModerationStatusId INT NOT NULL,
    ModerationStatusReason NVARCHAR(255) NULL,
    MissingPersonId INT NOT NULL,
    SysEndTime DATETIME2 NOT NULL,
    SysStartTime DATETIME2 NOT NULL,
    CONSTRAINT FK_MissingPersonModerationQueue_MissingPersonId FOREIGN KEY (MissingPersonId) REFERENCES [MissingPerson](Id),
    CONSTRAINT FK_MissingPersonModerationQueue_ModeratedByUserId FOREIGN KEY (ModeratedByUserId) REFERENCES [User](Id),
    CONSTRAINT PK_MissingPersonModerationQueue_Id PRIMARY KEY (Id),
    PERIOD FOR SYSTEM_TIME (SysStartTime, SysEndTime)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = [dbo].[MissingPersonModerationQueueHistory]));

-- Create Indexes
CREATE INDEX IX_MissingPerson_LastEditedByUserId ON [MissingPerson] (LastEditedByUserId);
CREATE INDEX IX_MissingPersonModerationQueue_MissingPersonId ON [MissingPersonModerationQueue] (MissingPersonId);
CREATE INDEX IX_MissingPersonModerationQueue_ModeratedByUserId ON [MissingPersonModerationQueue] (ModeratedByUserId);
