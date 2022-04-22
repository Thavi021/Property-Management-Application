using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ICE3_ST10120981_Thaveshan_Naidoo_PropertyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        string username;
        string password;

        public List<String> Profile = new List<String>();
        private void CreateUserButton_Click_1(object sender, RoutedEventArgs e)
        {
            username = this.NewUserName.Text;
            Profile.Add(username);

            password = this.NewPassword.Text;
            Profile.Add(password);

            MessageBox.Show("Create Success!!");

            myTabControl.SelectedIndex = 2;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (this.LoginBox.Text == username)
            {
                if(this.LoginPasswordBox.Text == password)
                {
                    MessageBox.Show("Login Success!!");
                    myTabControl.SelectedIndex = 3;

                }
                else
                {
                    this.LoginPasswordBox.Text = "!!!";
                }
            }
            else
            {
                this.LoginBox.Text = "!!!";
            }
        }

        List<int> ID = new List<int>();
        int count = 0;

        List<String> LocationAddress = new List<String>();
        List<String> Discription = new List<String>();
        List<String> Bedrooms = new List<String>();
        List<String> Bathroom = new List<String>();
        List<bool> Pool = new List<bool>();
        List<bool> Pets = new List<bool>();
        List<bool> Garage = new List<bool>();
        List<String> GarageSize = new List<String>();
        List<String> MetersSquared = new List<String>();
        List<String> Price = new List<String>();

 

        private void AddProp_Click(object sender, RoutedEventArgs e)
        {

            //int count=0;
            //int newcount=count + 1;
            
            count++;
            ID.Add(count);
            LocationAddress.Add(this.Location.Text);
            ListView1.Items.Add(count +".   " +this.Location.Text);

            Discription.Add(this.PropertyDiscription.Text);

            Bedrooms.Add(this.BedroomsTB.Text);
            Bathroom.Add(this.Bathrooms.Text);
            Pool.Add((bool)PoolCB.IsChecked);
            Pets.Add((bool)PetsCB.IsChecked);
            Garage.Add((bool)GarageCB.IsChecked);
            GarageSize.Add(this.GarageSpace.Text);
            MetersSquared.Add(this.m2.Text);
            Price.Add(this.PriceTB.Text);

            MessageBox.Show("Addition Success!!");

            int nc = count - 1;
            MessageBox.Show("Location:" + LocationAddress[nc] + "\n" +
                "Description:"+ Discription[nc] + "\n" +
                "Bedrooms:" + Bedrooms[nc] + "\n" +
                "Bathrooms:" + Bathroom[nc] + "\n" +
                "Pool:" + Pool[nc] + "\n" +
                "Garage:" + Garage[nc] + "\n" +
                "GarageSize:" + GarageSize[nc] + "\n" +
                "MetersSquared:" + MetersSquared[nc] + "\n" +
                "Price:" + Price[nc]
                );
           
            //DisplayInfoTB.Text = "Location:"+LocationAddress;

            //listDuplex[0].Item1 //Hello
            //listDuplex[0].Item2 //1
        }


       

            //ListView1.Items.Add(location);

           

        private void MenuButtonCU_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 1;
        }

        private void MenuButtonLI_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 2;
        }

        private void MenuButtonCL_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 3;
        }

        private void MenuButtonVL_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 4;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 3;
        }

        private void ViewPropForSale_Click(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedIndex = 4;

        }

        private void ViewPropMessage_Click(object sender, RoutedEventArgs e)
        {
            count++;
            int selectedcount = int.Parse(this.Count.Text);
            int finalcount = selectedcount - 1;
            if (count == -1)
            { 
                MessageBox.Show("Add a property to view property details!!!");
                myTabControl.SelectedIndex = 3;
            }
            else
            {

                MessageBox.Show("Location:" + LocationAddress[finalcount] + "\n" +
                    "Description:" + Discription[finalcount] + "\n" +
                    "Bedrooms:" + Bedrooms[finalcount] + "\n" +
                    "Bathrooms:" + Bathroom[finalcount] + "\n" +
                    "Pool:" + Pool[finalcount] + "\n" +
                    "Garage:" + Garage[finalcount] + "\n" +
                    "GarageSize:" + GarageSize[finalcount] + "\n" +
                    "MetersSquared:" + MetersSquared[finalcount] + "\n" +
                    "Price:" + Price[finalcount]
                    );

            }
        }
    }
}
