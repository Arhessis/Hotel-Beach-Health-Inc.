USE BDB56Projet1BKG;
GO

DELETE FROM PlanifSoin;
DELETE FROM AssistantSoin;
DELETE FROM Soin;
DELETE FROM TypeSoin;
DELETE FROM Assistant;
DELETE FROM ReservationChambre;
DELETE FROM Invite;
DELETE FROM Client;
DELETE FROM Chambre;
DELETE FROM TypeChambre;
DELETE FROM Utilisateur;
DELETE FROM TypeUtilisateur;
GO

INSERT INTO TypeUtilisateur (NoType, identification) VALUES
(1, 'Admin'),
(2, 'Préposé');

INSERT INTO Utilisateur (NoUtilisateur, Nom, MotDePasse, NoType) VALUES
(1, 'admin',    'Admin123!',   1),
(2, 'jtremblay', 'Prepose123!', 2);

INSERT INTO Client (NoClient, Nom, Prenom, Ville, Pays, Adresse, CodePostal, DateInscription) VALUES
(10, 'Gagnon',  'Marie', 'Montréal', 'Canada', '1234 rue Sherbrooke',  'H2L 1K3', '2025-01-15'),
(20, 'Lefebvre', 'Luc',  'Québec',   'Canada', '56 boul. Laurier',     'G1V 2L8', '2025-03-02');

INSERT INTO Invite (NoInvite, NomPrenom, NoClient) VALUES
(11, 'Gagnon Paul',     10),
(21, 'Lefebvre Sophie', 20);

INSERT INTO TypeChambre (NoTypeChambre, Description, PrixHaut, PrixBas, PrixMoyen) VALUES
(1, 'Standard', 189.99, 119.99, 149.99),
(2, 'Suite',    399.99, 249.99, 319.99);

INSERT INTO Chambre (NoChambre, Emplacement, Decorations, NoTypeChambre) VALUES
(101, '1er étage, côté jardin', 'Moderne',   1),
(201, '2e étage, vue sur lac',  'Classique', 2);

INSERT INTO ReservationChambre (NoClient, NoChambre, DateArrivee, DateDepart, NbPersonnes) VALUES
(10, 101, '2026-10-10 15:00', '2026-10-13 11:00', 2),
(20, 201, '2026-11-05 15:00', '2026-11-08 11:00', 2);

INSERT INTO TypeSoin (NoTypeSoin, Description) VALUES
(1, 'Massage'),
(2, 'Soin du visage');

INSERT INTO Soin (NoSoin, Description, Duree, NoTypeSoin, Prix) VALUES
(1, 'Massage suédois',     60, 1, 110.00),
(2, 'Facial hydratant',    45, 2,  85.00);

INSERT INTO Assistant (NoAssistant, Prenom, Nom, Specialites, Remarques) VALUES
(1, 'Julie',  'Bouchard', 'Massothérapie',  'Disponible en semaine'),
(2, 'Karim',  'Haddad',   'Esthétique',     'Parle anglais et arabe');

INSERT INTO AssistantSoin (NoAssistant, NoSoin) VALUES
(1, 1),
(2, 2);

INSERT INTO PlanifSoin (NoPersonne, NoAssistant, DateHeure, NoSoin) VALUES
(10, 1, '2026-10-11 10:00', 1),
(21, 2, '2026-11-06 14:00', 2);
GO
