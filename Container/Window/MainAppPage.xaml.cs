﻿using System;
using Container.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Windows.Controls.DataVisualization.Charting;
using System.Threading.Tasks;

namespace Container
{
    
    /// <summary>
    /// Lógica interna para MainAppPage.xaml
    /// </summary>
    public partial class MainAppPage
    {
        string login = MainWindow.nome;
        int orcabaState = 0;
        int ExpanderCodeState = 0, OrcTodosState = 0; //depois temos que definir os codigos de stado
        public MainAppPage()
        {
            InitializeComponent();

            LblProprietario.Content = login;
            if (Convert.ToInt32(Database.selectSingleValue("empresa",$"nome_empresa = '{login}'")) > 500)
            {
                LblTdeconta.Content = "Premium+";
            }
            else
            {
                LblTdeconta.Content = "Normal";
            }
            DGridOrçamento.DataContext = Database.selectDataTable("materiais");
        }

        private void GridHead_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void ImgCloseBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(1);
        }



        private void App_Exit(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnClose_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgCloseBtnAPage.Source = new BitmapImage(new Uri(@"/Images/closelaranja.png", UriKind.RelativeOrAbsolute));

            Color color = (Color)ColorConverter.ConvertFromString("#FF404040");
            BtnCloseAPage.Fill = new SolidColorBrush(color);
        }

        private void BtnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgCloseBtnAPage.Source = new BitmapImage(new Uri(@"/Images/close.png", UriKind.RelativeOrAbsolute));

