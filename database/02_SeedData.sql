-- Gym Management System - Extended demo / portfolio seed data
-- Run AFTER 01_CreateDatabase.sql (or on empty tables)
-- Demo password for all users below: Admin123!
-- SHA-256 hash from PasswordHelper.cs

USE GymManagementSystem;
GO

SET NOCOUNT ON;

-- ==================== MEMBERSHIP PLANS ====================
INSERT INTO dbo.MembershipPlans (PlanName, DurationMonths, Price, Description, Status)
VALUES
    (N'Monthly Basic', 1, 29.99, N'Gym floor access', N'Active'),
    (N'Quarterly Pro', 3, 79.99, N'Floor access + group classes', N'Active'),
    (N'Annual Elite', 12, 299.99, N'Full access + personal trainer session', N'Active'),
    (N'Student Monthly', 1, 19.99, N'Valid student ID required', N'Active'),
    (N'Family Pack', 6, 149.99, N'Two adults + one junior member', N'Inactive');
GO

-- ==================== USERS ====================
DECLARE @Pwd NVARCHAR(256) = N'3eb3fe66b31e3b4d10fa70b5cad49c7112294af6ae4e476a1c405155d45aa121';

INSERT INTO dbo.Users (FullName, Email, PasswordHash, Role, Status, EmailVerified)
VALUES
    (N'System Administrator', N'admin@gym.local', @Pwd, N'Admin', N'Active', 1),
    (N'Alex Rivera', N'staff@gym.local', @Pwd, N'Staff', N'Active', 1),
    (N'Morgan Lee', N'morgan@gym.local', @Pwd, N'Staff', N'Active', 1),
    (N'Jordan Kim', N'jordan@gym.local', @Pwd, N'Staff', N'Inactive', 1);
GO

-- ==================== MEMBERS (customers) ====================
DECLARE @Today DATE = CAST(GETDATE() AS DATE);

INSERT INTO dbo.Members (FullName, Phone, Gender, PlanID, StartDate, EndDate, Status)
VALUES
    (N'John Smith', N'+1 555 0101', N'Male', 1, @Today, DATEADD(MONTH, 1, @Today), N'Active'),
    (N'Jane Doe', N'+1 555 0102', N'Female', 2, @Today, DATEADD(MONTH, 3, @Today), N'Active'),
    (N'Emily Carter', N'+1 555 0103', N'Female', 3, @Today, DATEADD(MONTH, 12, @Today), N'Active'),
    (N'Michael Brown', N'+1 555 0104', N'Male', 1, DATEADD(MONTH, -2, @Today), DATEADD(DAY, 3, @Today), N'Active'),
    (N'Sarah Wilson', N'+1 555 0105', N'Female', 2, DATEADD(MONTH, -1, @Today), DATEADD(DAY, 5, @Today), N'Active'),
    (N'David Martinez', N'+1 555 0106', N'Male', 4, @Today, DATEADD(MONTH, 1, @Today), N'Active'),
    (N'Olivia Taylor', N'+1 555 0107', N'Female', 1, DATEADD(MONTH, -6, @Today), DATEADD(MONTH, -1, @Today), N'Expired'),
    (N'James Anderson', N'+1 555 0108', N'Male', 2, DATEADD(YEAR, -1, @Today), DATEADD(MONTH, -2, @Today), N'Expired'),
    (N'Sophia Thomas', N'+1 555 0109', N'Female', 3, DATEADD(MONTH, -3, @Today), DATEADD(DAY, -10, @Today), N'Expired'),
    (N'Liam Johnson', N'+1 555 0110', N'Male', 1, DATEADD(MONTH, -1, @Today), DATEADD(MONTH, 2, @Today), N'Inactive'),
    (N'Ava Garcia', N'+1 555 0111', N'Female', 2, @Today, DATEADD(MONTH, 3, @Today), N'Active'),
    (N'Noah Davis', N'+1 555 0112', N'Male', 3, DATEADD(DAY, -15, @Today), DATEADD(DAY, 6, @Today), N'Active');
