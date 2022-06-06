using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public static List<item> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<item>();
        }

        public void key_press(object s, KeyPressEventArgs e)
        {
            TextBox text_box = (TextBox)s;

            if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') &&
            (text_box.Text.IndexOf('.') > -1 ||
            text_box.Text.Length == 0))
                e.Handled = true;
        }

        public void key_press_i(object s, KeyPressEventArgs e)
        {
            TextBox text_box = (TextBox)s;

            if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void choose_class_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            constructor_class_table.Controls.Clear();

            Label Firm_label = new Label();
            Firm_label.AutoSize = true;
            Firm_label.Size = new Size(50, 20);
            Firm_label.Text = "FirmName";

            constructor_class_table.Controls.Add(Firm_label, 0, 0);

            TextBox Firm_text = new TextBox();
            Firm_text.Name = "Firm_text";
            Firm_text.Size = new System.Drawing.Size(200, 27);

            constructor_class_table.Controls.Add(Firm_text, 1, 0);


            Label Name_label = new Label();
            Name_label.AutoSize = true;
            Name_label.Size = new Size(50, 20);
            Name_label.Text = "Name";

            constructor_class_table.Controls.Add(Name_label, 0, 1);

            TextBox Name_text = new TextBox();
            Name_text.Name = "Name_text";
            Name_text.Size = new System.Drawing.Size(200, 27);

            constructor_class_table.Controls.Add(Name_text, 1, 1);


            Label Cost_label = new Label();
            Cost_label.AutoSize = true;
            Cost_label.Size = new Size(50, 20);
            Cost_label.Text = "Cost";

            constructor_class_table.Controls.Add(Cost_label, 0, 2);

            TextBox Cost_text = new TextBox();
            Cost_text.Name = "Cost_text";
            Cost_text.Size = new System.Drawing.Size(80, 27);
            Cost_text.KeyPress += key_press_i;

            constructor_class_table.Controls.Add(Cost_text, 1, 2);


            Label Mass_label = new Label();
            Mass_label.AutoSize = true;
            Mass_label.Size = new Size(50, 20);
            Mass_label.Text = "Mass";

            constructor_class_table.Controls.Add(Mass_label, 0, 3);

            TextBox Mass_text = new TextBox();
            Mass_text.Name = "Mass_text";
            Mass_text.Size = new System.Drawing.Size(80, 27);
            Mass_text.KeyPress += key_press;

            constructor_class_table.Controls.Add(Mass_text, 1, 3);


            Label Size_label = new Label();
            Size_label.AutoSize = true;
            Size_label.Size = new Size(50, 20);
            Size_label.Text = "Size";

            constructor_class_table.Controls.Add(Size_label, 0, 4);

            TextBox Size_text_x = new TextBox();
            Size_text_x.Name = "Size_text_x";
            Size_text_x.Size = new System.Drawing.Size(200, 27);
            Size_text_x.KeyPress += key_press;
            constructor_class_table.Controls.Add(Size_text_x, 1, 4);

            TextBox Size_text_y = new TextBox();
            Size_text_y.Name = "Size_text_y";
            Size_text_y.Size = new System.Drawing.Size(80, 27);
            Size_text_y.KeyPress += key_press;
            constructor_class_table.Controls.Add(Size_text_y, 2, 4);

            TextBox Size_text_z = new TextBox();
            Size_text_z.Name = "Size_text_z";
            Size_text_z.Size = new System.Drawing.Size(80, 27);
            Size_text_z.KeyPress += key_press;
            constructor_class_table.Controls.Add(Size_text_z, 3, 4);

            Action product_create = () =>
            {
                Label Category_label = new Label();
                Category_label.AutoSize = true;
                Category_label.Size = new Size(50, 20);
                Category_label.Text = "Category";

                constructor_class_table.Controls.Add(Category_label, 0, 5);

                TextBox Category_text = new TextBox();
                Category_text.Name = "Category_text";
                Category_text.Size = new System.Drawing.Size(80, 27);

                constructor_class_table.Controls.Add(Category_text, 1, 5);


                Label Package_label = new Label();
                Package_label.AutoSize = true;
                Package_label.Size = new Size(50, 20);
                Package_label.Text = "PackageType";

                constructor_class_table.Controls.Add(Package_label, 0, 6);

                TextBox Package_text = new TextBox();
                Package_text.Name = "Package_text";
                Package_text.Size = new System.Drawing.Size(80, 27);

                constructor_class_table.Controls.Add(Package_text, 1, 6);


                Label Age_bool_label = new Label();
                Age_bool_label.AutoSize = true;
                Age_bool_label.Size = new Size(50, 20);
                Age_bool_label.Text = "FullAgeAccess";

                constructor_class_table.Controls.Add(Age_bool_label, 0, 7);

                ComboBox Age_bool_choose = new ComboBox();
                Age_bool_choose.Name = "Age_bool_choose";
                Age_bool_choose.Items.AddRange(new object[] { "True", "False" });
                Age_bool_choose.Size = new System.Drawing.Size(200, 27);
                Age_bool_choose.DropDownStyle = ComboBoxStyle.DropDownList;

                constructor_class_table.Controls.Add(Age_bool_choose, 1, 7);


                Label Health_bool_label = new Label();
                Health_bool_label.AutoSize = true;
                Health_bool_label.Size = new Size(50, 20);
                Health_bool_label.Text = "HealthHarting";

                constructor_class_table.Controls.Add(Health_bool_label, 0, 8);

                ComboBox Health_bool_choose = new ComboBox();
                Health_bool_choose.Name = "Health_bool_choose";
                Health_bool_choose.Items.AddRange(new object[] { "True", "False" });
                Health_bool_choose.Size = new System.Drawing.Size(200, 27);
                Health_bool_choose.DropDownStyle = ComboBoxStyle.DropDownList;

                constructor_class_table.Controls.Add(Health_bool_choose, 1, 8);
            };

            Action milk_product_create = () =>
            {
                product_create();

                Label Fat_label = new Label();
                Fat_label.AutoSize = true;
                Fat_label.Size = new Size(50, 20);
                Fat_label.Text = "FatPercent";

                constructor_class_table.Controls.Add(Fat_label, 0, 9);

                TextBox Fat_text = new TextBox();
                Fat_text.Name = "Fat_text";
                Fat_text.Size = new System.Drawing.Size(80, 27);
                Fat_text.KeyPress += key_press;

                constructor_class_table.Controls.Add(Fat_text, 1, 9);


                Label Natural_bool_label = new Label();
                Natural_bool_label.AutoSize = true;
                Natural_bool_label.Size = new Size(50, 20);
                Natural_bool_label.Text = "Natural";

                constructor_class_table.Controls.Add(Natural_bool_label, 0, 10);

                ComboBox Natural_bool_choose = new ComboBox();
                Natural_bool_choose.Name = "Natural_bool_choose";
                Natural_bool_choose.Items.AddRange(new object[] { "True", "False" });
                Natural_bool_choose.Size = new System.Drawing.Size(200, 27);
                Natural_bool_choose.DropDownStyle = ComboBoxStyle.DropDownList;

                constructor_class_table.Controls.Add(Natural_bool_choose, 1, 10);
            };

            Action toy_create = () =>
            {
                Label Old_label = new Label();
                Old_label.AutoSize = true;
                Old_label.Size = new Size(50, 20);
                Old_label.Text = "OldTarget";

                constructor_class_table.Controls.Add(Old_label, 0, 6);

                TextBox Old_text = new TextBox();
                Old_text.Name = "Old_text";
                Old_text.Size = new System.Drawing.Size(80, 27);
                Old_text.KeyPress += key_press_i;

                constructor_class_table.Controls.Add(Old_text, 1, 6);


                Label Boy_bool_label = new Label();
                Boy_bool_label.AutoSize = true;
                Boy_bool_label.Size = new Size(50, 20);
                Boy_bool_label.Text = "BoyTarget";

                constructor_class_table.Controls.Add(Boy_bool_label, 0, 7);

                ComboBox Boy_bool_choose = new ComboBox();
                Boy_bool_choose.Name = "Boy_bool_choose";
                Boy_bool_choose.Items.AddRange(new object[] { "True", "False" });
                Boy_bool_choose.Size = new System.Drawing.Size(200, 27);
                Boy_bool_choose.DropDownStyle = ComboBoxStyle.DropDownList;

                constructor_class_table.Controls.Add(Boy_bool_choose, 1, 7);


                Label Party_bool_label = new Label();
                Party_bool_label.AutoSize = true;
                Party_bool_label.Size = new Size(50, 20);
                Party_bool_label.Text = "PartyToy";

                constructor_class_table.Controls.Add(Party_bool_label, 0, 8);

                ComboBox Party_bool_choose = new ComboBox();
                Party_bool_choose.Name = "Party_bool_choose";
                Party_bool_choose.Items.AddRange(new object[] { "True", "False" });
                Party_bool_choose.Size = new System.Drawing.Size(200, 27);
                Party_bool_choose.DropDownStyle = ComboBoxStyle.DropDownList;

                constructor_class_table.Controls.Add(Party_bool_choose, 1, 8);
            };

            switch(choose_class_combo.SelectedIndex)
            {
                case 0:
                    product_create();
                    break;
                case 1:
                    milk_product_create();
                    break;
                case 2:
                    toy_create();
                    break;
            }

        }

        private void create_butt_Click(object sender, EventArgs e)
        {
            bool created = true;
            string category = "";
            string package = "";
            bool age_b = false;
            bool health_b = false;
            float fat = 0;
            bool natural = false;
            int old = 0;
            bool boy_b = false;
            bool party_b = false;
            if (choose_class_combo.SelectedIndex == -1)
            {
                MessageBox.Show("Select class to create");
                return;
            }

            if(!Int32.TryParse(constructor_class_table.Controls["Cost_text"].Text, out int cost))
            {
                MessageBox.Show("Wrong cost value");
                created = false;
            }
            if (!float.TryParse(constructor_class_table.Controls["Mass_text"].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float mass))
            {
                MessageBox.Show("Wrong mass value");
                created = false;
            }
            string name = constructor_class_table.Controls["Name_text"].Text;
            if (name == "")
            {
                MessageBox.Show("Wrong name value");
                created = false;
            }
            string firm_name = constructor_class_table.Controls["Firm_text"].Text;
            if (firm_name == "")
            {
                MessageBox.Show("Wrong firm name value");
                created = false;
            }
            if (!float.TryParse(constructor_class_table.Controls["Size_text_x"].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float s_x))
            {
                MessageBox.Show("Wrong size x value");
                created = false;
            }
            if (!float.TryParse(constructor_class_table.Controls["Size_text_y"].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float s_y))
            {
                MessageBox.Show("Wrong size y value");
                created = false;
            }
            if (!float.TryParse(constructor_class_table.Controls["Size_text_z"].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float s_z))
            {
                MessageBox.Show("Wrong size z value");
                created = false;
            }
            float[] size = new float[3] { s_x, s_y, s_z };
            Action get_product = () =>
            {
                category = constructor_class_table.Controls["Category_text"].Text;
                if (category == "")
                {
                    MessageBox.Show("Wrong category value");
                    created = false;
                }
                package = constructor_class_table.Controls["Package_text"].Text;
                if (package == "")
                {
                    MessageBox.Show("Wrong package type value");
                    created = false;
                }
                if (!bool.TryParse(constructor_class_table.Controls["Age_bool_choose"].Text, out bool age_b1))
                {
                    MessageBox.Show("Wrong full age acces value");
                    created = false;
                }
                else
                    age_b = age_b1;
                if (!bool.TryParse(constructor_class_table.Controls["Health_bool_choose"].Text, out bool health_b1))
                {
                    MessageBox.Show("Wrong health hurting value");
                    created = false;
                }
                else
                    health_b = health_b1;
            };

            Action get_milk_product = () =>
            {
                get_product();
                if (!float.TryParse(constructor_class_table.Controls["Fat_text"].Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float fat1))
                {
                    MessageBox.Show("Wrong fat percent value");
                    created = false;
                }
                else
                    fat = fat1;
                if (!bool.TryParse(constructor_class_table.Controls["Natural_bool_choose"].Text, out bool natural_b1))
                {
                    MessageBox.Show("Wrong natural value");
                    created = false;
                }
                else
                    natural = natural_b1;
            };

            Action get_toy = () =>
            {
                if (!Int32.TryParse(constructor_class_table.Controls["Old_text"].Text, out int old1))
                {
                    MessageBox.Show("Wrong old value");
                    created = false;
                }
                else
                    old = old1;
                if (!bool.TryParse(constructor_class_table.Controls["Boy_bool_choose"].Text, out bool boy_b1))
                {
                    MessageBox.Show("Wrong boy target value");
                    created = false;
                }
                else 
                    boy_b = boy_b1;
                if (!bool.TryParse(constructor_class_table.Controls["Party_bool_choose"].Text, out bool party_b1))
                {
                    MessageBox.Show("Wrong party toy value");
                    created = false;
                }
                else
                    party_b = party_b1;
            };

            switch (choose_class_combo.SelectedIndex)
            {
                case 0:
                    get_product();
                    if (!created)
                        return;
                    list.Add(new product(cost, mass, size, name, firm_name, 
                        category, package, age_b, health_b));
                    break;
                case 1:
                    get_milk_product();
                    if (!created)
                        return;
                    list.Add(new milk_product(cost, mass, size, name, firm_name,
                        category, package, age_b, health_b, fat, natural));
                    break;
                case 2:
                    get_toy();
                    if (!created)
                        return;
                    list.Add(new Toy(cost, mass, size, name, firm_name,
                        old, boy_b, party_b));
                    break;
            }
            class_list.Items.Add(name);

            MessageBox.Show("Created");
        }

        private void class_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(class_list.SelectedIndex == -1)
                    return;
            Type t = list[class_list.SelectedIndex].GetType();
            if(typeof(product) == t || typeof(milk_product) == t)
            {
                ISay_butt.Visible = true;
                IErase_butt.Visible = true;

                IMove_butt.Visible = false;
                IMath_butt.Visible = false;

                if (typeof(milk_product) == t)
                    IMath_butt.Visible = true;
            }
            if (typeof(Toy) == t)
            {
                ISay_butt.Visible = true;
                IMove_butt.Visible = true;

                IMath_butt.Visible = false;
                IErase_butt.Visible = false;
            }
        }

        private void ISay_butt_Click(object sender, EventArgs e)
        {
            list[class_list.SelectedIndex].Say();
        }

        private void IErase_butt_Click(object sender, EventArgs e)
        {
            ((product)list[class_list.SelectedIndex]).EraseMy();
        }

        private void IMove_butt_Click(object sender, EventArgs e)
        {
            ((Toy)list[class_list.SelectedIndex]).Move();
        }

        private void IMath_butt_Click(object sender, EventArgs e)
        {
            ((milk_product)list[class_list.SelectedIndex]).GetCosine();
        }
    }
}
