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
    #region ContactInfo_NestedListView
    public class ContactInfo_NestedListView : INotifyPropertyChanged
    {
        #region Fields

        private bool isInnerListVisible;
        private ObservableCollection<DetailsContactInfo> contactDetails;
        private string location;
        #endregion

        #region Properties
        public Command InnerListTapCommand { get; set; }

        public ObservableCollection<DetailsContactInfo> ContactDetails
        {
            get { return contactDetails; }
            set
            {
                contactDetails = value;
                this.RaisedOnPropertyChanged("ContactDetails");
            }
        }

        public bool IsInnerListVisible
        {
            get { return isInnerListVisible; }
            set
            {
                isInnerListVisible = value;
                this.RaisedOnPropertyChanged("IsInnerListVisible");
            }
        }

        public string Location
        {
            get { return location; }
            set { location = value; this.RaisedOnPropertyChanged("Location"); }
        }
        #endregion

        #region Constructor
        public ContactInfo_NestedListView(int CountMax)
        {
            InnerListTapCommand = new Command(OnInnerListTapped);
            var contactsRepository = new ContactsInfoRepository();
            ContactDetails = contactsRepository.GenerateContactDetails(CountMax);
        }
        #endregion

        #region Private Methods

        private void OnInnerListTapped(object obj)
        {
            var item = obj as DetailsContactInfo;
            item.IsSubListVisible = !item.IsSubListVisible;
        }
        #endregion

        #region INotifyPropertyChanged

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
    #endregion

    #region DetailsContactInfo
    public class DetailsContactInfo:INotifyPropertyChanged
    {
        #region Fields

        private string contactName;
        private string contactNumber;
        public ImageSource image;
        private ObservableCollection<MembersInfo> members;
        private bool isSubListVisible;

        #endregion

        #region Constructor
        public DetailsContactInfo()
        {
            Members = new ObservableCollection<MembersInfo>();
            Random r = new Random();
            var membersRepository = new ContactsInfoRepository();
            Members = membersRepository.GenarateMemberItems(r.Next(1, 5));
            
        }
        #endregion

        #region Properties
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; this.RaisedOnPropertyChanged("ContactName"); }
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; this.RaisedOnPropertyChanged("ContactNumber"); }
        }
      
        public ImageSource ContactImage
        {
            get { return this.image; }
            set { this.image = value; this.RaisedOnPropertyChanged("ContactImage"); }
        }

        public ObservableCollection<MembersInfo> Members
        {
            get { return members; }
            set
            {
                this.members = value;
                this.RaisedOnPropertyChanged("Members");
            }
        }

        public bool IsSubListVisible
        {
            get { return isSubListVisible; }
            set
            {
                isSubListVisible = value;
                this.RaisedOnPropertyChanged("IsSubListVisible");
            }
        }
        #endregion

        #region INotifyPropertyChanged

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
    #endregion

    #region Items
    public class MembersInfo : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { this.name = value; this.RaisedOnPropertyChanged("Name"); }
        }
        #endregion

        #region INotifyPropertyChanged

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
    #endregion
}
