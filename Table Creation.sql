CREATE TABLE [User](
	username VARCHAR(255) PRIMARY KEY,
	name VARCHAR(255),
	[password] VARCHAR(255),
	[role] VARCHAR(255),
	birthday DATE
)
GO
CREATE TABLE Product(
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255),
	price MONEY,
	stock INT
)
GO
CREATE TABLE HeaderTransaction(
	id INT PRIMARY KEY IDENTITY(1, 1),
	[user_id] VARCHAR(255),
	occurance DATETIME,
	FOREIGN KEY ([user_id]) REFERENCES [User](username)
)
GO
CREATE TABLE DetailTransaction(
	trans_id INT,
	product_id INT,
	price MONEY,
	stock INT,
	FOREIGN KEY (trans_id) REFERENCES HeaderTransaction(id),
	FOREIGN KEY (product_id) REFERENCES Product(id)
)
GO