GO

-- ==================== PAYMENTS ====================
DECLARE @Today DATE = CAST(GETDATE() AS DATE);

INSERT INTO dbo.Payments (MemberID, PlanID, Amount, PaymentDate, Status)
VALUES
    (1, 1, 29.99, @Today, N'Paid'),
    (2, 2, 79.99, @Today, N'Paid'),
    (3, 3, 299.99, @Today, N'Paid'),
    (4, 1, 29.99, DATEADD(DAY, -5, @Today), N'Paid'),
    (5, 2, 79.99, DATEADD(DAY, -3, @Today), N'Pending'),
    (6, 4, 19.99, @Today, N'Paid'),
    (7, 1, 29.99, DATEADD(MONTH, -1, @Today), N'Paid'),
    (8, 2, 79.99, DATEADD(MONTH, -2, @Today), N'Cancelled'),
    (9, 3, 299.99, DATEADD(MONTH, -3, @Today), N'Paid'),
    (10, 1, 29.99, DATEADD(DAY, -10, @Today), N'Paid'),
    (11, 2, 79.99, DATEADD(DAY, -1, @Today), N'Paid'),
    (12, 3, 299.99, DATEADD(DAY, -7, @Today), N'Pending'),
    (1, 1, 29.99, DATEADD(MONTH, -1, @Today), N'Paid'),
    (2, 2, 79.99, DATEADD(MONTH, -1, @Today), N'Paid'),
    (3, 3, 299.99, DATEADD(MONTH, -1, @Today), N'Paid'),
    (4, 1, 29.99, @Today, N'Paid'),
    (5, 2, 40.00, DATEADD(DAY, -14, @Today), N'Paid'),
    (11, 2, 79.99, @Today, N'Paid'),
    (12, 3, 150.00, DATEADD(DAY, -2, @Today), N'Paid');
GO

-- ==================== MACHINES ====================
DECLARE @Today DATE = CAST(GETDATE() AS DATE);

INSERT INTO dbo.Machines (MachineName, Category, PurchaseDate, [Condition], Status)
VALUES
    (N'Treadmill A1', N'Cardio', DATEADD(YEAR, -1, @Today), N'Good', N'Active'),
    (N'Treadmill A2', N'Cardio', DATEADD(YEAR, -2, @Today), N'Excellent', N'Active'),
    (N'Elliptical B1', N'Cardio', DATEADD(MONTH, -8, @Today), N'Good', N'Maintenance'),
    (N'Rowing Machine C1', N'Cardio', DATEADD(YEAR, -3, @Today), N'Needs Maintenance', N'Inactive'),
    (N'Bench Press B2', N'Strength', DATEADD(YEAR, -2, @Today), N'Excellent', N'Active'),
    (N'Squat Rack S1', N'Strength', DATEADD(YEAR, -4, @Today), N'Good', N'Active'),
    (N'Leg Press L1', N'Strength', DATEADD(MONTH, -14, @Today), N'Good', N'Active'),
    (N'Cable Crossover C2', N'Strength', DATEADD(MONTH, -6, @Today), N'Out of Order', N'Maintenance'),
    (N'Dumbbell Set 5-50kg', N'Free Weights', DATEADD(YEAR, -5, @Today), N'Excellent', N'Active'),
    (N'Kettlebell Rack', N'Free Weights', DATEADD(YEAR, -1, @Today), N'Good', N'Active'),
    (N'Spin Bike SB3', N'Cardio', DATEADD(MONTH, -3, @Today), N'Good', N'Active'),
    (N'Smith Machine M1', N'Strength', DATEADD(YEAR, -6, @Today), N'Needs Maintenance', N'Inactive');
GO

PRINT 'Demo data loaded successfully.';
GO
