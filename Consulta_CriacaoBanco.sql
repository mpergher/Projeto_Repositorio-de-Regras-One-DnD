create database GlossarioDnD;

create login GlossarioDnD with password = 'GlossarioDnD';
create user GlossarioDnD from login GlossarioDnD;

exec sp_addrolemember 'DB_DATAREADER', 'GlossarioDnD';
exec sp_addrolemember 'DB_DATAWRITER', 'GlossarioDnD';

