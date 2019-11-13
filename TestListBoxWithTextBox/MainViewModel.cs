using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace TestListBoxWithTextBox
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemViewModel> Items { get; } =
            new ObservableCollection<ItemViewModel>();

        private ItemViewModel selectedItem;
        public ItemViewModel SelectedItem
        {
            get => selectedItem;
            set => Set(nameof(SelectedItem), ref selectedItem, value);
        }

        public ICommand AddItemCommand =>
            new RelayCommand(() =>
            {
                var newItem = new ItemViewModel();
                Items.Add(newItem);
                SelectedItem = newItem;
            });
    }
}