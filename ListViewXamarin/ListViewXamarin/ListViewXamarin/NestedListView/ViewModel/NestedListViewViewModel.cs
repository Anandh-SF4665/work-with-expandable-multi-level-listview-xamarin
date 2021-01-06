using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSample
{
    public class NestedListViewViewModel : INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<ContactInfo_NestedListView> ContactInfo { get; set; }

        public Command<object> OuterListTapCommand { get; set; }
        #endregion

        #region Constructor
        public NestedListViewViewModel()
        {
            OuterListTapCommand = new Command<object>(OnOuterListTapped);
            GenerateDetails();
        }

        private void OnOuterListTapped(object obj)
        {
            var item = obj as ContactInfo_NestedListView;
            item.IsInnerListVisible = !item.IsInnerListVisible;
        }
        #endregion

        #region Private Methods

        private void GenerateDetails()
        {
            ContactInfo = new ObservableCollection<ContactInfo_NestedListView>
            {
                new ContactInfo_NestedListView(3) {Location="Boston"},
                new ContactInfo_NestedListView(1){Location="Italy"},
                new ContactInfo_NestedListView(2){Location="Chicago"},
                new ContactInfo_NestedListView(1) {Location="Denmark"},
                new ContactInfo_NestedListView(1) {Location="Dallas"},
                new ContactInfo_NestedListView(2) {Location="Tunisia"},
                new ContactInfo_NestedListView(1) {Location="Bangkok"},
                new ContactInfo_NestedListView(1) {Location="Tokyo"}

            };
        }

        #endregion

        #region Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion

    }
}
