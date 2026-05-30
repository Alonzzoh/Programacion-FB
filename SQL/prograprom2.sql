DROP DATABASE IF EXISTS flappy;
CREATE DATABASE flappy;

USE flappy;

CREATE TABLE users(
    id_user INT NOT NULL AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL,
    score INT NOT NULL,
    PRIMARY KEY (id_user)
);

