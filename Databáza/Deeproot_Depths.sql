
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);


INSERT INTO Locations (location_name) VALUES 
('Root-Facing Cliffs'),
('Great Waterfall Crest'),
('Deeproot Depths'),
('The Nameless Eternal City'),
('Across the Roots'),
('Prince of Death''s Throne');


CREATE TABLE Deeproot_Depths_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);

INSERT INTO Deeproot_Depths_Bosses (boss_name, boss_type, location) VALUES 
('Lichdragon Fortissax', 'Boss', 'Deeproot Depths'),
('Crucible Knight Siluria', 'Boss', 'Deeproot Depths'),
('Fia’s Champions', 'Boss', 'Deeproot Depths'),
('Erdtree Avatar', 'Boss', 'Deeproot Depths');
