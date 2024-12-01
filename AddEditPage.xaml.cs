using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace KhabirovaMasterPol
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Partners currentPartner = new Partners();

        public bool check = false;

        public AddEditPage(Partners SelectedPartner)
        {
            InitializeComponent();
            var PartnerTypes = KhabirovaMasterPolEntities.GetContext().PartnersType.Select(p => p.PartnersTypeName).ToList();

            foreach (var PartnerType in PartnerTypes)
            {
                ComboType.Items.Add(PartnerType);
            }

            if (SelectedPartner != null)
            {
                check = true;
                currentPartner = SelectedPartner;
                RatingTBox.Text = currentPartner.PartnersRaiting.ToString();
                ComboType.SelectedIndex = currentPartner.PartnersTypeID - 1;
            }
            else
            {
                currentPartner.PartnersRaiting = 0;
                ComboType.SelectedIndex = 0;
            }


            DataContext = currentPartner;

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Int64 r;
            string pattern = @"^(?!\.)(?!.*\.\.)(?!.*\.{2,})[A-Za-z0-9!#$%&'*+/=?^_`{|}~.-]+@[A-Za-z0-9-]+\.[A-Z|a-z]{2,}$";
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersName))
                errors.AppendLine("Укажите название партнера");
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersAdress))
                errors.AppendLine("Укажите адрес");
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersINN) || currentPartner.PartnersINN.Length != 10 || !Int64.TryParse(currentPartner.PartnersINN, out r))
                errors.AppendLine("Укажите ИНН");
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersDirectorName))
                errors.AppendLine("Укажите директора");          
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersPhone))
                errors.AppendLine("Укажите телефон");
            if (string.IsNullOrWhiteSpace(currentPartner.PartnersEmail) || !Regex.IsMatch(currentPartner.PartnersEmail, pattern))
                errors.AppendLine("Укажите Email");
            if (string.IsNullOrWhiteSpace(RatingTBox.Text) || !Int64.TryParse(RatingTBox.Text, out r) || Int64.Parse(RatingTBox.Text) < 0)
                errors.AppendLine("Неверный рейтинг партнера");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            currentPartner.PartnersRaiting = Int32.Parse(RatingTBox.Text);
            currentPartner.PartnersTypeID = ComboType.SelectedIndex + 1;

            var allPartner = KhabirovaMasterPolEntities.GetContext().Partners.ToList();
            allPartner = allPartner.Where(p => p.PartnersName == currentPartner.PartnersName).ToList();
            if (allPartner.Count == 0 || check == true)
            {
                if (currentPartner.PartnersID == 0)
                {
                    KhabirovaMasterPolEntities.GetContext().Partners.Add(currentPartner);
                }

                try
                {
                    KhabirovaMasterPolEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Такой партнер уже сущесвтует!");

        }
    

    }
}

