CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);


INSERT INTO Locations (location_name) VALUES 
('Erdtree Sanctuary'),
('East Capital Rampart'),
('Lower Capital Church'),
('Avenue Balcony'),
('West Capital Rampart'),
('Queen''s Bedchamber'),
('Fortified Manor, First Floor'),
('Divine Bridge'),
('Elden Throne'),
('Underground Roadside'),
('Forsaken Depths'),
('Leyndell Catacombs'),
('Frenzied Flame Proscription'),
('Cathedral of the Forsaken');

-CREATE TABLE Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);

INSERT INTO Bosses (boss_name, boss_type, location) VALUES 
('Draconic Tree Sentinel', 'Boss', 'LEYNDELL'),
('Fell Twins', 'Boss', 'LEYNDELL'),
('Crucible Tree Knight', 'Boss', 'LEYNDELL'),
('Erdtree Avatar', 'Great Boss', 'LEYNDELL'),
('Ulcerated Tree Spirit', 'Boss', 'LEYNDELL'),
('Black Knife Assassin', 'Boss', 'LEYNDELL'),
('Godfrey, First Elden Lord (Golden Shade)', 'Legendary Boss', 'LEYNDELL'),
('Morgott, the Omen King', 'Legendary Boss', 'LEYNDELL'),
('Esgar, Priest of Blood', 'Boss', 'LEYNDELL'),
('Mohg, the Omen', 'Great Boss', 'LEYNDELL');