using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mandatory
{
    public partial class Form1 : Form
    {
        // Список пользователей:
        private Dictionary<string, User> userList = new Dictionary<string, User> {
                { "Odmen", new User("Odmen", "1488", 100)}
            };

        // Список объектов и их доступность:
        private Dictionary<string, int> objects = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            Random random = new Random((int)DateTime.Now.Ticks);

            foreach (string username in new string[] { "Йфяу9", "Лсдуз" })
            {
                userList.Add(username, new User(username, "0000", random.Next(0, 101)));
            }

            for (int i = 0; i < 5; i++)
            {
                objects.Add("object " + i, random.Next(0, 101));
            }
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            string username = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (userList.ContainsKey(username))
            {
                if (userList[username].Password == password)
                {
                    MainForm mainForm = new MainForm(this, userList[username], userList, objects);
                    mainForm.Show();
                    this.Hide();

                    return;
                }
            }

            MessageBox.Show("Такой пары логин-пароль не существует.");
        }
    }
}
