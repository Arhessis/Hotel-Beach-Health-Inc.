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

IF OBJECT_ID ('ReservationChambre') is not null
DROP TABLE ReservationChambre;

IF OBJECT_ID ('TypeChambre') is not null
DROP TABLE TypeChambre;


IF OBJECT_ID ('Chambre') is not null
DROP TABLE Chambre;


CREATE TABLE Client (
   NoClient		NUMERIC(6) ,
   Nom          VARCHAR(20),
   Prenom       VARCHAR(20),
   Ville        VARCHAR(20),
   Pays         VARCHAR(20),
   Adresse      VARCHAR(20),
   CodePostal   VARCHAR(20),
   DateInscription  DATE
   
   CONSTRAINT pk_client  PRIMARY KEY(NoClient)
   );


CREATE TABLE Invite (
   NoInvite     NUMERIC(6) ,
   NomPrenom    VARCHAR(20),
   NoClient     NUMERIC(6)
   CONSTRAINT fk_client FOREIGN KEY(NoClient) references Client(NoClient),

   CONSTRAINT pk_invite  PRIMARY KEY(NoInvite)
   );

CREATE TABLE ReservationChambre (
   NoClient     NUMERIC(6) ,
   NoChambre    VARCHAR(20),
   DateArrivee     DATE,
   DateDepart     DATE,
   NbPersonnes NUMERIC(2)

   CONSTRAINT fk_noclient FOREIGN KEY(NoClient) references Client(NoClient),
   CONSTRAINT chambre FOREIGN KEY(NoChambre) references Chambre(NoChambre),

   CONSTRAINT pk_datearrivee  PRIMARY KEY(DateArrivee)
   );

CREATE TABLE TypeChambre (
   NoTypeChambre     NUMERIC(6) ,
   Description    VARCHAR(20),
   PrixHaut     NUMERIC(6),
   PrixBas     NUMERIC(6),
   PrixMoyen     NUMERIC(6)

   CONSTRAINT pk_typechambre  PRIMARY KEY(NoTypeChambre)
   );

CREATE TABLE Chambre (
   NoChambre     NUMERIC(6) ,
   Emplacement    VARCHAR(20),
   Decoration     NUMERIC(6),
   NoTypeChambre NUMERIC(6)

   CONSTRAINT fk_typechambre FOREIGN KEY(NoTypeChambre) references TypeChambre(NoTypeChambre),

   CONSTRAINT pk_nochambre  PRIMARY KEY(NoChambre)
   );

