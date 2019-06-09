CREATE SCHEMA IF NOT EXISTS imageBoard;

CREATE TABLE IF NOT EXISTS  imageBoard.users(
  id INT NOT NULL AUTO_INCREMENT,
  username VARCHAR(50) NOT NULL,
  email VARCHAR(100) NOT NULL,
  password VARCHAR(255) NOT NULL,
  created_on TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY(id),
  UNIQUE KEY user(username, email, password)
);

CREATE TABLE IF NOT EXISTS imageBoard.posts(
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  username VARCHAR(50) NOT NULL,
  link VARCHAR(255),
  title VARCHAR(255) NOT NULL,
  created_on TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY(id),
  foreign key (user_id) REFERENCES users(id)
);

CREATE TABLE IF NOT EXISTS imageBoard.comments(
  id INT NOT NULL AUTO_INCREMENT,
  user_id INT NOT NULL,
  username VARCHAR(50) NOT NULL,
  post_id INT NOT NULL,
  comment_id INT,
  reply BIT NULL,
  post TEXT,
  created_on TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY(id),
  foreign key (user_id) REFERENCES users(id),
  foreign key (post_id) REFERENCES posts(id),
  foreign key (comment_id) REFERENCES comments(id)
);

CREATE TABLE IF NOT EXISTS imageBoard.subBoards(
	id INT NOT NULL AUTO_INCREMENT,
	name VARCHAR(255),
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS imageBoard.subBoardPostJoin(
	id INT NOT NULL AUTO_INCREMENT,
	subBoard_id INT NOT NULL,
    subBoardName VARCHAR(255) NOT NULL,
	post_id INT NOT NULL,
	foreign key (post_id) REFERENCES posts(id),
	foreign key (subBoard_id) REFERENCES subBoards(id),
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS imageBoard.subBoardUserSubs(
	id INT NOT NULL AUTO_INCREMENT,
	subBoard_id INT NOT NULL,
    subBoardName VARCHAR(255) NOT NULL,
	user_id INT NOT NULL,
    isFavorite BIT NULL,
	foreign key (user_id) REFERENCES users(id),
	foreign key (subBoard_id) REFERENCES subBoards(id),
    PRIMARY KEY(id)
);



CREATE TABLE IF NOT EXISTS imageBoard.postLikes(
	id INT NOT NULL AUTO_INCREMENT,
    user_id INT NOT NULL,
    post_id INT NOT NULL,
    liked BIT NOT NULL,
    foreign key (user_id) REFERENCES users(id),
    foreign key (post_id) REFERENCES posts(id),
	PRIMARY KEY(id)
);


