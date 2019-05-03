DROP TABLE Patient CASCADE CONSTRAINTS;
DROP TABLE Doctor CASCADE CONSTRAINTS;
DROP TABLE Nurse CASCADE CONSTRAINTS;
Drop Table Medicine Cascade constraints;

create table Patient
(
Username VARCHAR2(30) PRIMARY KEY,
Password_ varchar2(256) NOT NULL,
Namee varchar2 (40) NOT NULL,
National_ID NUMBER(20) NOT NULL,
age NUMBER(3) NOT NULL,
Mobile_number varchar2(13) NOT NULL
);

CREATE TABLE Doctor (
Username VARCHAR2(30) PRIMARY KEY,
Password_ VARCHAR2(256) NOT NULL,
Fname VARCHAR2(10),
Lname VARCHAR2(10),
Mobilenumber VARCHAR2(13),
Department VARCHAR2(30)
);

CREATE TABLE Nurse (
Username VARCHAR2(30) PRIMARY KEY,
Password_ VARCHAR2(256) NOT NULL,
Fname VARCHAR2(10),
Lname VARCHAR2(10),
Mobilenumber VARCHAR2(13)
);

create table Medicine
(
Medicine_Name varchar2 (30) Primary key,
Medicine_ID varchar2(50) not null,
Expiry_year varchar2(4)not null,
Quanitiy varchar2(20) not null
);

