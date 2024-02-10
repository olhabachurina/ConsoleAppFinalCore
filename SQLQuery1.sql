CREATE PROCEDURE FilterTransactions
    @TransactionType INT, 
    @StartDate DATETIME, 
    @EndDate DATETIME 
AS
BEGIN
    SET NOCOUNT ON;

    IF @TransactionType = 1 
    BEGIN
        SELECT * FROM Transactions
        WHERE Type = @TransactionType
        AND Date >= @StartDate AND Date <= @EndDate;
    END
    ELSE IF @TransactionType = 2 
    BEGIN
        SELECT * FROM Transactions
        WHERE Type = @TransactionType
        AND Date >= @StartDate AND Date <= @EndDate;
    END
END