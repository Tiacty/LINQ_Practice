<Query Kind="Statements">
  <Connection>
    <ID>305784f9-8cef-464e-b3a5-c0aa9c79050c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			    Name = m.Name,
				Tracks = from t in m.Tracks
				         select new
				{
				  TrackName = t.Name,
				  Album = t.Album.Title,
				  Artist = t.Album.Artist.Name,
				  ReleaseYear = t.Album.ReleaseYear,
				  ReleaseLabel = t.Album.ReleaseLabel,
				  Genre = t.Genre.Name
				}
			  };
results.Dump();		