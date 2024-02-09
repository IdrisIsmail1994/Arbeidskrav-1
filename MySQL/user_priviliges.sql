# create user
create user if not exists 'champ'@'ga-db' IDENTIFIED by "thechamp";
create user if not exists 'champ'@'%' IDENTIFIED by "thechamp";

grant all privileges on championsleague.* to 'champ'@'%';
grant all privileges on championsleague.* to 'champ'@'ga-db';

FLUSH privileges;
