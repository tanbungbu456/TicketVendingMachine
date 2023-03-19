CREATE DATABASE TicketVendingMachine;
go

CREATE TABLE Tickets (
   TicketID INT PRIMARY KEY,
   TicketType VARCHAR(50) NOT NULL,
   Price DECIMAL(10,2) NOT NULL,
   Quantity INT NOT NULL,
   AvailableQuantity INT NOT NULL
);
GO

CREATE TABLE Transactions (
   TransactionID INT PRIMARY KEY,
   TicketID INT NOT NULL,
   Quantity INT NOT NULL,
   TotalPrice DECIMAL(10,2) NOT NULL,
   PurchaseDateTime DATETIME NOT NULL,
   FOREIGN KEY (TicketID) REFERENCES Tickets (TicketID)
);
GO

CREATE TABLE TicketPurchase (
	TicketType varchar(20) not null,
	NumberOfTickets int not null,
	PaymentMethod varchar(20) not null
)
go