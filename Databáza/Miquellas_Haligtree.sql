
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);

INSERT INTO Locations (location_name) VALUES 
('Haligtree Canopy'),
('Haligtree Town'),
('Haligtree Town Plaza'),
('Haligtree Promenade'),
('Prayer Room'),
('Elphael Inner Wall'),
('Drainage Channel'),
('Haligtree Roots'),
('Malenia, Goddess of Rot');


CREATE TABLE Miquellas_Haligtree_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);

INSERT INTO Miquellas_Haligtree_Bosses (boss_name, boss_type, location) VALUES 
('Loretta, Knight of the Haligtree', 'Boss', 'Miquellas_Haligtree'),
('Malenia, Blade of Miquella', 'Legendary Boss', 'Miquellas_Haligtree');
