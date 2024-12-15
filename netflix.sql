 create table user_data
 (
 id int primary key ,
 username varchar(30),
 email varchar(50),
 dateofbirth date,
 payment_type varchar(30),
 );
 create table actors
 (
 actor_id int primary key not null,
 actor_name varchar(30) unique not null,
 actor_gender varchar(10),
 );
  create table directors
 (
 director_id int primary key not null,
 director_name varchar(30) unique not null,
 director_gender varchar(10),
 );
 create table genre
 (
  genre_id int primary key not null,
  genre_name varchar(20) unique not null,
 );
 create table ratings
 (
 rating_id int primary key references user_data(id),
 rating_score decimal unique not null,
 rating_date date,
 );
 create table languages 
 (
 lannguage_id int primary key not null,
 language_name varchar(30) unique not null,
 );
  create table movie_type
  (
  mv_id int primary key not null,
  mv_name varchar(30) unique not null,
  mv_language varchar(30) foreign key references languages(language_name),
  mv_rating decimal foreign key references ratings(rating_score),
  mv_genre varchar(20) foreign key references genre(genre_name),
  );
    create table tvshow
  (
  tvs_tvsid int primary key not null,
  tvs_name varchar(30) unique not null,
  tvs_language varchar(30) foreign key references languages(language_name),
  tvs_rating decimal foreign key references ratings(rating_score),
  tvs_genre varchar(20) foreign key references genre(genre_name),
  tvs_parts int,
  );
    create table documentries
  (
  doc_id int primary key not null,
  doc_name varchar(30) unique not null,
  doc_language varchar(30) foreign key references languages(language_name),
  doc_rating decimal foreign key references ratings(rating_score),
  doc_genre varchar(20) foreign key references genre(genre_name),
  doc_length time,
  );

    create table webseries
  (
  wb_id int primary key not null,
  wb_name varchar(30) unique not null,
  wb_language varchar(30) foreign key references languages(language_name),
  wb_rating decimal foreign key references ratings(rating_score),
  wb_genre varchar(20) foreign key references genre(genre_name),
  wb_seasons int,
  );
  create table watched_mv
  (
  watch_id int foreign key references user_data(id),
  mv_name varchar(30) foreign key references movie_type(mv_name),

  );
    create table watched_tv
  (
  watch_id int foreign key references user_data(id),
  tv_name varchar(30) foreign key references tvshow(tvs_name),


  );
    create table watched_doc
  (
  watch_id int foreign key references user_data(id),
  doc_name varchar(30) foreign key references documentries(doc_name),

  );
    create table watched_wb
  (
  watch_id int foreign key references user_data(id),
  wb_name varchar(30) foreign key references webseries(wb_name),
  );
    create table downloads_mv
  (
  download_id int foreign key references user_data(id),
  mv_name_d varchar(30) foreign key references movie_type(mv_name),

  );

      create table downloads_tv
  (
  download_id int foreign key references user_data(id),
  tv_name_d varchar(30) foreign key references tvshow(tvs_name),

  );
      create table downloads_doc
  (
  download_id int foreign key references user_data(id),
  doc_name_d varchar(30) foreign key references documentries(doc_name),

  );
      create table downloads_wb
  (
  download_id int foreign key references user_data(id),
  wb_name_d varchar(30) foreign key references webseries(wb_name),
  );

    create table mylist_mv
  (
  mylist_id int foreign key references user_data(id),
  mv_name_l varchar(30) foreign key references movie_type(mv_name),
  );
      create table mylist_tv
  (
  mylist_id int foreign key references user_data(id),
  tv_name_l varchar(30) foreign key references tvshow(tvs_name),

  );
      create table mylist_doc
  (
  mylist_id int foreign key references user_data(id),
  doc_name_l varchar(30) foreign key references documentries(doc_name),
  );
      create table mylist_wb
  (
  mylist_id int foreign key references user_data(id),

  wb_name_l varchar(30) foreign key references webseries(wb_name),
  );
  create table actor_cast_movies
  (
  mv_id int foreign key references movie_type(mv_id),
  actor_id int foreign key references actors(actor_id),

  );
  create table director_cast_movies
  (
    mv_id int foreign key references movie_type(mv_id),
    director_id int foreign key references directors(director_id),

  );

    create table actor_cast_webseries
  (
  wb_id int foreign key references webseries(wb_id),
  actor_id int foreign key references actors(actor_id),

  );
  create table director_cast_webseries
  (
    wb_id int foreign key references webseries(wb_id),
    director_id int foreign key references directors(director_id),

  );
    create table actor_cast_documentries
  (
  doc_id int foreign key references documentries(doc_id),
  actor_id int foreign key references actors(actor_id),

  );
  create table director_cast_documentries
  (
    doc_id int foreign key references documentries(doc_id),
    director_id int foreign key references directors(director_id),
  );
    create table actor_cast_tvshow
  (
  tvs_id int foreign key references tvshow(tvs_tvsid),
  actor_id int foreign key references actors(actor_id),

  );
  create table director_cast_tvshow
  (
    tvs_id int foreign key references tvshow(tvs_tvsid),
    director_id int foreign key references directors(director_id),

  );

  insert into user_data values
  (1,'ali ehtisham','aliehtisham@gmail.com','2002/3/22','visa'),
  (2,'maysam hussain ','maysamhussain.com','2000/7/11','mastercard'),
  (3,'huaifa asif','huzaifaasif@gmail.com','2002/9/12','visa'),
  (4,'abdul haseeb','abdulhaseeb@gmail.com','2003/1/7','unionpay');

  insert into actors values
  (1,'tom cruise','male'),
  (2,'jim carry','male'),
  (3,'will smith','male'),
  (4,'henry cavil','male'),
  (5,'vindiesel','male'),
  (6,'paulwalker','male'),
  (7,'alexandra daddario','female'),
  (8,'anna de armas','female'),
  (9,'megan fox','female'),
  (10,'sonam bajwa','female');
   
   insert into directors values
   (1,'christopher mcquarrie','male'),
   (2,'jj abrams','male'),
   (3,'chuck russel','male'),
   (4,'francis lawrence','male'),
   (5,'louis leterrier','male'),
   (6,'steven caplejr','male');

   insert into genre values
   (1,'action'),
   (2,'adventure'),
   (3,'sci fi'),
   (4,'horror'),
   (5,'comedy');

    insert into ratings values
	(1,6,'2021/3/1'),
	(2,7,'2021/3/11'),
	(3,8,'2022/7/8'),
	(4,9,'2021/5/2');

	insert into languages values
	(1,'english'),
	(2,'japanese'),
	(3,'chinese'),
	(4,'urdu');

	insert into movie_type values
	(1,'mission impossible','english',8,'action'),
	(2,'the mask','english',8,'comedy'),
	(3,'i am legend','english',7,'adventure'),
	(4,'man of steel','english',8,'sci fi'),
	(5,'fast and furious','english',7,'action'),
	(6,'baywatch','english',6,'comedy'),
	(7,'hitman','english',6,'action'),
	(8,'transformers','english',8,'sci fi'),
	(9,'the conjuring','japanese',6,'horror');
	
	insert into tvshow values
	(1,'peaky blinders','english',9,'adventure',6),
	(2,'breaking bad','english',9,'action',5),
	(3,'game of throne','english',8,'adventure',8),
	(4,'witcher','english',8,'sci fi',2),
	(5,'squid game','chinese',6,'adventure',1);

	insert into documentries values
	(1,'downfall','english',7,'adventure','2:13:1'),
	(2,'found','urdu',6,'horror','2:00:00'),
	(3,'free to play','english',7,'action','2:17:00'),
	(4,'dont look back','english',8,'horror','1:29:00');

	insert into webseries values
	(1,'stranger things','english',7,'adventure',3),
	(2,'dark','japanese',8,'sci fi',4),
	(3,'good doctor','english',8,'adventure',7),
	(4,'shameless','english',9,'adventure',11);

	insert into actor_cast_movies values
	(1,1),
	(1,3),
	(2,2),
	(3,3),
	(3,9),
	(4,4),
	(5,5),
	(5,6),
	(6,8),
	(6,9),
	(7,1),
	(7,2),
	(8,8),
	(8,9),
	(9,6),
	(9,7);

	insert into actor_cast_tvshow values
	(1,8),
	(1,1),
	(2,2),
	(2,3),
	(2,9),
	(3,2),
	(3,7),
	(4,8),
	(5,1),
	(5,3);

	insert into actor_cast_documentries values
	(1,2),
	(1,4),
	(1,1),
	(2,5),
	(2,7),
	(3,8),
	(4,8),
	(4,9);

	insert into actor_cast_webseries values
	(1,4),
	(2,2),
	(2,9),
	(3,1),
	(3,9),
	(4,1),
	(4,3);

	insert into director_cast_movies values
	(1,6),
	(2,5),
	(2,3),
	(3,1),
	(3,5),
	(4,2),
	(5,4),
	(6,3),
	(7,2),
	(8,4),
	(9,3),
	(9,1);

	insert into director_cast_tvshow values
	(1,3),
	(2,2),
	(3,1),
	(4,6),
	(4,6),
	(5,1),
	(5,1);

	insert into director_cast_documentries values
	(1,1),
	(2,3),
	(2,1),
	(3,1),
	(3,4),
	(4,6);

	insert into director_cast_webseries values
	(1,6),
	(2,2),
	(3,6),
	(3,1),
	(3,4),
	(4,3);

	insert into watched_doc values
	(1,'downfall'),
	(2,'found'),
	(1,'free to play');

	insert into watched_mv values
	(1,'the mask'),
	(1,'hitman'),
	(2,'transformers'),
	(3,'mission impossible'),
	(3,'baywatch');

	insert into watched_tv values
	(3,'peaky blinders'),
	(3,'witcher'),
	(4,'squid game');

	insert into watched_wb values
	(4,'stranger things'),
	(4,'dark'),
	(3,'shameless');

	insert into mylist_doc values
	(3,'found'),
	(3,'downfall'),
	(2,'free to play');

	insert into mylist_mv values
	(1,'baywatch'),
	(3,'the mask'),
	(4,'the mask'),
	(4,'hitman');

	insert into mylist_tv values
	(1,'peaky blinders'),
	(1,'witcher');

	insert into mylist_wb values
	(2,'stranger things'),
	(1,'dark');

	
	insert into downloads_doc values
	(1,'found'),
	(3,'free to play'),
	(4,'found');

	insert into downloads_mv values
	(4,'hitman'),
	(4,'the mask'),
	(3,'i am legend');

	insert into downloads_tv values
	(1,'peaky blinders');

	insert into downloads_wb values
	(2,'shameless');

