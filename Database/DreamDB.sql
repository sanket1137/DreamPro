create database DreamHotel
use dreamHotel

create table Employee
(
Emp_id int primary key,
Emp_name varchar(25),
Adhar_No bigint NOT NULL UNIQUE ,
Salary int,
joining_Date date,
Acc_Password varchar(8),
Designation varchar(20)

)

create table Guest
(
G_name varchar(25),
No_Checkin int,
Checkin_Date date,
Checkout_Date date,
P_Amount int, 
Room_No int,
Adhar_No bigint NOT NULL UNIQUE ,
Duration int,
foreign key (Room_no) references Arooms(RoomNo)

 )

 insert into Guest values('an',102,'14-3-2019','15-09-2012 ',3000, 321,134456789122,33)







 select * from employee where emp_id=111 and emp_name='head'
 create table Veg_Menu
 (
 Break_Fast varchar(100),
 Lunch varchar(100),
 Dinner varchar(100),
 Desserts varchar(100)
 )
  create table Non_Veg_Menu
 (
 Break_Fast varchar(100),
 Lunch varchar(100),
 Dinner varchar(100),
 Desserts varchar(100)
 )
  select * from Non_Veg_Menu
  select * from Veg_Menu

 create table RCharges
 (
 Ac int,
 NonAc int,
 Suite Int
 )

 insert into RCharges values(12000,7000,15000)
 alter table Employee ADD Designation varchar(20)

    insert into  Employee values(111,'Head',000011110000,60000,'Dream','Main')
	select * from Employee
	select * from Guest
	select * from Menu

	alter table Guest ADD Adhar_No int
	select * from Guest

	 alter table Guest 
	 Add primary key(RoomNo)
	 select * from Guest
	delete from RCharges
	 alter table [Guest]
	 DROP column [RoomNo]

	 alter table Guest
	 alter table Guest ADD RoomNo PRIMARY KEY 
	 alter table Guest 
	 ADD  PRIMARY KEY (RoomNo)

	 	 alter table Arooms 
	 ADD   RoomNo INT PRIMARY KEY
	 alter table Employee Drop column Post 
	 create table Arooms
	 (
	 Class varchar(10),
	 RoomNo int primary key,
	 G_name varchar(30),
	 Duration int
	 
	 )
	 select * from Arooms
	 select * from Employee
	 drop table RCharges
	alter table Employee ADD Post Varchar(20)
	alter table Employee ADD Joining_Date Date

	 Insert into Arooms values('AC',101,'NULL',0),('AC',102,'NULL',0),('AC',103,'NULL',0),('AC',104,'NULL',0),('AC',105,'NULL',0),('AC',106,'NULL',0),('AC',107,'NULL',0),('AC',108,'NULL',0),('AC',109,'NULL',0),('AC',110,'NULL',0),
							  ('AC',111,'NULL',0),('AC',112,'NULL',0),('AC',113,'NULL',0),('AC',114,'NULL',0),('AC',115,'NULL',0),('AC',116,'NULL',0),('AC',117,'NULL',0),('AC',118,'NULL',0),('AC',119,'NULL',0),('AC',120,'NULL',0),
							  ('AC',121,'NULL',0),('AC',122,'NULL',0),('AC',123,'NULL',0),('AC',124,'NULL',0),('AC',125,'NULL',0),('AC',126,'NULL',0),('AC',127,'NULL',0),('AC',128,'NULL',0),('AC',129,'NULL',0),('AC',130,'NULL',0),
							  ('NonAc',201,'NULL',0),('NonAc',202,'NULL',0),('NonAc',203,'NULL',0),('NonAc',204,'NULL',0),('NonAc',205,'NULL',0),('NonAc',206,'NULL',0),('NonAc',207,'NULL',0),('NonAc',208,'NULL',0),('NonAc',209,'NULL',0),('NonAc',210,'NULL',0),
							  ('NonAc',211,'NULL',0),('NonAc',212,'NULL',0),('NonAc',213,'NULL',0),('NonAc',214,'NULL',0),('NonAc',215,'NULL',0),('NonAc',216,'NULL',0),('NonAc',217,'NULL',0),('NonAc',218,'NULL',0),('NonAc',219,'NULL',0),('NonAc',220,'NULL',0),
							  ('NonAc',221,'NULL',0),('NonAc',222,'NULL',0),('NonAc',223,'NULL',0),('NonAc',224,'NULL',0),('NonAc',225,'NULL',0),('NonAc',226,'NULL',0),('NonAc',227,'NULL',0),('NonAc',228,'NULL',0),('NonAc',229,'NULL',0),('NonAc',230,'NULL',0),
							  ('Suite',301,'NULL',0),('Suite',302,'NULL',0),('Suite',303,'NULL',0),('Suite',304,'NULL',0),('Suite',305,'NULL',0),('Suite',306,'NULL',0),('Suite',307,'NULL',0),('Suite',308,'NULL',0),('Suite',309,'NULL',0),('Suite',310,'NULL',0),
							  ('Suite',311,'NULL',0),('Suite',312,'NULL',0),('Suite',313,'NULL',0),('Suite',314,'NULL',0),('Suite',315,'NULL',0),('Suite',316,'NULL',0),('Suite',317,'NULL',0),('Suite',318,'NULL',0),('Suite',319,'NULL',0),('Suite',320,'NULL',0)
	
	SELECT * FROM Arooms where G_name='NULL' and Class = 'Ac'
	drop table Arooms
	     insert into  Employee values(112,'Ram',000011110200,60050,'2019-03-01','gym','kar')