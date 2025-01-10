  using System;
  using System.Collections.Generic;

  namespace SUMMARIES.Data
  {
  	public static class Data
  	{
  		public static List<Book> Books => allBooks;

  		private static List<Book> allBooks = new List<Book>()
  		{
  			new Book()
  			{
  				Id=1,
  				Title="Managing Oneself",
  				Description="We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...",
  				Author= "Peter Ducker",
  				Rate= (double)4.9,
  				DateStart = new DateTime(2019,01,20),
  				DateRead = null
  			}, 
  			new Book()
  			{
  				Id=2,
  				Title="büyücü",
  				Description="roman türünde bir kitap",
  				Author= "John Fowles",
  				Rate= (double)4.9,
  				DateStart = new DateTime(2019,01,20),
  				DateRead = null
  			},
			new Book()
  			{
  				Id=3,
  				Title="1984",
  				Description="roman türünde bir kitap",
  				Author= "corç orwell",
  				Rate= (double)4.9,
  				DateStart = new DateTime(2019,01,20),
  				DateRead = null
  			},
			new Book()
  			{
  				Id=4,
  				Title="körlük",
  				Description="roman türünde bir kitap",
  				Author= "jose ",
  				Rate= (double)4.9,
  				DateStart = new DateTime(2019,01,20),
  				DateRead = null
  			},
			new Book()
  			{
  				Id=5,
  				Title="açlık",
  				Description="roman türünde bir kitap",
  				Author= "knut hamsun",
  				Rate= (double)4.9,
  				DateStart = new DateTime(2019,01,20),
  				DateRead = null
  			}
  		};
  	}
  }