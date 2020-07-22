using System;

namespace SBC.DAL
{
    public class Courses
    {
        public int id { get; set; } // id курса 

        public string NameCourses { get; set; } // Название курса

        public string Action { set; get; } // Имя метода

        public string Description { get; set; } // описание курса 

        public byte[] Image { get; set; } // изображение 

        public string MineType { get; set; } //тип данных изображения 
    }
}
