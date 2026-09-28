use BDB56Projet1BKG

IF OBJECT_ID ('client') is not null 
DROP TABLE client;

IF OBJECT_ID ('invite') is not null 
DROP TABLE invite;

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


   Create Table soin(
   noSoin int Primary Key,
   description varchar,
   duree varchar(20),
   noTypeSoin varchar(20),
   prix int,
   Foreign Key (noTypeSoin) References typeSoin(noTypeSoin)
   );

   Create Table typeSoin(
   NoTypeSoin int Primary Key,
   Description varchar(20)
   )

   Create Table Assistant(
   noAssisatnt int Primary Key,
   prenom varchar(20),
   nom varchar(20),
   specialites varchar(20),
   remarques varchar(20)
   )

   Create Table assistantSoin(
   noAssistant int,
   noSoin int,
   Foreign Key (noAssistant) References Assistant(noAssistant),
   Foreign Key (noSoin) References soin(noSoin),
   Primary Key (noSoin, NoAssistant)
   )


   Create Table planifSoin(
   noPersonne int,
   noAssistant int,
   dateHeure DateTime2,
   noSoin int,
   Primary Key(noPersonne,noAssistant, dateHeure),
   Foreign Key (noAssistant) References Assistant(noAssistant)
   )