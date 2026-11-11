using System;

namespace DZ_7
{
    public class Song
    {
        private string _name;
        private string _author;
        public Song Prev { get; set; }

        public Song(string name, string author)
        {
            Name = name;
            Author = author;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой!");
                _name = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой!");
                _author = value;
            }
        }

        /// <summary>
        /// Метод, который печатает информацию о песне
        /// </summary>
        public string Title()
        {
            return $"Название песни: {_name}\nИсполнитель: {_author}";
        }

        /// <summary>
        /// Метод, который стравнивает 2 песни: название и автор
        /// Equals - встроенный метод сравнения. По умолчанию сравнивает ссылки
        /// </summary>
        public override bool Equals(object d) 
        { 
            if (!(d is Song) || d == null) 
                return false;

            Song other = (Song)d;

            return this._name == other._name && this._author == other._author;
        }

    }
}
