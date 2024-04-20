
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);


INSERT INTO Locations (location_name) VALUES 
('Volcano Manor'),
('Prison Town Church'),
('Temple of Eiglay'),
('Guest Hall'),
('Audience Pathway'),
('Abductor Virgin'),
('Subterranean Inquisition Chamber'),
('Rykard, Lord of Blasphemy');


CREATE TABLE Various_Location_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);


INSERT INTO Various_Location_Bosses (boss_name, boss_type, location) VALUES 
('Abductor Virgins (Wheel) & Abductor Virgin (Swinging Sickle)', 'Boss', 'Subterranean Inquisition Chamber'),
('Godskin Noble (Volcano Manor)', 'Boss', 'Temple of Eiglay'),
('Inquisitor Ghiza', 'Invasion', 'Upstairs in Volcano Manor'),
('Magma Wyrm', 'Boss', 'South of Fort Laied in the Magma pool'),
('Rykard, Lord of Blasphemy', 'Demi-God', 'Volcano Manor');