            BtnCloseAPage.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void BtnClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }





        private void ExpandGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ExpandGrid_MouseEnter(object sender, MouseEventArgs e)
        {



        }

        

        private void RectAba_MouseEnter(object sender, MouseEventArgs e)
        {

            Color colors = (Color)ColorConverter.ConvertFromString("#FF0E0E0F");
            Color colore = (Color)ColorConverter.ConvertFromString("#FF1A1A1A");

            RectAba.Fill = new LinearGradientBrush(colore, colors, 0);
        }

        private void RectAba_MouseLeave(object sender, MouseEventArgs e)
        {

            Color colors = (Color)ColorConverter.ConvertFromString("#FF0E0E0F");
            Color colore = (Color)ColorConverter.ConvertFromString("#FF141414");
            RectAba.Fill = new LinearGradientBrush(colore, colors, 0);

        }
        private void RectAba_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (ExpanderCodeState)
            {
                case 0:
                    {
                        Storyboard sb = FindResource("AbrirMenuzin") as Storyboard;
                        sb.Begin();
                        ExpanderCodeState = 1;
                        break;
                    }
                case 1:
                    {
                        Storyboard sbr = FindResource("FecharMenuzin") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 0;
                        break;
                    }
                case 3:
                    {
                        Storyboard sbr = FindResource("AbrirMenuRegistrar") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 4;
                        break;
                    }
                case 5:
                    {
                        Storyboard sbr = FindResource("AbrirMenuFunc") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 6;
                        break;
                    }
            }

        }
        private void RegistrarFunc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 1 || ExpanderCodeState == 0)
            {
                Storyboard sbr12 = FindResource("FecharMenuzin") as Storyboard;
                sbr12.Begin();

                ExpanderCodeState = 5;

          

            }
            else if (ExpanderCodeState == 4)
            {
                Storyboard sbr12 = FindResource("FecharMenuzin") as Storyboard;
                sbr12.Begin();

                ExpanderCodeState = 5;
            }
            else if (ExpanderCodeState == 5)
            {
                MessageBox.Show("C é burro ou oq?");
            }
        }
        private void GridMenuRegistrarOrc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 0 || ExpanderCodeState == 1)
            {
                Storyboard sbr12 = FindResource("Registrar Orcamento") as Storyboard;


                sbr12.Begin();

                ExpanderCodeState = 3;
                RectOrçamentoSelect.Opacity = 255;

            }
            else if (ExpanderCodeState == 4)
            {
                MessageBox.Show("C é burro ou oq?");
            }
            else if (ExpanderCodeState == 6)
            {

                ExpanderCodeState = 3;

            }
        }

        private void GridMenuPrincipal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard sbr = FindResource("VoltarMenuPrincipal") as Storyboard;
            sbr.Begin();
            ExpanderCodeState = 0;
 
        }

        private void GridMenuRegistrarOrc_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }

        private void GridMenuRegistrarOrc_MouseLeave(object sender, MouseEventArgs e)
        {

            Color color = (Color)ColorConverter.ConvertFromString("#00FFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }



        private void GridAddOrc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Color colore = (Color)ColorConverter.ConvertFromString("#FFB2B2B2");
            plush.Fill = new SolidColorBrush(colore);
            plusv.Fill = new SolidColorBrush(colore);
            Color colorb = (Color)ColorConverter.ConvertFromString("#FF00B229");
            ElpseAddOrc.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 178, 41));
            DateTime theDate = DateTime.Now;
            string id = Database.selectSingleValue("empresa","nome_empresa = '" + login.ToString() + "'");
            Database.insert("orcamento", "default," + "'"+ TxtRegistrarOrc.Text + "'," + "'" + tatsar.Text + "'," + "'" + theDate.ToString("yyyy-MM-dd H:mm:ss") +  "',NULL,NULL,NULL,NULL," + id);
            DGridOrçamento.DataContext = Database.selectDataTable("orcamento");



        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Color colore = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
            plush.Fill = new SolidColorBrush(colore);
            plusv.Fill = new SolidColorBrush(colore);
            Color colorb = (Color)ColorConverter.ConvertFromString("#FF00FF3A");

            ElpseAddOrc.Stroke = new SolidColorBrush(colorb);


        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private async void rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            switch (orcabaState)
            {
                case 0:
                    {
                        orcabaState = 1;
                        //mudar conteudo da datagrid para os operarios
                       
                        Storyboard sbr = FindResource("AbazinhaOrc") as Storyboard;
                        sbr.Begin();
                        await Task.Delay(500);
                        DGridOrçamento.Columns[0].Visibility = Visibility.Collapsed;

                        DGridOrçamento.DataContext = Database.selectDataTable("funcionarios");

                        break;
                    }
                case 1:
                    {
                        orcabaState = 0;
                        //mudar conteudo datagrid para materiais
                        
                        Storyboard sbr = FindResource("AbazinhaOrcr") as Storyboard;
                        sbr.Begin();
                        await Task.Delay(500);
                        DGridOrçamento.Columns[0].Visibility = Visibility.Collapsed;
                        DGridOrçamento.DataContext = Database.selectDataTable("materiais");

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }




        private void RegistrarFunc_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");


        }

        private void RegistrarFunc_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#00FFFFFF");

        }

        private void DGridOrçamento_Initialized(object sender, EventArgs e)
        {
           

            
        }

        private void DGridOrçamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GridMenuEditar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 0 || ExpanderCodeState == 1)
            {
                Storyboard sbr12 = FindResource("AbrirEditar") as Storyboard;


                sbr12.Begin();

                ExpanderCodeState = 3;


            }
            else if (ExpanderCodeState == 4)
            {
                //MessageBox.Show("C é burro ou oq?");
            }
            else if (ExpanderCodeState == 6)
            {

                //ExpanderCodeState = 3;
            }
        }
        private void GridMenuEditar_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }
        private void GridMenuEditar_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }
        private async void RectAbaOrcT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OrcTodosState == 0)
            {
                Storyboard sb = FindResource("IrPOrcamentos") as Storyboard;
                sb.Begin();
                await Task.Delay(500);
                DGridOrçamento.DataContext = Database.selectDataTable("orcamento");
                OrcTodosState = 1;
                RectTrocaAba.IsHitTestVisible = false;
            }
            else
            {
                Storyboard sb = FindResource("IrPTodos") as Storyboard;
                sb.Begin();
                await Task.Delay(500);
                if(orcabaState == 0)
                {
                    DGridOrçamento.DataContext = Database.selectDataTable("materiais");
                }
                else
                {
                    DGridOrçamento.DataContext = Database.selectDataTable("funcionarios");

                }

                OrcTodosState = 0;
                RectTrocaAba.IsHitTestVisible = true;

            }
        }
    }
}