namespace Web1.Models
{
    public class MockData
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User{  Id = 1,LastName="Yılmaz",Name="Ali"            },
            new User{  Id = 2,LastName="Cenan",Name="Mustafa"      },
            new User{  Id = 3,LastName="Bektaş",Name="Ali" ,BirthDate= DateTime.Now      },
            new User{  Id = 4,LastName="Övünç",Name="Havva"      },
            new User{  Id = 5,LastName="İlter",Name="Zana"      }
        };

        public static List<Course> Courses { get; set; } = new List<Course>() {
            new Course{  Id=1,Name="Matematik"  },
            new Course{  Id=2,Name="Fizik"  },
            new Course{  Id=3,Name="Kimya"  },
            new Course{  Id=4,Name="İngilizce"  },
            new Course{  Id=5,Name="Resim"  }
        };

    }
}
