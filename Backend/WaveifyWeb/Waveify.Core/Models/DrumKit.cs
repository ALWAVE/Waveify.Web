using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waveify.Core.Models
{
    public class DrumKit
    {
        public const int MAX_TITTLE_LENGHT = 250;
        private DrumKit(Guid id, string tittle, string desc, string url, decimal price) 
        { 
            Id = id;
            Tittle = tittle;
            Description = desc;
            Url = url;
            Price = price;
        }    
        // Т.к мы находлимся в доменной модели то элементы не должны иметь сетера мы не должны из вне взаимодействовать с этой моделью
        public Guid Id { get;  }
        public string Tittle { get;  } = string.Empty;
        public string Description { get; } = string.Empty;
        public string Url { get; } = string.Empty;
        public decimal Price { get; }
        // Кортеж
        public static (DrumKit DrumKit, string Error) Create(Guid id, string tittle, string desc, string url, decimal price)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(tittle) || tittle.Length > MAX_TITTLE_LENGHT) 
            {
                error = "Tittle can not be empty 250 cymbols";
            }
            var drumKit = new DrumKit(id, tittle, desc, url, price);
            return (drumKit, error);
        }
    }
}
