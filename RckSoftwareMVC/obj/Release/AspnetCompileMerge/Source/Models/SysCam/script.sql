create table DataImage(
  id integer not null primary key identity,
  image text,
  camera varchar(60),
  date datetime
);