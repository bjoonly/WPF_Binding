using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using System.Threading.Tasks;
using System.Windows;

namespace Binding
{

    public class DataSourse:INotifyPropertyChanged
    {
        private readonly ICollection<ColorModel> colors = new ObservableCollection<ColorModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<ColorModel> Colors => colors;


        private ColorModel selectedColor;
        public ColorModel SelectedColor {
            get { return selectedColor; }
            set { 
                if (value != selectedColor ){
                    selectedColor = value;
                    OnPropertyChanged();

                } }
        }
        public DataSourse()
        {
           SelectedColor = new ColorModel();

        }


        public void AddSelectedColor()
        {
            if (SelectedColor != null)
                colors.Add((ColorModel)SelectedColor.Clone());
         
        }

        public void RemoveSelectedColor()
        {
            if (SelectedColor != null)
            {

                colors.Remove(SelectedColor);
                SelectedColor = new ColorModel();

            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
