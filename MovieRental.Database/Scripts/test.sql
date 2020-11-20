SELECT * FROM Actor a, Film f, FilmActor fa WHERE a.ActorId = f.FilmId AND f.FilmId = 1;

SELECT * FROM Actor a INNER JOIN FilmActorfa ON(a.ActorId = fa.ActorId);