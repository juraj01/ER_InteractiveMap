
CREATE TABLE Crumbling_Farum_Azula (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);


INSERT INTO Crumbling_Farum_Azula (location_name) VALUES 
('Crumbling Beast Grave'),
('Crumbling Beast Grave Depths'),
('Tempest-Facing Balcony'),
('Dragon Temple'),
('Dragon Temple Transept'),
('Dragon Temple Altar'),
('Dragon Temple Lift'),
('Dragon Temple Rooftop'),
('Beside the Great Bridge'),
('Dragonlord Placidusax'),
('Maliketh, the Black Blade');


CREATE TABLE Crumbling_Farum_Azula_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);


INSERT INTO Crumbling_Farum_Azula_Bosses (boss_name, boss_type, location) VALUES 
('Godskin Duo', 'Boss', 'Crumbling Farum Azula'),
('Maliketh, the Black Blade', 'Boss', 'Crumbling Farum Azula'),
('Dragonlord Placidusax', 'Boss', 'Crumbling Farum Azula'),
('Alexander Iron Fist (Crumbling Farum Azula)', 'Boss', 'Crumbling Farum Azula'),
('Beast Clergyman', 'Boss', 'Crumbling Farum Azula'),
('Recusant Bernahl', 'Invasion', 'Crumbling Farum Azula');
