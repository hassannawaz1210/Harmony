use sms
select * from student;
select * from [user];
select * from society;
select * from members
select * from following
select * from applicants
select * from participants
select * from events
select * from announcements
select * from admin;
SELECT * FROM sys.tables

insert into [user] values('admin', '1234', 'Admin') 
insert into admin values(10)
insert into members values('President', 5, 7)
insert into society values('me', 'soc3.jpg', 'i am me', 'dot.com', '444', '@gmail', 'miss' , 0, 5, '0101-01-01', 'hassan', 'rel')

UPDATE student
SET cover_pic = NULL
WHERE id = 5

update society
set description = '"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."' where description = 'i am me'

----------------
delete from [user] where username = 'taha'
delete from members
delete from society where website = 'bruh'
----
ALTER TABLE admin
ADD CONSTRAINT admin_userid_fk
FOREIGN KEY (userid) REFERENCES [user](id)
ON DELETE CASCADE
ON UPDATE CASCADE;
--------
ALTER TABLE admin
ADD CONSTRAint PK__admin__3213E83FDA6E2C91;
ALTER TABLE student
ALTER COLUMN rollno varchar(100);
------------
ALTER TABLE student
DROP COLUMN profile_pic;

ALTER TABLE student
ADD cover_pic text DEFAULT NULL;
--------
SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='society';

---- society table
CREATE TABLE society
(
    id INT PRIMARY KEY IDENTITY(1,1), 
    name NVARCHAR(255) UNIQUE,
    logo NVARCHAR(MAX),
    description NVARCHAR(MAX),
    website NVARCHAR(255),
    phone NVARCHAR(20),
    email NVARCHAR(255),
    mission NVARCHAR(MAX),
    num_of_members INT,
    president_id int,
    founding_date DATE,
    faculty_advisor NVARCHAR(255),
    type NVARCHAR(255)
);


CREATE TABLE members (
    id INT PRIMARY KEY IDENTITY,
    [role] varchar(255),
    stu_id INT,
    soc_id INT,
    CONSTRAINT members_stuid_fk FOREIGN KEY (stu_id) REFERENCES student(id) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT members_socid_fk FOREIGN KEY (soc_id) REFERENCES society(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE applicants (
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(255),
    email VARCHAR(255),
    phone VARCHAR(255),
	status varchar(255),
    roll_number VARCHAR(255),
    why_join TEXT,
    why_hire TEXT,
    soc_id INT,
	stu_id int,
    CONSTRAINT applicants_socid_fk FOREIGN KEY (soc_id) REFERENCES society(id) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT applicants_stuid_fk FOREIGN KEY (stu_id) REFERENCES student(id) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE following (
    id INT IDENTITY(1,1) PRIMARY KEY,
    stu_id INT NOT NULL,
    soc_id INT NOT NULL,
    CONSTRAINT fk_following_stu_id FOREIGN KEY (stu_id) REFERENCES student(id) on update cascade on delete cascade,
    CONSTRAINT fk_following_soc_id FOREIGN KEY (soc_id) REFERENCES society(id) on update cascade on delete cascade
);

CREATE TABLE announcements (
    id INT IDENTITY(1,1) PRIMARY KEY,
    subject VARCHAR(500),
    message TEXT,
    ann_date DATE,
    ann_time TIME,
    stu_id INT NOT NULL,
    soc_id INT NOT NULL,
    CONSTRAINT fk_ann_stu_id FOREIGN KEY (stu_id) REFERENCES student(id) on update cascade on delete cascade,
    CONSTRAINT fk_ann_soc_id FOREIGN KEY (soc_id) REFERENCES society(id) on update cascade on delete cascade
);

CREATE TABLE events (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    description TEXT,
    date VARCHAR(255),
    time VARCHAR(255),
    venue VARCHAR(255),
    sponsors TEXT,
    reg_fee VARCHAR(255),
	logo text,
	soc_id int,
	CONSTRAINT fk_events_soc_id FOREIGN KEY (soc_id) REFERENCES society(id) on update cascade on delete cascade
);

CREATE TABLE participants (
    id INT PRIMARY KEY IDENTITY(1,1),
	stu_id int,
	eve_id int,
	CONSTRAINT fk_participants_stu_id FOREIGN KEY (stu_id) REFERENCES student(id) on update cascade on delete cascade,
	CONSTRAINT fk_event FOREIGN KEY (eve_id) REFERENCES events(id) ON DELETE CASCADE ON UPDATE CASCADE,
)

--CREATE TABLE event_participants (
--    eve_id INT,
--    participant_id INT,
--    PRIMARY KEY (eve_id, participant_id),
--    CONSTRAINT fk_event FOREIGN KEY (eve_id) REFERENCES events(id) ON DELETE CASCADE ON UPDATE CASCADE,
--    CONSTRAINT fk_participant FOREIGN KEY (participant_id) REFERENCES participants(id) ON DELETE CASCADE ON UPDATE CASCADE
--);


drop table participants
drop table partic
