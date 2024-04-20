
CREATE TABLE Locations (
    id INTEGER PRIMARY KEY,
    location_name TEXT
);


INSERT INTO Locations (location_name) VALUES 
('Forbidden Lands'),
('Grand Lift of Rold'),
('Hidden Path to the Haligtree'),
('Divine Tower of East Altus: Gate'),
('Divine Tower of East Altus'),
('Zamor Ruins'),
('Ancient Snow Valley Ruins'),
('Freezing Lake'),
('First Church of Marika'),
('Whiteridge Road'),
('Snow Valley Ruins Overlook'),
('Castle Sol Main Gate'),
('Church of the Eclipse'),
('Castle Sol Rooftop'),
('Spiritcaller Cave'),
('Giants'' Gravepost'),
('Church of Repose'),
('Foot of the Forge'),
('Fire Giant'),
('Forge of the Giants'),
('Giants'' Mountaintop Catacombs'),
('Giant-Conquering Hero''s Grave'),
('Consecrated Snowfield'),
('Inner Consecrated Snowfield'),
('Ordina, Liturgical Town'),
('Apostate Derelict'),
('Consecrated Snowfield Catacombs'),
('Cave of the Forlorn'),
('Yelough Anix Tunnel');


CREATE TABLE Location_Bosses (
    id INTEGER PRIMARY KEY,
    boss_name TEXT,
    boss_type TEXT,
    location TEXT
);


INSERT INTO Location_Bosses (boss_name, boss_type, location) VALUES 
('Tibia Mariner', 'Boss', 'Mountaintops of the Giants'),
('Erdtree Avatar', 'Boss', 'Mountaintops of the Giants'),
('Commander Niall', 'Boss', 'Mountaintops of the Giants'),
('Ancient Hero of Zamor', 'Boss', 'Mountaintops of the Giants'),
('Fire Giant', 'Boss', 'Mountaintops of the Giants'),
('Ulcerated Tree Spirit', 'Boss', 'Mountaintops of the Giants'),
('Death Rite Bird', 'Boss', 'Mountaintops of the Giants'),
('Black Blade Kindred', 'Boss', 'Mountaintops of the Giants'),
('Great Wyrm Theodorix', 'Boss', 'Mountaintops of the Giants'),
('Astel, Stars of Darkness', 'Boss', 'Mountaintops of the Giants'),
('Vyke, Knight of the Roundtable', 'Boss', 'Mountaintops of the Giants'),
('Putrid Grave Warden Duelist', 'Boss', 'Mountaintops of the Giants'),
('2x Night''s Cavalry', 'Boss', 'Mountaintops of the Giants'),
('Death Rite Bird', 'Boss', 'Mountaintops of the Giants'),
('Putrid Avatar', 'Boss', 'Mountaintops of the Giants'),
('Misbegotten Crusader', 'Boss', 'Mountaintops of the Giants'),
('Chief Guardian Arghanthy', 'Boss', 'Mountaintops of the Giants'),
('Stray Mimic Tear', 'Boss', 'Mountaintops of the Giants'),
('Spiritcaller Snail', 'Boss', 'Mountaintops of the Giants'),
('Borealis the Freezing Fog', 'Great Boss', 'Mountaintops of the Giants'),
('Bloody Finger Okina', 'Invasion', 'Mountaintops of the Giants'),
('Sanguine Noble', 'Invasion', 'Mountaintops of the Giants'),
('Juno Hoslow, Knight of Blood', 'Invasion', 'Mountaintops of the Giants'),
('Anastasia, Tarnished-Eater', 'Invasion', 'Mountaintops of the Giants');
