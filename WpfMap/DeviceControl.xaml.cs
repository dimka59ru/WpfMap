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

namespace WpfMap
{
    /// <summary>
    /// Логика взаимодействия для DeviceControl.xaml
    /// </summary>
    public partial class DeviceControl : UserControl
    {
        public DeviceControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }

        #region BorderColor DP
        public object BorderColor
        {
            get { return (object)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
        
        public static readonly DependencyProperty BorderColorProperty =
            DependencyProperty.Register("BorderColor", typeof(object),
              typeof(DeviceControl), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        #endregion


        #region Model DP
        public object Model
        {
            get { return (object)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(object),
              typeof(DeviceControl), new PropertyMetadata(null));

        #endregion

        #region Ip DP
        public object Ip
        {
            get { return (object)GetValue(IpProperty); }
            set { SetValue(IpProperty, value); }
        }

        public static readonly DependencyProperty IpProperty =
            DependencyProperty.Register("Ip", typeof(object),
              typeof(DeviceControl), new PropertyMetadata(null));

        #endregion


    }
}
