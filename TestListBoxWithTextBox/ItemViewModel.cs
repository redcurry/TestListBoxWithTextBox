using GalaSoft.MvvmLight;

namespace TestListBoxWithTextBox
{
    public class ItemViewModel : ViewModelBase
    {
        private string name;
        public string Name
        {
            get => name;
            set => Set(nameof(Name), ref name, value);
        }
    }
}