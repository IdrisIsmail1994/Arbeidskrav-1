FROM mysql:8.0.33

COPY 1.sql /docker-entrypoint-initdb.d/
COPY 2.sql /docker-entrypoint-initdb.d/
COPY user_priviliges.sql /docker-entrypoint-initdb.d/

ENV MYSQL_ROOT_PASSWORD=gokstad

EXPOSE 3306