using System.Collections.Generic;
using System.Windows.Forms;

namespace mandatory
{
    partial class MainForm : Form
    {
        private Dictionary<string, User> userList;
        private Dictionary<string, int> objects;

        private User currentUser;

        private Form root;

        public MainForm(Form root, User currentUser, Dictionary<string, User> userList, Dictionary<string, int> objects)
        {
            this.root = root;

            this.currentUser = currentUser;

            this.userList = userList;
            this.objects = objects;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.Text += " — " + this.currentUser.Username;

            accessLabel.Text += this.currentUser.AccessLevel;

            foreach (KeyValuePair<string, int> keyValue in objects)
            {
                allObjectsDGV.Rows.Add(keyValue.Key, keyValue.Value);

                if (this.currentUser.AccessLevel >= keyValue.Value)
                    accessibleObjectsDGV.Rows.Add(keyValue.Key, keyValue.Value); 
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.root.Close();
        }
    }
}
