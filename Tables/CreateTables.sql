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
