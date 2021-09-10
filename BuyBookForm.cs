using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_netframework472
{
    public partial class BuyBookForm : Form
    {
        private Model1Container database;
        private MainForm mainForm;
        List<Book> booksToBuy;

        public BuyBookForm(MainForm mainForm) // конструктор формы
        {
            this.mainForm = mainForm;// ссылка на главную форму
            this.database = mainForm.database; // ссылка на базу данных
            InitializeComponent();
            comboBoxGenre.Items.AddRange(database.GenreSet.ToArray());  // заполняем выподающий список жанрами     
            comboBoxGenre.SelectedIndex = 0; // выбираем начальный жанр
            comboBoxAuthor.Items.AddRange(database.AuthorSet.ToArray()); // заполняем выподающий список писателями
            comboBoxAuthor.SelectedIndex = 0;// что бы не было пустоты в выподающем списке и exeption

            booksToBuy = new List<Book>();// создаем список покупок
        }

        private void FindBook_Load(object sender, EventArgs e)
        {
            
        }


        private void UpdateDataGridViewBooks(IQueryable<Book> filteredBooks)// заполняем DataGridViewBooks книгами из filteredBooks
        {
            var filteredData = 
                filteredBooks.Select(book => 
                    new
                    {
                         Id = book.Id,
                         Name = book.Name,
                         Publisher = book.Publisher.Name,
                         Genre = book.Genre.Name,
                         Author = book.Author.Name,
                         Pages = book.Pages,
                         Year = book.Year,
                         Cost = book.Cost,
                         Price = book.Price
                    }
            );
            dataGridViewBooks.DataSource = Helper.LINQResultConvertToDataTable(filteredData);
        }

        
        
        private void buttonFindByGenre_Click(object sender, EventArgs e)// поиск по жанру
        {
            Genre genre = (Genre)comboBoxGenre.SelectedItem; // по выбранному из списка получаем жанр
            var filteredData = database.BookSet.
                Where(b => b.GenreId == genre.Id);
            UpdateDataGridViewBooks(filteredData);                       
        }

        private void buttonFindByAuthor_Click(object sender, EventArgs e) // поиск по автору
        {
            Author author = (Author)comboBoxAuthor.SelectedItem;
            var filteredData = database.BookSet.
                Where(b => b.AuthorId == author.Id);
            UpdateDataGridViewBooks(filteredData);
        }

        private void buttonFindByBookName_Click(object sender, EventArgs e) // поиск по имени книги
        {
            var filteredData = database.BookSet.
                Where(b => b.Name.Contains(textBoxBookName.Text));//Война и мир - мир - true
            UpdateDataGridViewBooks(filteredData);
        }

        private void buttonBuy_Click(object sender, EventArgs e) // добавление книг в корзину покупок
        {            
            for (int i = 0; i < dataGridViewBooks.SelectedRows.Count; i++) 
            {
                int index = dataGridViewBooks.SelectedRows[i].Index;
                int id = (int)dataGridViewBooks[0, index].Value;// координаты ячейки
                Book book = database.BookSet.Find(id);//  в базе данных по id  находим книгу
                booksToBuy.Add(book); // добавляем книгу в корзину
            }
                  
        }

        private void buttonBasket_Click(object sender, EventArgs e) // открытие формы корзина покупок
        {
            BasketForm basketForm = new BasketForm(mainForm, booksToBuy);
            basketForm.ShowDialog();
        }

        private void buttonNewBooks_Click(object sender, EventArgs e) // сортировка по дате создания
        {
            var filteredData = database.BookSet.OrderByDescending(book => book.CreatedAt);
            UpdateDataGridViewBooks(filteredData);
        }
    }
}
