CREATE PROCEDURE GetFinancialReport
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TotalIncome DECIMAL(18, 2);
    DECLARE @TotalExpense DECIMAL(18, 2);
    DECLARE @Balance DECIMAL(18, 2);

    
    SELECT @TotalIncome = ISNULL(SUM(Amount), 0)
    FROM Transactions
    WHERE Type = 1; 

    
    SELECT @TotalExpense = ISNULL(SUM(Amount), 0)
    FROM Transactions
    WHERE Type = 2;

   
    SET @Balance = @TotalIncome - @TotalExpense;

    
    SELECT @TotalIncome AS TotalIncome, @TotalExpense AS TotalExpense, @Balance AS Balance;
END