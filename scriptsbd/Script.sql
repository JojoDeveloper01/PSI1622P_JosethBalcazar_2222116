CREATE TABLE Game (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(255) UNIQUE,
    world_id INTEGER,
    finalBoss_id INTEGER,
    player_id INTEGER,
    FOREIGN KEY (player_id) REFERENCES player(id_player),
    FOREIGN KEY (world_id) REFERENCES World(id),
    FOREIGN KEY (finalBoss_id) REFERENCES FinalBoss(id)
);
 
CREATE TABLE World (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(255),
    size INTEGER,
    duration INTEGER,
    player_id INTEGER,
    FOREIGN KEY (player_id) REFERENCES player(id_player)
);
 
CREATE TABLE FinalBoss (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(255),
    life INTEGER,
    velocity INTEGER,
    damage INTEGER,
    player_id INTEGER,
    FOREIGN KEY (player_id) REFERENCES player(id_player)
);
 
CREATE TABLE Enemies (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(255),
    amount INTEGER,
    life INTEGER,
    player_id INTEGER,
    FOREIGN KEY (player_id) REFERENCES player(id_player)
);

INSERT INTO Game (name, world_id, finalBoss_id, player_id) 
VALUES ('Magic World', 1, 2, 18);


DROP table FinalBoss
 
select * from Game
 
select * from Game_Enemies
 
select * from Enemies
 	
select * from FinalBoss
 
select * from World

SELECT * FROM Game WHERE player_id = 18;

SELECT 
    g.name,
    g.world_id,
    g.finalBoss_id,
    g.player_id
FROM 
    Game g
WHERE 
    g.player_id = 18;
   
   
SELECT 
    g.name,
    w.name as World,
    f.name as 'Final Boss'
FROM 
    Game g
JOIN 
    World w ON g.world_id = w.id
JOIN 
    FinalBoss f ON g.finalBoss_id = f.id
WHERE 
    g.player_id = 18;