select top(3) *from movie_type order by mv_rating desc

select top(3) *from documentries order by doc_rating desc

select top(3) * from tvshow order by tvs_rating desc

select top(3) *from webseries order by wb_rating desc

---JOIN QUERIES
SELECT movie_type.mv_name, actors.actor_name
FROM movie_type
INNER JOIN actor_cast_movies
ON movie_type.mv_id = actor_cast_movies.mv_id
INNER JOIN actors
ON actor_cast_movies.actor_id = actors.actor_id;

SELECT movie_type.mv_name, actors.actor_name
FROM movie_type
LEFT JOIN actor_cast_movies
ON movie_type.mv_id = actor_cast_movies.mv_id
LEFT JOIN actors
ON actor_cast_movies.actor_id = actors.actor_id;


SELECT movie_type.mv_name, actors.actor_name
FROM movie_type
RIGHT JOIN actor_cast_movies
ON movie_type.mv_id = actor_cast_movies.mv_id
RIGHT JOIN actors
ON actor_cast_movies.actor_id = actors.actor_id;

SELECT movie_type.mv_name, actors.actor_name
FROM movie_type
FULL OUTER JOIN actor_cast_movies
ON movie_type.mv_id = actor_cast_movies.mv_id
FULL OUTER JOIN actors
ON actor_cast_movies.actor_id = actors.actor_id;

