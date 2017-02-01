﻿using MovieStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BLL.Test.MockData
{
    public static class FakeData
    {

        public static List<MovieBooking> GetCinemaWorldMockData()
        {
          return new List<MovieBooking>()
            {
               new MovieBooking()
                          {
                            Title = "Star Wars: Episode IV - A New Hope",
                            Year = "1977",
                            ID = "cw0076759",
                            Type = "movie",
                            Rated = null,
                            Released = null,
                            Runtime = null,
                            Genre = null,
                            Director = null,
                            Writer = null,
                            Actors = null,
                            Plot = null,
                            Language = null,
                            Country = null,
                            Poster = "http://ia.media-imdb.com/images/M/MV5BOTIyMDY2NGQtOGJjNi00OTk4LWFhMDgtYmE3M2NiYzM0YTVmXkEyXkFqcGdeQXVyNTU1NTcwOTk@._V1_SX300.jpg",
                            Metascore = null,
                            Rating = null,
                            Votes = null,
                            Price = 0,
                            MovieDB = null,
                            RivalMovieDB = null,
                            RivalID = null,
                            RivalPrice = 0,
                            RivalPriceCheaper = false
                        },
              new MovieBooking()
                        {
                             Title = "Star Wars: Episode V - The Empire Strikes Back",
                             Year = "1980",
                             ID = "cw0080684",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMjE2MzQwMTgxN15BMl5BanBnXkFtZTcwMDQzNjk2OQ@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
               new MovieBooking()
                        {
                             Title = "Star Wars: Episode VI - Return of the Jedi",
                             Year = "1983",
                             ID = "cw0086190",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ0MzI1NjYwOF5BMl5BanBnXkFtZTgwODU3NDU2MTE@._V1._CR93,97,1209,1861_SX89_AL_.jpg_V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false

                        },
               new MovieBooking()
                        {
                             Title= "Star Wars: The Force Awakens",
                             Year= "2015",
                             ID = "cw2488496",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
               new MovieBooking()
                        {
                             Title= "Star Wars: Episode I - The Phantom Menace",
                             Year= "1999",
                             ID = "cw0120915",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ4NjEwNDA2Nl5BMl5BanBnXkFtZTcwNDUyNDQzNw@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
                 new MovieBooking()
                        {
                             Title= "Star Wars: Episode III - Revenge of the Sith",
                             Year= "2005",
                             ID = "cw0121766",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
                  new MovieBooking()
                        {
                             Title= "Star Wars: Episode II - Attack of the Clones",
                             Year= "2002",
                             ID = "cw0121765",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMTY5MjI5NTIwNl5BMl5BanBnXkFtZTYwMTM1Njg2._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        }
            };

        }

        public static List<MovieBooking> GetFilmWorldMockData()
        {
            return new List<MovieBooking>()
            {
               new MovieBooking()
                          {
                            Title = "Star Wars: Episode IV - A New Hope",
                            Year = "1977",
                            ID = "fw0076759",
                            Type = "movie",
                            Rated = null,
                            Released = null,
                            Runtime = null,
                            Genre = null,
                            Director = null,
                            Writer = null,
                            Actors = null,
                            Plot = null,
                            Language = null,
                            Country = null,
                            Poster= "http://ia.media-imdb.com/images/M/MV5BOTIyMDY2NGQtOGJjNi00OTk4LWFhMDgtYmE3M2NiYzM0YTVmXkEyXkFqcGdeQXVyNTU1NTfwOTk@._V1_SX300.jpg",
                            Metascore = null,
                            Rating = null,
                            Votes = null,
                            Price = 0,
                            MovieDB = null,
                            RivalMovieDB = null,
                            RivalID = null,
                            RivalPrice = 0,
                            RivalPriceCheaper = false
                        },
              new MovieBooking()
                        {
                             Title = "Star Wars: Episode V - The Empire Strikes Back",
                             Year = "1980",
                             ID = "fw0080684",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMjE2MzQwMTgxN15BMl5BanBnXkFtZTcwMDQzNjk2OQ@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
               new MovieBooking()
                        {
                             Title = "Star Wars: Episode VI - Return of the Jedi",
                             Year = "1983",
                             ID = "fw0086190",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ0MzI1NjYwOF5BMl5BanBnXkFtZTgwODU3NDU2MTE@._V1._CR93,97,1209,1861_SX89_AL_.jpg_V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false

                        },
               new MovieBooking()
                        {
                             Title= "Star Wars: Episode I - The Phantom Menace",
                             Year= "2015",
                             ID = "fw0120915",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
               new MovieBooking()
                        {
                             Title= "Star Wars: Episode III - Revenge of the Sith",
                             Year= "1999",
                             ID = "fw0121766",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ4NjEwNDA2Nl5BMl5BanBnXkFtZTcwNDUyNDQzNw@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        },
                 new MovieBooking()
                        {
                             Title= "Star Wars: Episode II - Attack of the Clones",
                             Year= "2005",
                             ID = "fw0121765",
                             Type = "movie",
                             Poster = "http://ia.media-imdb.com/images/M/MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_SX300.jpg",
                             Rated = null,
                             Released = null,
                             Runtime = null,
                             Genre = null,
                             Director = null,
                             Writer = null,
                             Actors = null,
                             Plot = null,
                             Language = null,
                             Country = null,
                             Metascore = null,
                             Rating = null,
                             Votes = null,
                             Price = 0,
                             MovieDB = null,
                             RivalMovieDB = null,
                             RivalID = null,
                             RivalPrice = 0,
                             RivalPriceCheaper = false
                        }
                 
            };

        }
    }
}
