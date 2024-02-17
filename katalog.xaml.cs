<<<<<<< HEAD
﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> cd381131f7feaafe8fec7316249687a03d844f7d
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
using System.Windows.Shapes;

namespace praktikaMAGAZ
{
    /// <summary>
    /// Логика взаимодействия для katalog.xaml
    /// </summary>
    public partial class katalog : Window
    {
<<<<<<< HEAD
        int count = 0;
        int columns = 0;
        int row = 0;
        int idcount = 1;
        public katalog()
        {
            InitializeComponent();

            
            var contex = new AppDbContext();

            var q = contex.Tovars.Count();
            var w = contex.Tovars.Where(x => x.Id > 0).ToList();

            while (count < q)
            {
                if (columns == 4)
                {
                    columns = 0;
                    row += 1;
                    if (row == 2)
                    {
                        break;
                    }
                }

               
                Image image = new Image();
                string a = w[count].Image.ToString();
                
                image.Source = new BitmapImage(new Uri($"{a}", UriKind.RelativeOrAbsolute));

                Button button = new Button();
                button.Content = a;
                Grid.SetColumn(image, columns);
                Grid.SetRow(image, row);
                dd.Children.Add(image);
                idcount++;
                columns++;
                count++;
            }
=======
        public katalog()
        {
            InitializeComponent();
>>>>>>> cd381131f7feaafe8fec7316249687a03d844f7d
        }
    }
}
