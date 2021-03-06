//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop_netframework472
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookExemplars = new HashSet<BookExemplar>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int PublisherId { get; set; }
        public System.DateTime CreatedAt { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookExemplar> BookExemplars { get; set; }
        public virtual Book Next { get; set; }
        public virtual Book Previous { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
