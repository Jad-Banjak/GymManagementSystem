-- Quick validation script for demo data and dashboard queries

USE GymManagementSystem;
GO

PRINT '=== Table counts ===';
SELECT 'MembershipPlans' AS [Table], COUNT(*) AS [Rows] FROM dbo.MembershipPlans
UNION ALL SELECT 'Users', COUNT(*) FROM dbo.Users
UNION ALL SELECT 'Members', COUNT(*) FROM dbo.Members
UNION ALL SELECT 'Payments', COUNT(*) FROM dbo.Payments
UNION ALL SELECT 'Machines', COUNT(*) FROM dbo.Machines;

PRINT '=== Dashboard: monthly revenue ===';
SELECT ISNULL(SUM(Amount), 0) AS MonthlyRevenue
FROM dbo.Payments
WHERE YEAR(PaymentDate) = YEAR(GETDATE()) AND MONTH(PaymentDate) = MONTH(GETDATE());

PRINT '=== Dashboard: expiring within 7 days ===';
SELECT MemberID, FullName, EndDate, Status
FROM dbo.Members
WHERE TRY_CONVERT(date, EndDate) >= CAST(GETDATE() AS date)
  AND TRY_CONVERT(date, EndDate) <= DATEADD(day, 7, CAST(GETDATE() AS date))
ORDER BY EndDate;

PRINT '=== Active members ===';
SELECT COUNT(*) AS ActiveMembers FROM dbo.Members WHERE Status = N'Active';

GO
