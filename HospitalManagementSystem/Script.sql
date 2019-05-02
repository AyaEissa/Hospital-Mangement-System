DROP TABLE Patient CASCADE CONSTRAINTS;
DROP TABLE Doctor CASCADE CONSTRAINTS;

create table Patient
(
Namee varchar2 (40) NOT NULL,
National_ID varchar2 (20) NOT NULL,
age varchar2(3) NOT NULL,
Mobile_number varchar2(13) NOT NULL,
Passwordd varchar2 (10)
);

CREATE TABLE Doctor (
Username VARCHAR2(30) PRIMARY KEY,
Password_ VARCHAR2(256) NOT NULL,
Fname VARCHAR2(10),
Lname VARCHAR2(10),
Mobilenumber VARCHAR2(13),
Department VARCHAR2(30)
);

