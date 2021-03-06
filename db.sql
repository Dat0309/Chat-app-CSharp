create Database SocketChat
go

use SocketChat
go

create Table Users (
	id nvarchar(50) Primary key,
	username nvarchar(50),
	password nvarchar(50),
	name nvarchar(50),
);
go

insert into Users Values(1,'dat','1',N'Đinh Trọng Đạt');
go
insert into Users Values(2,'danh','1',N'Nguyễn Việt Duy Danh');
go
insert into Users Values(3,'huy','1',N'Nguyễn Anh Nhật Huy');
go

create Table Rooms (
	id nvarchar(50) Primary key,
	name nvarchar(50),
);
go

insert into Rooms Values(1,'roomchat1');
go
insert into Rooms Values(2,'roomchat2');
go
insert into Rooms Values(3,'roomchat3');
go
insert into Rooms Values(4,'roomchat4');
go

create Table Participants (
	id nvarchar(50) Primary key,
	userId nvarchar(50) REFERENCES Users(id),
	roomId nvarchar(50) REFERENCES Rooms(id),
);

insert into Participants Values(1,1,1);
go
insert into Participants Values(2,1,3);
go
insert into Participants Values(3,2,1);
go
insert into Participants Values(4,3,1);
go

create Table MessPrivate (
	id nvarchar(50) Primary key,
	userId_send nvarchar(50) REFERENCES Users(id),
	userId_receiver nvarchar(50) REFERENCES Users(id),
	message_body nvarchar(255),
	create_at DateTime,
);

create Table MessRoom (
	id nvarchar(50) Primary key,
	roomId nvarchar(50) references Rooms(id),
	userId nvarchar(50) REFERENCES Users(id),
	message_body nvarchar(255),
	create_at DateTime,
);


select * from Users where Users.username = 'dat' and Users.password = '1'