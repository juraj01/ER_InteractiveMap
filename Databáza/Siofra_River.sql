
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);

-
INSERT INTO Locations (location_name) VALUES 
('Nokron, Eternal City'),
('Mimic Tear'),
('Ancestral Woods'),
('Night''s Sacred Ground'),
('Aqueduct-Facing Cliffs'),
('Great Waterfall Basin'),
('Siofra River Well Depths'),
('Siofra River Bank'),
('Worshippers'' Woods'),
('Below the Well'),
('Palace Approach Ledge-Road'),
('Dynasty Mausoleum Entrance'),
('Dynasty Mausoleum Midpoint'), 
('Cocoon of the Empyrean');


CREATE TABLE Siofra_River_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);


INSERT INTO Siofra_River_Bosses (boss_name, boss_type, location) VALUES 
('Ancestor Spirit', 'Boss', 'Siofra River'),
('Dragonkin Soldier', 'Boss', 'Siofra River'),
('Valiant Gargoyle Duo', 'Boss', 'Siofra River'),
('Mimic Tear', 'Boss', 'Siofra River'),
('Regal Ancestor Spirit', 'Great Boss', 'Siofra River'),
('Nameless White Mask', 'Invasion', 'Siofra River'),
('Nameless White Mask', 'Invasion', 'Siofra River'),
('Nameless White Mask', 'Invasion', 'Siofra River'),
('Mohg, Lord of Blood', 'Legendary Boss', 'Siofra River');
