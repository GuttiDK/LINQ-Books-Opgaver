using LinqBooks.BuisnessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBooks
{
    static public class SampleData
    {
      static public Publisher[] Publishers =
      {
        new Publisher {Name="FunBooks"},
        new Publisher {Name="Joe Publishing"},
        new Publisher {Name="I Publisher"}
      };

      static public Author[] Authors =
      {
        new Author {FirstName="Johnny", LastName="Good", Age = 32},
        new Author {FirstName="Graziella", LastName="Simplegame", Age = 48},
        new Author {FirstName="Octavio", LastName="Prince", Age = 27},
        new Author {FirstName="Jeremy", LastName="Legrand", Age = 56}
      };

      static public Subject[] Subjects =
      {
        new Subject {Name="Software development"},
        new Subject {Name="Novel"},
        new Subject {Name="Science fiction"}
      };

      static public User[] Users =
      {
        new User { Name="Connie Nielsen"},
        new User { Name="Nick Richardson"},
        new User { Name="Christina Lawson"}
      };

      static public Review[] Reviews =
      {
        new Review { Comments="Very funny!", Rating=3, User=Users[2] },
        new Review { Comments="Really not funny!", Rating=0, User=Users[0] },
        new Review { Comments="Maybe funny!", Rating=1, User=Users[1] },
        new Review { Comments="Now I understand LINQ!", Rating=3,  User=Users[1] },
        new Review { Comments="Too elementary for me!", Rating=1, User=Users[2] },
        new Review { Comments="Very good book", Rating=3, User=Users[1] },
        new Review { Comments="I don't understand the author", Rating=0, User=Users[0] }
      };

      static public Book[] Books =
      {
        new Book {
          Title="Funny Stories",
          Publisher=Publishers[0],
          Authors=new[]{Authors[0], Authors[1]},
          PageCount=101,
          Price=25.55M,
          PublicationDate=new DateTime(2004, 11, 10),
          Isbn="0-000-77777-2",
          Subject=Subjects[0],
          Reviews=new[]{Reviews[0],Reviews[1],Reviews[2]}
        },
        new Book {
          Title="LINQ rules",
          Publisher=Publishers[1],
          Authors=new[]{Authors[2]},
          PageCount=300,
          Price=12M,
          PublicationDate=new DateTime(2007, 9, 2),
          Isbn="0-111-77777-2",
          Subject=Subjects[0],
          Reviews=new[]{Reviews[3],Reviews[4]}
        },
        new Book {
          Title="C# on Rails",
          Publisher=Publishers[1],
          Authors=new[]{Authors[2]},
          PageCount=256,
          Price=35.5M,
          PublicationDate=new DateTime(2007, 4, 1),
          Isbn="0-222-77777-2",
          Subject=Subjects[0],
          Reviews=new Review[0]
        },
        new Book {
          Title="All your base are belong to us",
          Publisher=Publishers[1],
          Authors=new[]{Authors[3]},
          PageCount=1205,
          Price=35.5M,
          PublicationDate=new DateTime(2006, 5, 5),
          Isbn="0-333-77777-2",
          Subject=Subjects[2],
          Reviews=new Review[0]
        },
        new Book {
          Title="Bonjour mon Amour",
          Publisher=Publishers[0],
          Authors=new[]{Authors[1], Authors[0]},
          PageCount=50,
          Price=29M,
          PublicationDate=new DateTime(1973, 2, 18),
          Isbn="2-444-77777-2",
          Subject=Subjects[1],
          Reviews=new[]{Reviews[5],Reviews[6]}
        }
      };
    }
}
