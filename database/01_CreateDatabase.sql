/*
  Gym Management System - Database Schema
  WARNING: Running this script on an existing database will DROP and recreate all tables.
  All data in Users, Members, Payments, Machines, and MembershipPlans will be lost.
  Use only for initial setup or intentional reset in development.
*/

IF DB_ID(N'GymManagementSystem') IS NULL
BEGIN
    CREATE DATABASE GymManagementSystem;
END
GO

USE GymManagementSystem;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NOT NULL DROP TABLE dbo.Users;
IF OBJECT_ID(N'dbo.Payments', N'U') IS NOT NULL DROP TABLE dbo.Payments;
IF OBJECT_ID(N'dbo.Members', N'U') IS NOT NULL DROP TABLE dbo.Members;
IF OBJECT_ID(N'dbo.Machines', N'U') IS NOT NULL DROP TABLE dbo.Machines;
IF OBJECT_ID(N'dbo.MembershipPlans', N'U') IS NOT NULL DROP TABLE dbo.MembershipPlans;
GO

CREATE TABLE dbo.MembershipPlans
(
    PlanID          INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PlanName        NVARCHAR(100) NOT NULL,
    DurationMonths  INT NOT NULL CHECK (DurationMonths > 0),
    Price           DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    Description     NVARCHAR(500) NULL,
    Status          NVARCHAR(20) NOT NULL DEFAULT N'Active' CHECK (Status IN (N'Active', N'Inactive'))
);
GO

CREATE TABLE dbo.Members
(
    MemberID    INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName    NVARCHAR(150) NOT NULL,
    Phone       NVARCHAR(30) NULL,
    Gender      NVARCHAR(20) NULL,
    PlanID      INT NULL,
    StartDate   DATE NOT NULL,
    EndDate     DATE NOT NULL,
    Status      NVARCHAR(20) NOT NULL DEFAULT N'Active' CHECK (Status IN (N'Active', N'Expired', N'Inactive')),
    CONSTRAINT FK_Members_MembershipPlans
        FOREIGN KEY (PlanID) REFERENCES dbo.MembershipPlans(PlanID)
);
GO

CREATE TABLE dbo.Payments
(
    PaymentID   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MemberID    INT NOT NULL,
    PlanID      INT NULL,
    Amount      DECIMAL(10,2) NOT NULL CHECK (Amount >= 0),
    PaymentDate DATE NOT NULL,
    Status      NVARCHAR(20) NOT NULL CHECK (Status IN (N'Paid', N'Pending', N'Cancelled')),
    CONSTRAINT FK_Payments_Members
        FOREIGN KEY (MemberID) REFERENCES dbo.Members(MemberID) ON DELETE CASCADE,
    CONSTRAINT FK_Payments_MembershipPlans
        FOREIGN KEY (PlanID) REFERENCES dbo.MembershipPlans(PlanID)
);
GO

CREATE TABLE dbo.Machines
(
    MachineID     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MachineName   NVARCHAR(150) NOT NULL,
    Category      NVARCHAR(50) NOT NULL,
    PurchaseDate  DATE NOT NULL,
    [Condition]   NVARCHAR(50) NOT NULL,
    Status        NVARCHAR(20) NOT NULL CHECK (Status IN (N'Active', N'Inactive', N'Maintenance'))
);
GO

CREATE TABLE dbo.Users
(
    UserID            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName          NVARCHAR(150) NOT NULL,
    Email             NVARCHAR(150) NOT NULL UNIQUE,
    PasswordHash      NVARCHAR(256) NOT NULL,
    Role              NVARCHAR(30) NOT NULL CHECK (Role IN (N'Admin', N'Staff')),
    Status            NVARCHAR(20) NOT NULL DEFAULT N'Active' CHECK (Status IN (N'Active', N'Inactive')),
    EmailVerified     BIT NOT NULL DEFAULT 0,
    VerificationCode  NVARCHAR(10) NULL,
    CreatedAt         DATETIME NOT NULL DEFAULT GETDATE()
);
GO
