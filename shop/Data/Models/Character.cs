namespace shop.Data.Models
{
    public class Character
    {
        public int Id { get; set; }//ид конкретного товара
        public string Name { get; set; }//название
        public string ShortDesc { get; set; }//небольшое описание товара
        public string LongDesc { get; set; }//длинное описание
        public string Img { get; set; }//картинки
        public Team Team { get; set; }//присвоение к опред категории
        public ushort Price { get; set; }//цена без минуса
        public bool IsFavorite { get; set; }//отображение на главной странице
        public bool IsAvailable { get; set; }// есть ли данный товар на складе
    }
}