SELECT tvshow.tvs_name, actors.actor_name
FROM tvshow
INNER JOIN actor_cast_tvshow
ON tvshow.tvs_tvsid = actor_cast_tvshow.tvs_id
INNER JOIN actors
ON actor_cast_tvshow.actor_id = actors.actor_id;

SELECT documentries.doc_name, directors.director_name
FROM documentries
INNER JOIN director_cast_documentries
ON documentries.doc_id = director_cast_documentries.doc_id
INNER JOIN directors
ON director_cast_documentries.director_id = directors.director_id;

SELECT webseries.wb_name, actors.actor_name
FROM webseries
INNER JOIN actor_cast_webseries
ON webseries.wb_id = actor_cast_webseries.wb_id
INNER JOIN actors
ON actor_cast_webseries.actor_id = actors.actor_id;

SELECT actors.actor_name
FROM movie_type
INNER JOIN actor_cast_movies
ON movie_type.mv_id = actor_cast_movies.mv_id
INNER JOIN actors
ON actor_cast_movies.actor_id = actors.actor_id
WHERE movie_type.mv_name = 'i am legend';

SELECT a.actor_name
FROM tvshow t
INNER JOIN actor_cast_tvshow ac ON t.tvs_tvsid = ac.tvs_id
INNER JOIN actors a ON ac.actor_id = a.actor_id
WHERE t.tvs_name = 'peaky blinders';

SELECT a.actor_name
FROM documentries d
INNER JOIN actor_cast_documentries ac ON d.doc_id = ac.doc_id
INNER JOIN actors a ON ac.actor_id = a.actor_id
WHERE d.doc_name = 'found';

