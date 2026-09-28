use BDB56Projet1BKG

IF OBJECT_ID ('client') is not null 
DROP TABLE client;

IF OBJECT_ID ('Invite') is not null
DROP TABLE Invite;

IF OBJECT_ID ('planifSoin') is not null 
DROP TABLE planifSoin;

IF OBJECT_ID ('typeSoin') is not null
DROP TABLE typeSoin;

IF OBJECT_ID ('typeUtilisateur') is not null
DROP TABLE typeUtilisateur;

IF OBJECT_ID ('utilisateur') is not null
DROP TABLE utilisateur;

CREATE TABLE client (
   cliNo		NUMERIC(6) ,
   
   CONSTRAINT pk_client  PRIMARY KEY(cliNo)
   );