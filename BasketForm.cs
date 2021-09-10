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
    public partial class BasketForm : Form
    {
        private Model1Container database;
        private MainForm mainForm;
        private List<Book> booksToBuy;

       
        public BasketForm(MainForm mainForm, List<Book> booksToBuy)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.database = mainForm.database;
            var preparedBooksToBuy =
                booksToBuy.Select(book =>
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
            dataGridViewBooks.DataSource = Helper.LINQResultConvertToDataTable(preparedBooksToBuy);
            this.booksToBuy = booksToBuy;
        }

        private void buttonСheckout_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                UserId = mainForm.CurrentUser.Id,
                CreatedAt = DateTime.Now
            };

            foreach (Book book in booksToBuy)
            {
               BookExemplar bookExemplar = database.BookExemplarSet
                    .Where(exemplar => exemplar.BookId == book.Id && exemplar.StatusId == 1)
                    .FirstOrDefault();
                bookExemplar.OrderId = order.Id;
                bookExemplar.StatusId = 3;
            }
            database.OrderSet.Add(order);
            database.SaveChanges();
        }
    }
}
