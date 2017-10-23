using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using Container.Model;
using System.Runtime.InteropServices;
using Container.Model.Helper;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Container
{

    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow
    {
        public static string nome;
        public static int StatusCode = 0;
        public MainWindow()
        {
            InitializeComponent();
        }




        private void BtnClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
        #region Events_BtnLogin

        private void BtnLogin1_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFF6C0C");
            BtnLogin.Stroke = new SolidColorBrush(color);
          
        }

        private void BtnLogin1_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnLogin.Stroke = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        #endregion

        #region Events_BtnRegister
        private void BtnRegistrar_MouseEnter(object sender, MouseEventArgs e)
        {

            Color color = (Color)ColorConverter.ConvertFromString("#FFFF6C0C");

            BtnRegister.Stroke = new SolidColorBrush(color);

        }

        private void BtnRegistrar_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnRegister.Stroke = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

        }
        #endregion

        private void LblTitle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/Container_Site/index.php");
        }

        private void wndHead_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
#region Butao Close Events

        private void BtnClose_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void BtnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }
        private void BtnCloseG_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgCloseBtn.Source = new BitmapImage(new Uri(@"/Images/closelaranja.png", UriKind.RelativeOrAbsolute));

            Color color = (Color)ColorConverter.ConvertFromString("#FF404040");
            BtnClose.Fill = new SolidColorBrush(color);

        }
        private void BtnCloseG_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgCloseBtn.Source = new BitmapImage(new Uri(@"/Images/close.png", UriKind.RelativeOrAbsolute));

            BtnClose.Fill = new SolidColorBrush(Color.FromArgb(0,0,0,0));
        }

        private void BtnCloseG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnCloseG_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
#endregion
        private void BtnLogin1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StatusCode = 1;
            
           
        }

        private void BtnRegistrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
       
        }


        private void ImgBtnBack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
    
            if (StatusCode == 0)
            {
            }
            else
            {
                StatusCode--;
            }

        }
        private void PAnimReverst()
        {
        }
        private void BtnRegistrar_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (StatusCode == 1)
            {
                if (new UserNotLoggedIn().logarUsuario(TxtLogar.Text, TxtSenha.Password))
                {
                    nome = TxtLogar.Text;
                    new MainAppPage().Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos");
                }   
            }
            else
            {
                Process.Start("http://localhost/Container_Site/cadastro.php");
            }
        }

        private void ImgCloseBtn_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void ImgCloseBtn_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void RectLoginTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFF6C0C");
            RectLoginTxt.Stroke = new SolidColorBrush(color);
        }
		
        private void RectSenha_GotFocus(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFF6C0C");
            RectLoginTxt.Stroke = new SolidColorBrush(color);
        }

        private void RectSenha_LostFocus(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
            RectLoginTxt.Stroke = new SolidColorBrush(color);
        }

        private void RectLoginTxt_LostFocus(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
            
            RectLoginTxt.Stroke = new SolidColorBrush(color);
        }

        private void TxtLogar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                BtnRegistrar_MouseLeftButtonDown_1(null, null);
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnRegistrar_MouseLeftButtonDown_1(null, null);
            }

        }
    }
}
