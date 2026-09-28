USE BDB56Projet1BKG;
GO

IF OBJECT_ID('dbo.PlanifSoin', 'U')         IS NOT NULL DROP TABLE dbo.PlanifSoin;
IF OBJECT_ID('dbo.AssistantSoin', 'U')      IS NOT NULL DROP TABLE dbo.AssistantSoin;
IF OBJECT_ID('dbo.Soin', 'U')               IS NOT NULL DROP TABLE dbo.Soin;
IF OBJECT_ID('dbo.TypeSoin', 'U')           IS NOT NULL DROP TABLE dbo.TypeSoin;
IF OBJECT_ID('dbo.Assistant', 'U')          IS NOT NULL DROP TABLE dbo.Assistant;
IF OBJECT_ID('dbo.ReservationChambre', 'U') IS NOT NULL DROP TABLE dbo.ReservationChambre;
IF OBJECT_ID('dbo.Invite', 'U')             IS NOT NULL DROP TABLE dbo.Invite;
IF OBJECT_ID('dbo.Client', 'U')             IS NOT NULL DROP TABLE dbo.Client;
IF OBJECT_ID('dbo.Chambre', 'U')            IS NOT NULL DROP TABLE dbo.Chambre;
IF OBJECT_ID('dbo.TypeChambre', 'U')        IS NOT NULL DROP TABLE dbo.TypeChambre;
IF OBJECT_ID('dbo.TypeUtilisateur', 'U')            IS NOT NULL DROP TABLE dbo.Chambre;
IF OBJECT_ID('dbo.Utilisateur', 'U')        IS NOT NULL DROP TABLE dbo.TypeChambre;
GO

CREATE TABLE TypeUtilisateur (
    NoType   NUMERIC(6)  NOT NULL,
    identification  VARCHAR(50),

    CONSTRAINT pk_type PRIMARY KEY (NoType)
);

CREATE TABLE Utilisateur (
    NoUtilisateur   NUMERIC(6)  NOT NULL,
    Nom             VARCHAR(30),
    MotDePasse          VARCHAR(30),
    NoType   NUMERIC(6),

    CONSTRAINT fk_type FOREIGN KEY (NoType) REFERENCES TypeUtilisateur(NoType)
    CONSTRAINT pk_type PRIMARY KEY (NoType)
);

CREATE TABLE Client (
    NoClient        NUMERIC(6)   NOT NULL,
    Nom             VARCHAR(30),
    Prenom          VARCHAR(30),
    Ville           VARCHAR(30),
    Pays            VARCHAR(30),
    Adresse         VARCHAR(60),
    CodePostal      VARCHAR(10),
    DateInscription DATE,
    CONSTRAINT pk_Client PRIMARY KEY (NoClient)
    CONSTRAINT ck_Client_NoClient CHECK (NoClient > 0 AND NoClient % 10 = 0)

);

CREATE TABLE Invite (
    NoInvite   NUMERIC(6)  NOT NULL,
    NomPrenom  VARCHAR(50),
    NoClient   NUMERIC(6)  NOT NULL,
    CONSTRAINT pk_Invite PRIMARY KEY (NoInvite),
    CONSTRAINT fk_Invite_Client FOREIGN KEY (NoClient) REFERENCES Client(NoClient)
    CONSTRAINT ck_Invite_NoInvite CHECK (NoInvite > 0 AND NoInvite % 10 <> 0)
);

CREATE TABLE TypeChambre (
    NoTypeChambre NUMERIC(6)   NOT NULL,
    Description   VARCHAR(50),
    PrixHaut      NUMERIC(n,2),
    PrixBas       NUMERIC(n,2),
    PrixMoyen     NUMERIC(n,2),
    CONSTRAINT pk_TypeChambre PRIMARY KEY (NoTypeChambre)
);

CREATE TABLE Chambre (
    NoChambre     NUMERIC(6)  NOT NULL,
    Emplacement   VARCHAR(30),
    Decorations   VARCHAR(50),
    NoTypeChambre NUMERIC(6)  NOT NULL,
    CONSTRAINT pk_Chambre PRIMARY KEY (NoChambre),
    CONSTRAINT fk_Chambre_TypeChambre FOREIGN KEY (NoTypeChambre) REFERENCES TypeChambre(NoTypeChambre)
);

CREATE TABLE ReservationChambre (
    NoClient     NUMERIC(6) NOT NULL,
    NoChambre    NUMERIC(6) NOT NULL,
    DateArrivee  DATETIME   NOT NULL,
    DateDepart   DATETIME,
    NbPersonnes  NUMERIC(2),
    CONSTRAINT pk_ReservationChambre PRIMARY KEY (NoClient, NoChambre, DateArrivee),
    CONSTRAINT fk_Reservation_Client  FOREIGN KEY (NoClient)  REFERENCES Client(NoClient),
    CONSTRAINT fk_Reservation_Chambre FOREIGN KEY (NoChambre) REFERENCES Chambre(NoChambre)
);


CREATE TABLE TypeSoin (
    NoTypeSoin  NUMERIC(6)  NOT NULL,
    Description VARCHAR(50),
    CONSTRAINT pk_TypeSoin PRIMARY KEY (NoTypeSoin)
);

CREATE TABLE Soin (
    NoSoin      NUMERIC(6)   NOT NULL,
    Description VARCHAR(50),
    Duree       NUMERIC(4),
    NoTypeSoin  NUMERIC(6)   NOT NULL,
    Prix        NUMERIC(n,2),
    CONSTRAINT pk_Soin PRIMARY KEY (NoSoin),
    CONSTRAINT fk_Soin_TypeSoin FOREIGN KEY (NoTypeSoin) REFERENCES TypeSoin(NoTypeSoin)
);

CREATE TABLE Assistant (
    NoAssistant NUMERIC(6)   NOT NULL,
    Prenom      VARCHAR(30),
    Nom         VARCHAR(30),
    Specialites VARCHAR(100),
    Remarques   VARCHAR(200),
    CONSTRAINT pk_Assistant PRIMARY KEY (NoAssistant)
);

CREATE TABLE AssistantSoin (
    NoAssistant NUMERIC(6) NOT NULL,
    NoSoin      NUMERIC(6) NOT NULL,
    CONSTRAINT pk_AssistantSoin PRIMARY KEY (NoAssistant, NoSoin),
    CONSTRAINT fk_AssistantSoin_Assistant FOREIGN KEY (NoAssistant) REFERENCES Assistant(NoAssistant),
    CONSTRAINT fk_AssistantSoin_Soin      FOREIGN KEY (NoSoin)      REFERENCES Soin(NoSoin)
);

CREATE TABLE PlanifSoin (
    NoPersonne  NUMERIC(6) NOT NULL,
    NoAssistant NUMERIC(6) NOT NULL,
    DateHeure   DATETIME   NOT NULL,
    NoSoin      NUMERIC(6) NOT NULL,
    CONSTRAINT pk_PlanifSoin PRIMARY KEY (NoPersonne, NoAssistant, DateHeure),
    CONSTRAINT fk_PlanifSoin_Assistant FOREIGN KEY (NoAssistant) REFERENCES Assistant(NoAssistant),
    CONSTRAINT fk_PlanifSoin_Soin      FOREIGN KEY (NoSoin)      REFERENCES Soin(NoSoin)
);
GO
