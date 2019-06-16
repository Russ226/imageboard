/*--create dummy users--*/
INSERT INTO imageboard.users(username, email, password, created_on)
values('tim1', 'tim1@email.com', '123', NOW());

INSERT INTO imageboard.users(username, email, password, created_on)
values('rob1', 'rob1@email.com', '123', NOW());

INSERT INTO imageboard.users(username, email, password, created_on)
values('man1', 'man1@email.com', '123', NOW());

INSERT INTO imageboard.users(username, email, password, created_on)
values('dude1', 'dude1@email.com', '123', NOW());

/*--create subboards--*/
INSERT INTO imageboard.subboards(name)
values('waterColor');

INSERT INTO imageboard.subboards(name)
values('anime');

INSERT INTO imageboard.subboards(name)
values('modernism');

/*--create posts--*/
INSERT INTO imageboard.posts(user_id, username, link, title, created_on)
VALUES((SELECT id FROM imageboard.users WHERE username = 'dude1'), 'dude1', 'https://i.imgur.com/QldC22h.jpg', 'cool bunny', NOW());

INSERT INTO imageboard.subboardpostjoin(subboard_id, subboardName, post_id)
VALUES((SELECT id FROM imageboard.subboards where name = 'waterColor'), 'waterColor', (SELECT id FROM imageboard.posts where title = 'cool bunny'));

INSERT INTO imageboard.posts(user_id, username, link, title, created_on)
VALUES((SELECT id FROM imageboard.users WHERE username = 'dude1'), 'dude1', 'https://i.imgur.com/C0yrAz4.jpg', 'Nice Dark Souls', NOW());

INSERT INTO imageboard.subboardpostjoin(subboard_id, subboardName, post_id)
VALUES((SELECT id FROM imageboard.subboards where name = 'waterColor'), 'waterColor', (SELECT id FROM imageboard.posts where title = 'Nice Dark Souls'));


SELECt * FROM imageboard.subboardpostjoin;