
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);

INSERT INTO Locations (location_name) VALUES 
('Ainsel River Well Depths'),
('Ainsel River Sluice Gate'),
('Ainsel River Downstream'),
('Dragonkin Soldier of Nokstella'),
('Astel, Naturalborn of the Void'),
('Ainsel River Main'),
('Nokstella, Eternal City'),
('Nokstella Waterfall Basin'),
('Lake of Rot Shoreside'),
('Grand Cloister');


CREATE TABLE Ainsel_River_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);


INSERT INTO Ainsel_River_Bosses (boss_name, boss_type, location) VALUES 
('Astel, Naturalborn of the Void', 'Boss', 'Ainsel River'),
('Dragonkin Soldier', 'Boss', 'Ainsel River'),
('Dragonkin Soldier of Nokstella', 'Great Boss', 'Ainsel River'),
('Baleful Shadow', 'Invasion', 'Ainsel River');