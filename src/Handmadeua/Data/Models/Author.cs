using System.Collections.Generic;
using Handmadeua.Data.Models.JoinedEntities;

namespace Handmadeua.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string About { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public List<ProductAuthor> ProductAuthors { get; set; }

        public Author()
        {
            ProductAuthors = new List<ProductAuthor>();
        }
    }
}
