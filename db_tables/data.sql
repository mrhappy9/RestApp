use restapp;

DROP TABLE IF EXISTS Users;
CREATE TABLE IF NOT EXISTS Users
	(
		users_id INT auto_increment,
        login VARCHAR(50),
        password VARCHAR(50),
        PRIMARY KEY(users_id)
        -- FOREIGN KEY(Users_id) references Users(Users_id)
    );