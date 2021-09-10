using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_netframework472
{
    public partial class CrudBooksForm : Form
    {
        public Model1Container database;

        public CrudBooksForm(Model1Container database)
        {
            this.database = database;
            InitializeComponent();
        }


        public void UpdateDataGridView()// загружает все книги из базы данных и обновляет DataGridView
        {
            //database.BookSet.Load();
            //dataGridViewBooks.DataSource = database.BookSet.Local.ToBindingList();

            var books =
                database.BookSet.Select(book =>// выбирает из книги только нужные столбцы без id
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
                        Price = book.Price,
                        PreviousBook = book.Previous.Author.Name + " - " + book.Previous.Name
                    }
            );
            dataGridViewBooks.DataSource = Helper.LINQResultConvertToDataTable(books);// превращаем результат link  запроса в DataTable
        }

        private void CrudBooksForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();  // загружает все книги из базы данных и обновляет DataGridView
        }


        private void createToolStripMenuItem_Click(object sender, EventArgs e) // создание книги
        {
            CreateUpdateBookForm createBookForm = new CreateUpdateBookForm(this);//создание формы только для создания  книги
            createBookForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)//  удаление книги
        {
            List<Book> booksToDelete = new List<Book>();// список книг, который хотим удалить
            for (int i = 0; i < dataGridViewBooks.SelectedRows.Count; i++)// перебираем выделенные строки
            {
                int index = dataGridViewBooks.SelectedRows[i].Index;// индекс выделенной строки
                int id = (int)dataGridViewBooks[0, index].Value;// ячейка с координатами выделенной строки и нулевого столбца - в этой ячейки id книги
                Book book = database.BookSet.Find(id);//находим книгу в базе данных по ее id
                booksToDelete.Add(book);//добавляем книгу в список на удаление
            }
            database.BookSet.RemoveRange(booksToDelete);// удаляем книги
            database.SaveChanges();// сохраняем изменения в базе данных
            UpdateDataGridView();// обнавляем DataGridView
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) // обновление книги
        {
            if(dataGridViewBooks.SelectedRows.Count == 1)// если выделенный ровно один рядок
            {
                int index = dataGridViewBooks.SelectedRows[0].Index;// индекс выделенной строки
                int id = (int)dataGridViewBooks[0, index].Value; // ячейка с координатами выделенной строки и нулевого столбца - в этой ячейки id книги
                Book book = database.BookSet.Find(id); //находим книгу в базе данных по ее id
                CreateUpdateBookForm createBookForm = new CreateUpdateBookForm(this, book);// создаем форму для обновления книги
                createBookForm.ShowDialog(); // показываем форму
            }


           
        }

      
    }
}
