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
(10, 'Gagnon',   'Marie',    'Montréal',       'Canada',       '1234 rue Sherbrooke',  'H2L 1K3', '2025-01-15T00:00:00'),
(20, 'Lefebvre', 'Luc',      'Québec',         'Canada',       '56 boul. Laurier',     'G1V 2L8', '2025-03-02T00:00:00'),
(30, 'Roy',      'Sophie',   'Laval',          'Canada',       '890 av. des Lacs',     'H7N 3K2', '2025-04-10T00:00:00'),
(40, 'Martin',   'Lucas',    'Paris',          'France',       '12 rue de Rivoli',     '75001',   '2025-05-22T00:00:00'),
(50, 'Côté',     'Isabelle', 'Sherbrooke',     'Canada',       '45 rue King Ouest',    'J1H 1N8', '2025-06-30T00:00:00'),
(60, 'Nguyen',   'Minh',     'Gatineau',       'Canada',       '310 boul. Maloney',    'J8P 1E6', '2025-08-14T00:00:00'),
(70, 'Smith',    'Emily',    'Boston',         'États-Unis',   '88 Beacon Street',     '02108',   '2026-01-09T00:00:00'),
(80, 'Bouchard', 'Antoine',  'Trois-Rivières', 'Canada',       '1500 rue des Forges',  'G9A 2H5', '2026-03-27T00:00:00');

INSERT INTO Invite (NoInvite, NomPrenom, NoClient) VALUES
(11, 'Gagnon Paul',     10),
(13, 'Gagnon Élodie',   10),
(14, 'Gagnon Hugo',     10),
(21, 'Lefebvre Sophie', 20),
(31, 'Roy Mathieu',     30),
(41, 'Martin Chloé',    40),
(42, 'Martin Léo',      40),
(51, 'Côté Nathalie',   50),
(61, 'Nguyen Linh',     60);

INSERT INTO TypeChambre (NoTypeChambre, Description, PrixHaut, PrixBas, PrixMoyen) VALUES
(1, 'Standard',           189.99, 119.99, 149.99),
(2, 'Suite',              399.99, 249.99, 319.99),
(3, 'Supérieure vue lac', 259.99, 169.99, 209.99),
(4, 'Familiale',          289.99, 189.99, 239.99),
(5, 'Suite Spa',          549.99, 379.99, 459.99),
(6, 'Penthouse',          899.99, 599.99, 749.99);

INSERT INTO Chambre (NoChambre, Emplacement, Decorations, NoTypeChambre) VALUES
(101, '1er étage, côté jardin',    'Moderne',       1),
(102, '1er étage, côté jardin',    'Rustique',      1),
(103, '1er étage, côté piscine',   'Moderne',       4),
(104, '1er étage, côté piscine',   'Champêtre',     4),
(201, '2e étage, vue sur lac',     'Classique',     2),
(202, '2e étage, vue sur lac',     'Bord de mer',   3),
(203, '2e étage, vue sur lac',     'Zen',           3),
(204, '2e étage, côté jardin',     'Scandinave',    1),
(301, '3e étage, terrasse',        'Contemporaine', 5),
(302, '3e étage, vue panoramique', 'Art déco',      2);

INSERT INTO ReservationChambre (NoClient, NoChambre, DateArrivee, DateDepart, NbPersonnes) VALUES
(30, 202, '2026-09-12T15:00:00', '2026-09-15T11:00:00', 2),
(40, 301, '2026-09-20T15:00:00', '2026-09-27T11:00:00', 3),
(10, 101, '2026-10-10T15:00:00', '2026-10-13T11:00:00', 2),
(20, 203, '2026-10-16T15:00:00', '2026-10-20T11:00:00', 2),
(50, 103, '2026-10-24T15:00:00', '2026-10-28T11:00:00', 5),
(20, 201, '2026-11-05T15:00:00', '2026-11-08T11:00:00', 2),
(60, 204, '2026-11-12T15:00:00', '2026-11-15T11:00:00', 1),
(40, 101, '2026-11-20T15:00:00', '2026-11-23T11:00:00', 2),
(70, 302, '2026-12-01T15:00:00', '2026-12-05T11:00:00', 2),
(10, 101, '2026-12-20T15:00:00', '2026-12-27T11:00:00', 4);

INSERT INTO TypeSoin (NoTypeSoin, Description) VALUES
(1, 'Beauté'),
(2, 'Santé');

INSERT INTO Soin (NoSoin, Description, Duree, NoTypeSoin, Prix) VALUES
(1, 'Massage suédois',             60, 2, 110.00),
(2, 'Facial hydratant',            60, 1,  85.00),
(3, 'Massage aux pierres chaudes', 60, 2, 135.00),
(4, 'Enveloppement aux algues',    60, 2, 120.00),
(5, 'Manucure et pédicure',        60, 1,  70.00),
(6, 'Soin anti-âge',               60, 1, 125.00),
(7, 'Réflexologie',                60, 2,  95.00),
(8, 'Gommage corporel',            60, 1,  90.00);

INSERT INTO Assistant (NoAssistant, Prenom, Nom, Specialites, Remarques) VALUES
(1, 'Julie',      'Bouchard',  'Massothérapie',            'Disponible en semaine'),
(2, 'Karim',      'Haddad',    'Esthétique',               'Parle anglais et arabe'),
(3, 'Émilie',     'Gagné',     'Soins corporels',          'Disponible les matins'),
(4, 'Marc-André', 'Pelletier', 'Massothérapie sportive',   NULL),
(5, 'Nadia',      'Benali',    'Esthétique et maquillage', 'Certifiée en soins biologiques');

INSERT INTO AssistantSoin (NoAssistant, NoSoin) VALUES
(1, 1),
(1, 3),
(1, 7),
(2, 2),
(2, 6),
(3, 1),
(3, 4),
(4, 3),
(4, 7),
(5, 2),
(5, 5),
(5, 6);

INSERT INTO PlanifSoin (NoPersonne, NoAssistant, DateHeure, NoSoin) VALUES
(10, 1, '2026-10-13T10:00:00', 1),
(11, 4, '2026-10-13T10:00:00', 3),
(20, 2, '2026-10-14T09:00:00', 6),
(30, 3, '2026-10-15T13:00:00', 4),
(31, 3, '2026-10-15T14:00:00', 1),
(40, 5, '2026-10-16T11:00:00', 5),
(10, 1, '2026-10-20T09:00:00', 3),
(13, 1, '2026-10-20T10:00:00', 1),
(14, 5, '2026-10-20T10:00:00', 2),
(41, 5, '2026-10-21T14:00:00', 6),
(42, 4, '2026-10-22T15:00:00', 7),
(50, 3, '2026-10-23T08:00:00', 4),
(51, 1, '2026-10-23T09:00:00', 7),
(60, 2, '2026-10-26T16:00:00', 2),
(61, 4, '2026-10-27T11:00:00', 3),
(21, 2, '2026-11-06T14:00:00', 2),
(70, 5, '2026-11-09T13:00:00', 5);
GO