
-- DROP TABLE Statements
DROP TABLE Panel;
DROP TABLE DRAW;
DROP TABLE PrizeStructure;
DROP TABLE De_Reg;
DROP TABLE Prizes;
DROP TABLE Title;
DROP TABLE Gender;
DROP TABLE Nationality;
DROP TABLE County;
DROP TABLE Country;
DROP TABLE Ticket;
DROP TABLE Customer;
DROP TABLE NumberAnalysis;




-- Customer Table
CREATE TABLE CUSTOMER (
CUSTOMERID NUMERIC(6),
Title CHAR(4) NOT NULL,
SURNAME CHAR(25) NOT NULL,
FORENAME CHAR(25) NOT NULL,
DOB DATE NOT NULL,
PPSN CHAR(8) NOT NULL,
ADDRESSLINE1 VARCHAR(40) NOT NULL,
ADDRESSLINE2 VARCHAR(40) NOT NULL,
TOWN VARCHAR(40) NOT NULL,
COUNTY VARCHAR(35) NOT NULL,
COUNTRY VARCHAR(35) NOT NULL,
NATIONALITY VARCHAR(40) NOT NULL,
GENDER CHAR(6),
PHONE CHAR(15),
EMAIL CHAR(40) NOT NULL,
BALANCE DECIMAL(10, 2) DEFAULT 0,
CUSTOMER_STATUS CHAR(10) NOT NULL,
REG_DATE DATE NOT NULL,
CONSTRAINT pk_customer PRIMARY KEY (CUSTOMERID));

-- Ticket Table
CREATE TABLE Ticket (
TicketId NUMERIC(12),
CustomerId NUMERIC(6) NOT NULL,
PurchaseDate DATE NOT NULL,
Time CHAR(30) NOT NULL,
Price DECIMAL(4, 2) NOT NULL,
PrizeFlag char(4) NOT NULL,
CONSTRAINT pk_ticket PRIMARY KEY (TicketId),
CONSTRAINT fk_ticket_cust FOREIGN KEY (CustomerId) REFERENCES Customer);

-- Panel Table
CREATE TABLE Panel (
PanelId NUMERIC(12),
TicketId NUMERIC(12) NOT NULL,
Number1 NUMERIC(2) NOT NULL,
Number2 NUMERIC(2) NOT NULL,
Number3 NUMERIC(2) NOT NULL,
Number4 NUMERIC(2) NOT NULL,
Number5 NUMERIC(2) NOT NULL,
Number6 NUMERIC(2) NOT NULL,
CONSTRAINT pk_panel PRIMARY KEY (PanelId, TicketId),
CONSTRAINT fk_panel_tick FOREIGN KEY (TicketId) REFERENCES Ticket);

-- Draw Table
CREATE TABLE Draw (
DrawDate DATE NOT NULL,
Number1 NUMERIC(2) NOT NULL,
Number2 NUMERIC(2) NOT NULL,
Number3 NUMERIC(2) NOT NULL,
Number4 NUMERIC(2) NOT NULL,
Number5 NUMERIC(2) NOT NULL,
Number6 NUMERIC(2) NOT NULL,
CONSTRAINT pk_draw PRIMARY KEY (DrawDate));

-- PrizeStructure Table
CREATE TABLE PrizeStructure (
DrawDate DATE NOT NULL,
Match6 NUMERIC(7) NOT NULL,
Match5 NUMERIC(6) NOT NULL,
Match4 NUMERIC(5) NOT NULL,
Match3 NUMERIC(4) NOT NULL,
CONSTRAINT pk_PrizeStructure PRIMARY KEY (DrawDate));

-- De-Reg Table
CREATE TABLE De_Reg (
CustomerId NUMERIC(6),
De_regDate DATE NOT NULL,
CONSTRAINT pk_De_Reg PRIMARY KEY (CustomerId),
CONSTRAINT fk_De_Reg_Cust FOREIGN KEY (CustomerId) REFERENCES Customer);

-- Prizes Table
CREATE TABLE Prizes (
DrawDate DATE NOT NULL,
TicketId NUMERIC(12) NOT NULL,
PanelId NUMERIC(12) NOT NULL,
PrizeAmount NUMERIC(7) NOT NULL,
CONSTRAINT pk_prizes PRIMARY KEY (TicketId, PanelId),
CONSTRAINT fk_prize_tick FOREIGN KEY (TicketId) REFERENCES Ticket);

-- Analysis Table
CREATE TABLE NumberAnalysis (
numPk NUMERIC(2),
numberOccurences NUMERIC(2) DEFAULT 0,
CONSTRAINT pk_numberAnalysis PRIMARY KEY (numPk));


-- Title Table
CREATE TABLE Title (
Titles char(5) NOT NULL,
CONSTRAINT pk_title PRIMARY KEY (Titles));

-- Gender Table
CREATE TABLE Gender (
Genders char(6) NOT NULL,
CONSTRAINT pk_gender PRIMARY KEY (Genders));

-- Nationality Table
CREATE TABLE Nationality (
Nationalities VARCHAR(50) NOT NULL,
CONSTRAINT pk_Nationality PRIMARY KEY (Nationalities));

-- County Table
CREATE TABLE County (
Counties VARCHAR(25) NOT NULL,
CONSTRAINT pk_county PRIMARY KEY (Counties));

-- County Table
CREATE TABLE Country (
Countries VARCHAR(25) NOT NULL,
CONSTRAINT pk_country PRIMARY KEY (Countries));

COMMIT;
