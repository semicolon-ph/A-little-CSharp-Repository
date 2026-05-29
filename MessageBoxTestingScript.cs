using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class MessageBoxTestingScript
    {
        [STAThread]
        static void Main()
        {
            string MyFavoriteFood = "Buldak";

            MessageBox.Show("My favorite food is\n" + MyFavoriteFood + "! it's really good!", "My Favorite Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult msgDialog = MessageBox.Show("Do you like Buldak?", "Options Yes and No", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgDialog != DialogResult.Yes)
            {
                MessageBox.Show("I respect that, i know you hate Spice. Have a nice day!", "My Opinion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nice! You love buldak, right? Have a Nice day!", "My Opinion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
