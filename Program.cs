
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using ConsoleAppFinalCore.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;

namespace ConsoleAppFinalCore
{
    class Program
    {
        static void Main()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection")).Options;
            using (ApplicationContext db = new ApplicationContext(options))
            {
                //  db.Database.EnsureDeleted();
                //  db.Database.EnsureCreated();

                //  db.Users.AddRange(
                //new User { Username = "Avramenko" },
                //    new User { Username = "Babenko" },
                //    new User { Username = "Didenko" },
                //    new User { Username = "Erenko" },
                //    new User { Username = "Kaluev" },
                //    new User { Username = "Limenok" }
                //);

                //  db.SaveChanges();

                //  var user1Id = db.Users.FirstOrDefault(u => u.Username == "Avramenko").UserId;
                //  var user2Id = db.Users.FirstOrDefault(u => u.Username == "Babenko").UserId;
                //  var user3Id = db.Users.FirstOrDefault(u => u.Username == "Didenko").UserId;
                //  var user4Id = db.Users.FirstOrDefault(u => u.Username == "Erenko").UserId;
                //  var user5Id = db.Users.FirstOrDefault(u => u.Username == "Kaluev").UserId;
                //  var user6Id = db.Users.FirstOrDefault(u => u.Username == "Limenok").UserId;

                //  db.Settings.AddRange(
                //      new Settings { UserId = user1Id },
                //      new Settings { UserId = user2Id },
                //      new Settings { UserId = user3Id },
                //      new Settings { UserId = user4Id },
                //      new Settings { UserId = user5Id },
                //      new Settings { UserId = user6Id }
                //  );

                //  db.Categories.AddRange(
                //new Category { Name = "Income" },
                //      new Category { Name = "Groceries" },
                //      new Category { Name = "Restaurant" },
                //      new Category { Name = "Utilities" },
                //      new Category { Name = "Entertainment" },
                //      new Category { Name = "Education" }
                //  );

                //  db.SaveChanges();

                //  db.Transactions.AddRange(
                //      new Transaction { UserId = user1Id, Type = TransactionType.Income, Amount = 100.00m, Description = "Salary", Date = DateTime.Now, CategoryId = 1 },
                //      new Transaction { UserId = user1Id, Type = TransactionType.Expense, Amount = 50.00m, Description = "Groceries", Date = DateTime.Now, CategoryId = 2 },
                //      new Transaction { UserId = user2Id, Type = TransactionType.Income, Amount = 150.00m, Description = "Freelance Work", Date = DateTime.Now, CategoryId = 1 },
                //      new Transaction { UserId = user3Id, Type = TransactionType.Expense, Amount = 75.00m, Description = "Restaurant", Date = DateTime.Now, CategoryId = 3 },
                //      new Transaction { UserId = user4Id, Type = TransactionType.Income, Amount = 200.00m, Description = "Investment Dividends", Date = DateTime.Now, CategoryId = 1 },
                //      new Transaction { UserId = user5Id, Type = TransactionType.Expense, Amount = 100.00m, Description = "Utilities", Date = DateTime.Now, CategoryId = 4 }
                //  );

                //  db.SaveChanges();
                //1)Пользователь может добавлять новые транзакции, указывая тип(доход или расход), сумму и описание.
                //int userId = 0;
                //int categoryId = 0;
                //Console.Write("Введите идентификатор пользователя: ");
                //userId = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Введите идентификатор категории: ");
                //categoryId = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Введите данные новой транзакции:");
                //Console.Write("Тип (1 - Доход, 2 - Расход): ");
                //int type = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Сумма: ");
                //decimal amount = Convert.ToDecimal(Console.ReadLine());
                //Console.Write("Описание: ");
                //string description = Console.ReadLine();
                //// новая транзакция
                //var newTransaction = new Transaction
                //{
                //    UserId = userId, 
                //    Type = (TransactionType)type,
                //    Amount = amount,
                //    Description = description,
                //    Date = DateTime.Now, 
                //    CategoryId = categoryId 
                //};
                //db.Transactions.Add(newTransaction);
                //db.SaveChanges();
                //Console.WriteLine("Новая транзакция успешно добавлена.");
                //2)Пользователь может просматривать список всех транзакций с указанием их типа, суммы и даты.
                //var transactions = db.Transactions.ToList();
                //Console.WriteLine("Список всех транзакций:");
                //foreach (var transaction in transactions)
                //{
                //    string transactionType = transaction.Type == TransactionType.Income ? "Доход" : "Расход";
                //    Console.WriteLine($"Тип: {transactionType}, Сумма: {transaction.Amount}, Дата: {transaction.Date}");
                //}
                //3)Пользователь может просматривать общую сумму доходов и расходов за определенный период времени. 
                //DateTime startDate = new DateTime(2024, 1, 1); 
                //DateTime endDate = new DateTime(2024, 02, 11); 

                //var transactions = db.Transactions
                //    .Where(t => t.Date >= startDate && t.Date <= endDate)
                //    .ToList();

                //decimal totalIncome = transactions
                //    .Where(t => t.Type == TransactionType.Income)
                //    .Sum(t => t.Amount);

                //decimal totalExpense = transactions
                //    .Where(t => t.Type == TransactionType.Expense)
                //    .Sum(t => t.Amount);

                //Console.WriteLine($"Общая сумма доходов за период: {totalIncome}");
                //Console.WriteLine($"Общая сумма расходов за период: {totalExpense}");
                //4)Пользователь может фильтровать транзакции по типу (доход или расход) и периоду времени. 
                //DateTime startDate = new DateTime(2024, 1, 1);
                //DateTime endDate = new DateTime(2024, 02, 11); 
                //int transactionType = 1; 
                //using (ApplicationContext db = new ApplicationContext(options))
                //{
                //    using (var command = db.Database.GetDbConnection().CreateCommand())
                //    {
                //        command.CommandText = "FilterTransactions";
                //        command.CommandType = CommandType.StoredProcedure;

                //        var transactionTypeParameter = command.CreateParameter();
                //        transactionTypeParameter.ParameterName = "@TransactionType";
                //        transactionTypeParameter.Value = transactionType;
                //        command.Parameters.Add(transactionTypeParameter);

                //        var startDateParameter = command.CreateParameter();
                //        startDateParameter.ParameterName = "@StartDate";
                //        startDateParameter.Value = startDate;
                //        command.Parameters.Add(startDateParameter);

                //        var endDateParameter = command.CreateParameter();
                //        endDateParameter.ParameterName = "@EndDate";
                //        endDateParameter.Value = endDate;
                //        command.Parameters.Add(endDateParameter);

                //        db.Database.OpenConnection();

                //        using (var reader = command.ExecuteReader())
                //        {
                //            while (reader.Read())
                //            {
                //                int transactionId = reader.GetInt32(0); 
                //                DateTime transactionDate = reader.GetDateTime(5); 
                //                decimal transactionAmount = reader.GetDecimal(3); 
                //                Console.WriteLine($"Transaction ID: {transactionId}");
                //                Console.WriteLine($"Transaction Date: {transactionDate}");
                //                Console.WriteLine($"Transaction Amount: {transactionAmount}");
                //                Console.WriteLine();
                //            }
                //5)Пользователь может получать отчет о текущем состоянии своих финансов, включая общий доход, расход, баланс и статистику по категориям транзакций
                //using (var connection = new SqlConnection(config.GetConnectionString("DefaultConnection")))
                //{
                //    connection.Open();

                //    using (var command = new SqlCommand("GetFinancialReport", connection))
                //    {
                //        command.CommandType = CommandType.StoredProcedure;

                //        using (var reader = command.ExecuteReader())
                //        {
                //            if (reader.HasRows)
                //            {
                //                while (reader.Read())
                //                {
                //                    decimal totalIncome = reader.GetDecimal(0);
                //                    decimal totalExpense = reader.GetDecimal(1);
                //                    decimal balance = reader.GetDecimal(2);

                //                    Console.WriteLine("Total Income: " + totalIncome);
                //                    Console.WriteLine("Total Expense: " + totalExpense);
                //                    Console.WriteLine("Balance: " + balance);
                //                }
                //            }
                //            else
                //            {
                //                Console.WriteLine("No data found.");
                //            }

            }
        }



public class ApplicationContext : DbContext
        {
            public DbSet<Category> Categories { get; set; }
            public DbSet<Settings> Settings { get; set; }
            //public DbSet<Transaction> Transactions { get; set; }
            public DbSet<User> Users { get; set; }

            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>()
                    .HasOne(u => u.Settings)
                    .WithOne(s => s.User)
                    .HasForeignKey<Settings>(s => s.UserId);

                modelBuilder.Entity<User>()
                    .HasMany(u => u.Transactions)
                    .WithOne(t => t.User)
                    .HasForeignKey(t => t.UserId);

                //modelBuilder.Entity<Transaction>()
                //    .HasOne(t => t.Category)
                //    .WithMany(c => c.Transactions)
                //    .HasForeignKey(t => t.CategoryId);
            }
        }
    }
}
    








