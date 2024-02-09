# create user
CREATE USER IF NOT EXISTS 'Idris'@'localhost' IDENTIFIED BY 'gokstad';
CREATE USER IF NOT EXISTS 'Idris'@'%' IDENTIFIED BY 'gokstad';
 
 # tilgang og rettigheter gis her:
GRANT ALL privileges ON ChampionsLeague.* TO 'Idris'@'%';
GRANT ALL privileges ON ChampionsLeague.* TO 'Idris'@'localhost';

FLUSH PRIVILEGES