SELECT a.actor_name
FROM webseries w
INNER JOIN actor_cast_webseries ac ON w.wb_id = ac.wb_id
INNER JOIN actors a ON ac.actor_id = a.actor_id
WHERE w.wb_name = 'dark';

--AGGREGATE FUNCTIONS

SELECT AVG(rating_score) FROM ratings INNER JOIN movie_type ON ratings.rating_id = movie_type.mv_id;

SELECT COUNT(*) FROM ratings INNER JOIN movie_type ON ratings.rating_id = movie_type.mv_id WHERE rating_score >= 4.0;

SELECT MAX(wb_seasons) FROM webseries;

SELECT COUNT(DISTINCT rating_id) FROM ratings INNER JOIN movie_type ON ratings.rating_id = movie_type.mv_id;

SELECT SUM(doc_length) FROM documentries;


---TRANSACTIONS

BEGIN TRANSACTION;

UPDATE user_data SET payment_type = 'credit card' WHERE id = 12345;

COMMIT;
--this transaction deletes watch and download history using movie name and deletes a movie by name
BEGIN TRANSACTION;

DELETE FROM watched_mv WHERE mv_name = 'Movie Name';
DELETE FROM downloads_mv WHERE mv_name_d = 'Movie Name';
DELETE FROM movie_type WHERE mv_name = 'Movie Name';

COMMIT;
--this transaction is used to change movie genre of a specific movie
BEGIN TRANSACTION;

UPDATE movie_type SET mv_genre = 'horror' WHERE mv_name = 'i am legend';


COMMIT;
---this transaction insert tv show in respective table 
BEGIN TRANSACTION;

INSERT INTO tvshow (tvs_tvsid, tvs_name, tvs_language, tvs_rating, tvs_genre, tvs_parts) VALUES (12345, 'TV Show Name', 'English', 4.5, 'Drama', 24);
INSERT INTO languages (lannguage_id, language_name) VALUES (5, 'latin');
INSERT INTO ratings (rating_id, rating_score, rating_date) VALUES (2, 4.5, '2022-06-01');
INSERT INTO genre (genre_id, genre_name) VALUES (5, 'Drama');

COMMIT;


---PROCEDURES

----this proceduer is used to add new user in user_data table
go

CREATE PROCEDURE add_user 

    @id INT,
    @username VARCHAR(30),
    @email VARCHAR(50),
    @dateofbirth DATE,
    @payment_type VARCHAR(30)
AS
BEGIN
  INSERT INTO user_data (id, username, email, dateofbirth, payment_type) VALUES (@id, @username, @email, @dateofbirth, @payment_type);
END
---------------this procedure is used to delete a existing user 
go 

CREATE PROCEDURE delete_user
    @id INT
AS
BEGIN
  DELETE FROM ratings WHERE rating_id = @id;
  DELETE FROM user_data WHERE id = @id;
END
----------------this procedure tells the name of show a user has watched
go

CREATE PROCEDURE get_watched_tv
    @user_id INT
AS
BEGIN
  SELECT tvs_name FROM tvshow INNER JOIN watched_tv ON tvshow.tvs_tvsid = watched_tv.tv_name WHERE watch_id = @user_id;
END




------FUNCTIONS

--this function gets the age of the user by using the date of birth given in the table
GO
CREATE FUNCTION get_age(@dob DATE)
RETURNS INT
AS
BEGIN
  DECLARE @age INT = DATEDIFF(YEAR, @dob, GETDATE());
  RETURN @age;
END

----------------thiz function gets the most populer genre among all the movies by averaging the number of movie in each genre

GO
CREATE FUNCTION get_popular_genre()
RETURNS VARCHAR(20)
AS
BEGIN
  DECLARE @genre VARCHAR(20);
  SELECT @genre = genre_name
  FROM (SELECT top(1) genre_name, COUNT(*) as num_movies FROM movie_type INNER JOIN genre ON movie_type.mv_genre = genre.genre_name GROUP BY genre_name) as t
  ORDER BY num_movies DESC    
  RETURN  @genre;
END
---------------this fucntion gets the highesr rated movie from the movie_type table
go

CREATE FUNCTION highest_rated_movie()
RETURNS VARCHAR(30)
AS
BEGIN
    DECLARE @highest_rated_movie VARCHAR(30)
    SELECT @highest_rated_movie = mv_name
    FROM movie_type INNER JOIN ratings ON movie_type.mv_id = ratings.rating_id
    WHERE rating_score = (SELECT MAX(rating_score) FROM ratings)
    RETURN @highest_rated_movie
END



