using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_netframework472
{
    public partial class CreateUpdateBookForm : Form
    {
        private Model1Container database; 
        private CrudBooksForm crudBooksForm;
        private Book bookToUpdate;
       
        public CreateUpdateBookForm(CrudBooksForm crudBooksForm)
        { 
            Init(crudBooksForm);
        }

        public CreateUpdateBookForm(CrudBooksForm crudBooksForm, Book bookToUpdate)
        { 
            Init(crudBooksForm);
            this.bookToUpdate = bookToUpdate;

            comboBoxAuthor.SelectedItem = bookToUpdate.Author;
            comboBoxGenre.SelectedItem = bookToUpdate.Genre;
            comboBoxPublisher.SelectedItem = bookToUpdate.Publisher;
            textBoxNameBook.Text = bookToUpdate.Name;
            textBoxYear.Text= bookToUpdate.Year.ToString();
            textBoxPrice.Text = bookToUpdate.Price.ToString();
            textBoxPages.Text = bookToUpdate.Pages.ToString();
            textBoxCost.Text = bookToUpdate.Cost.ToString();
        }

        private void Init(CrudBooksForm crudBooksForm)
        {
            InitializeComponent();

            this.database = crudBooksForm.database;
            this.crudBooksForm = crudBooksForm;

            comboBoxAuthor.Items.AddRange(database.AuthorSet.ToArray());
            comboBoxGenre.Items.AddRange(database.GenreSet.ToArray());
            comboBoxPublisher.Items.AddRange(database.PublisherSet.ToArray());
            comboBoxPreviousBook.Items.AddRange(database.BookSet.ToArray());

            comboBoxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPreviousBook.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            Author author = (Author)comboBoxAuthor.SelectedItem;
            Publisher publisher = (Publisher)comboBoxPublisher.SelectedItem;
            Genre genre = (Genre)comboBoxGenre.SelectedItem;
            Book previous = (Book)comboBoxPreviousBook.SelectedItem;

            int pages;
            bool pagesSuccessful = Int32.TryParse(textBoxPages.Text, out pages);
            if (!pagesSuccessful)
            {
                MessageBox.Show("pages is not an integer number");
                return;
            }

            int year;
            bool yearSuccessful = Int32.TryParse(textBoxYear.Text, out year);
            if (!yearSuccessful)
            {
                MessageBox.Show("year is not an integer number");
                return;
            }

            decimal price;
            bool priceSuccessful = Decimal.TryParse(textBoxPrice.Text, out price);
            if (!priceSuccessful)
            {
                MessageBox.Show("price is not a number");
                return;
            }

            decimal cost;
            bool costSuccessful = Decimal.TryParse(textBoxCost.Text, out cost);
            if (!costSuccessful)
            {
                MessageBox.Show("cost is not a number");
                return;
            }

            if(bookToUpdate!= null) // update the book
            {
                bookToUpdate.Name = textBoxNameBook.Text;
                bookToUpdate.AuthorId = author.Id;
                bookToUpdate.PublisherId = publisher.Id;
                bookToUpdate.Year = year;
                bookToUpdate.GenreId = genre.Id;
                bookToUpdate.Pages = pages;
                bookToUpdate.Price = price;
                bookToUpdate.Cost = cost;
            }
            else // create new Book
            {
                Book book = new Book
                {
                    Name = textBoxNameBook.Text,
                    AuthorId = author.Id,
                    PublisherId = publisher.Id,
                    Year = year,
                    GenreId = genre.Id,
                    Pages = pages,
                    Price = price,
                    Cost = cost, 
                    CreatedAt = DateTime.Now,
                    Previous = previous
                };
                database.BookSet.Add(book);
            }
            
            database.SaveChanges();
            crudBooksForm.UpdateDataGridView(); 
            this.Close();
        }


      




        private void CreateBookForm_Load(object sender, EventArgs e)
        {
                
        }
    }
}
