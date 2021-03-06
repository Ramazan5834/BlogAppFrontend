using System;

namespace BlogAppFrontend.Models
{
    public class CategoryListModel:IEquatable<CategoryListModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Equals(CategoryListModel other)
        {
            return this.Id == other.Id && this.Name == other.Name;
        }
    }
}
