using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ListViewSample
{
    internal class ContactsInfoRepository
    {
        #region Methods
        internal ObservableCollection<MembersInfo> GenarateMemberItems(int count)
        {
            var members = new ObservableCollection<MembersInfo>();
            for (int i = 0; i < count; i++)
            {
                Random r = new Random();
                var member = new MembersInfo();
                member.Name = MemberNames[r.Next(0, 20)];
                members.Add(member);
            }
            return members;
        }

        internal ObservableCollection<DetailsContactInfo> GenerateContactDetails(int count)
        {
            Random r = new Random();
            var contactDetails = new ObservableCollection<DetailsContactInfo>();
            for (int i = 0; i < count; i++)
            {
                var details = new DetailsContactInfo()
                {
                    ContactName = CustomerNames[r.Next(0, CustomerNames.Count())],
                    ContactNumber = CustomerNumbers[i],
                    ContactImage = ImageSource.FromResource("ListViewXamarin.Images.Image" + r.Next(0, 28) + ".png")
                };
                contactDetails.Add(details);
            }
            return contactDetails;
        }
        #endregion

        #region Fields

        string[] MemberNames = new string[]
        {
            "Jackson"    ,
            "Mason  "    ,
            "Liam   "    ,
            "Jacob  "    ,
            "Jayden "    ,
            "Ethan  "    ,
            "Noah   "    ,
            "Lucas  "    ,
            "Logan  "    ,
            "Caleb  "    ,
            "Caden  "    ,
            "Jack   "    ,
            "Ryan   "    ,
            "Connor "    ,
            "Michael"    ,
            "Elijah "    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James  "    ,
            "Landon "    ,
            "Nathan "    ,
            "Dylan  "    ,
            "Evan   "    ,
            "Luke   "    ,
            "Andrew "    ,
            "Gabriel"    ,
            "Gavin  "    ,
            "Joshua "    ,
            "Owen   "    ,
            "Daniel "    ,
            "Carter "    ,
            "Tyler  "    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt  "    ,
            "Henry  "    ,
            "Eli    "    ,
            "Joseph "    ,
            "Max    "    ,
            "Isaac  "    ,
            "Samuel "    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David  "    ,
            "Christopher",
            "John   "    ,
            "Isaiah "    ,
            "Levi   "    ,
            "Jonathan"   ,
            "Oliver "    ,
            "Chase  "    ,
            "Cooper "    ,
            "Tristan"    ,
            "Colton "    ,
            "Austin "    ,
            "Colin  "    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker "    ,
            "Hunter "    ,
            "Thomas "    ,
            "Alex   "    ,
            "Ian    "    ,
            "Jordan "    ,
            "Cole   "    ,
            "Julian "    ,
            "Aaron  "    ,
            "Carson "    ,
            "Miles  "    ,
            "Blake  "    ,
            "Brody  "    ,
            "Adam   "    ,
            "Sebastian"  ,
            "Adrian "    ,
            "Nolan  "    ,
            "Sean   "    ,
            "Riley  "    ,
            "Bentley"    ,
            "Xavier "    ,
            "Hayden "    ,
            "Jeremiah"   ,
            "Jason  "    ,
            "Jake   "    ,
            "Asher  "    ,
            "Micah  "    ,
            "Jace   "    ,
            "Brandon"    ,
            "Josiah "    ,
            "Hudson "    ,
            "Nathaniel"  ,
            "Bryson "    ,
            "Ryder  "    ,
            "Justin "    ,
            "Bryce  "    ,
        };
        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",

        };
        string[] CustomerNumbers = new string[]
       {
            "783 - 3617",
            "763 - 3879",
            "754 - 3627",
            "760 - 3893",
            "781 - 3813",
            "720 - 3146",
            "745 - 3151",
            "787 - 3143",
            "789 - 3275",
            "746 - 3950",
            "784 - 3904",
            "738 - 3827",
            "747 - 3550",
            "737 - 3792",
            "772 - 3868",
            "768 - 3312",
            "791 - 3920",
            "723 - 3498",
            "758 - 3115",
            "731 - 3051",
            "753 - 3364",
            "734 - 3443",
            "759 - 3089",
            "769 - 3639",
            "789 - 3289",
            "735 - 3200",
       };
        #endregion
    }
}
