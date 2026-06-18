CREATE TABLE Donors (
    DonorId     NVARCHAR(50)  PRIMARY KEY,
    FullName    NVARCHAR(100) NOT NULL,
    BloodGroup  NVARCHAR(5)   NOT NULL,
    DateOfBirth DATE          NOT NULL,
    Phone       NVARCHAR(20),
    Email       NVARCHAR(100),
    Address     NVARCHAR(200),
    LastDonated DATE,
    IsActive    BIT           DEFAULT 1
);

CREATE TABLE BloodUnits (
    UnitId       NVARCHAR(50)  PRIMARY KEY,
    BloodGroup   NVARCHAR(5)   NOT NULL,
    CollectedOn  DATE          NOT NULL,
    ExpiryDate   DATE          NOT NULL,
    DonorId      NVARCHAR(50),
    Status       NVARCHAR(20)  DEFAULT 'Available', 
    Quantity     INT           DEFAULT 1
);

CREATE TABLE BloodRequests (
    RequestId    NVARCHAR(50)  PRIMARY KEY,
    PatientName  NVARCHAR(100) NOT NULL,
    BloodGroup   NVARCHAR(5)   NOT NULL,
    UnitsNeeded  INT           NOT NULL,
    RequestDate  DATE          NOT NULL,
    RequiredBy   DATE,
    Status       NVARCHAR(20)  DEFAULT 'Pending',   
    Hospital     NVARCHAR(200),
    Notes        NVARCHAR(500)
);