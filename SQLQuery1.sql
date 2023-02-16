CREATE TABLE loginfrm
(
	userName VARCHAR(50),
	password VARCHAR(50)
)
Go
Select count(*) from loginfrm where userName="123" and password="123"
go